using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;
using BeyondBastion.Entity.BodyParts;
using BeyondBastion.Events.Combat;
using System.Threading;
using BeyondBastion.Events;

namespace BeyondBastion
{
    public class CombatHandler
    {
        private static Random Random = new Random();
        private List<IEntity> Combatants { get; set; }
        private List<IEntity> EnemiesKilled { get; set; }
        private List<IEntity> PartyMembersKilled { get; set; }
        public List<CombatAction> NextMoveList { get; set; }
        private World CurrentWorld { get; set; }

        public event EventHandler<CombatStartEvent> OnCombatStart;                // invoked before first round of combat
        public event EventHandler<CombatRoundStartEvent> OnCombatRoundStart;      // invoked before every round of combat is simulated
        public event EventHandler<CombatActionEvent> OnCombatAction;              // invoked anytime an action is taken by an entity during combat
        public event EventHandler<CombatRoundEndEvent> OnCombatRoundEnd;          // invoked when a round of combat is finished simulating
        public event EventHandler<CombatEndEvent> OnCombatEnd;                    // invoked when combat is finished

        public void Commence(World currentWorld)
        {
            CurrentWorld = currentWorld;

            Combatants = CurrentWorld.PlayerParty.Concat(CurrentWorld.Enemies).ToList();
            EnemiesKilled = new List<IEntity>();
            PartyMembersKilled = new List<IEntity>();

            foreach (var entity in Combatants)
            {
                entity.CooldownTicks = Random.Next(GetMaxCooldown(entity));
            }

            NextMoveList = GetRoundMoveList();
            OnCombatStart?.Invoke(this, new CombatStartEvent());
        }

        public List<CombatAction> GetRoundMoveList()
        {
            List<CombatAction> moveOrder = new List<CombatAction>();
            for (int i = 0; i < 100;  i++)
            {
                foreach (var entity in Combatants)
                {
                    entity.CooldownTicks--;
                    if (entity.CooldownTicks <= 0)
                    {
                        entity.CooldownTicks = GetMaxCooldown(entity);
                        moveOrder.Add(new CombatAction(entity, CombatActionType.Attack));
                    }
                }
            }
            return moveOrder;
        }

        public void SimulateRound()
        {
            OnCombatRoundStart?.Invoke(this, new CombatRoundStartEvent());
            foreach (CombatAction action in NextMoveList)
            {
                if (action.Actor.IsDead || CurrentWorld.Enemies.Count == 0 || CurrentWorld.PlayerParty.Count == 0) { continue; }
                if (action.Type == CombatActionType.Attack)
                {
                    while (action.Target == null || action.Target.IsDead)
                    {
                        action.Target = GetTargetFor(action.Actor);
                    }

                    if (Random.NextDouble() < action.Target.GetBlockChance())
                    {
                        OnCombatAction?.Invoke(this, new CombatActionEvent(
                            action.Actor, 
                            action.Target, 
                            CombatActionType.Attack,
                            CombatActionResult.Block, 
                            null));
                    }
                    else
                    {
                        BodyPart hitLocation = action.Target.BodyParts[Random.Next(action.Target.BodyParts.Count)];

                        action.Target.TakeDamage(
                            action.Actor.GetAttackDamage(),
                            hitLocation,
                            DamageSource.MeleeAttack,
                            action.Actor);

                        OnCombatAction.Invoke(this, new CombatActionEvent(
                            action.Actor, 
                            action.Target, 
                            CombatActionType.Attack, 
                            CombatActionResult.Hit, 
                            hitLocation));
                    }
                }
                Thread.Sleep(1000);
            }
            OnCombatRoundEnd?.Invoke(this, new CombatRoundEndEvent());
        }

        public void OnEntityDeath(object sender, EntityDeathEvent e)
        {
            if (e.WasPartyMember)
            {
                PartyMembersKilled.Add(e.EntityKilled);
            }
            else
            {
                EnemiesKilled.Add(e.EntityKilled);
            }
            Combatants.Remove(e.EntityKilled);

            if (CurrentWorld.Enemies.Count == 0)
            {
                OnCombatEnd?.Invoke(this, new CombatEndEvent(CombatEndEvent.CombatEndResult.Victory, EnemiesKilled, PartyMembersKilled));
                EnemiesKilled.Clear();
                PartyMembersKilled.Clear();
            }
            else if (CurrentWorld.PlayerParty.Count == 0)
            {
                OnCombatEnd?.Invoke(this, new CombatEndEvent(CombatEndEvent.CombatEndResult.Defeat, EnemiesKilled, PartyMembersKilled));
                EnemiesKilled.Clear();
                PartyMembersKilled.Clear();
            }
        }

        public static int GetMaxCooldown(IEntity entity)
        {
            return (int)Math.Ceiling(100 / entity.GetAttackSpeed());
        }

        public IEntity GetTargetFor(IEntity attacker)
        {
            if (CurrentWorld.PlayerParty.Contains(attacker))
            {
                return CurrentWorld.Enemies[Random.Next(CurrentWorld.Enemies.Count)];
            }
            else if (CurrentWorld.Enemies.Contains(attacker))
            {
                return CurrentWorld.PlayerParty[Random.Next(CurrentWorld.PlayerParty.Count)];
            }
            else throw new Exception();
        }
    }
}
