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
using BeyondBastion.Items;

namespace BeyondBastion
{
    public class CombatHandler
    {
        private static Random Random = new Random();
        private List<IEntity> Combatants { get; set; }
        private List<IEntity> EnemiesKilled { get; set; }
        private List<IEntity> PartyMembersKilled { get; set; }
        public List<ItemStack> LootList { get; set; }
        public List<CombatAction> NextMoveList { get; set; }
        private World CurrentWorld { get; set; }

        public event EventHandler<CombatStartEvent> OnCombatStart;                // invoked before first round of combat
        public event EventHandler<CombatRoundStartEvent> OnCombatRoundStart;      // invoked before every round of combat is simulated
        public event EventHandler<CombatActionEvent> OnCombatAction;              // invoked after action result is confirmed but before damage/healing/etc is applied
        public event EventHandler<CombatActionEvent> OnCombatTurnEnd;             // invoked when a character's action for the round and all its consequences are finished
        public event EventHandler<CombatRoundEndEvent> OnCombatRoundEnd;          // invoked when a round of combat is finished simulating
        public event EventHandler<CombatEndEvent> OnCombatEnd;                    // invoked when combat is finished

        public void Commence(World currentWorld)
        {
            CurrentWorld = currentWorld;

            Combatants = CurrentWorld.PlayerParty.Concat(CurrentWorld.Enemies).ToList();
            EnemiesKilled = new List<IEntity>();
            PartyMembersKilled = new List<IEntity>();
            LootList = new List<ItemStack>();

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
                if (CurrentWorld.Enemies.Count == 0 || CurrentWorld.PlayerParty.Count == 0) { break; }
                if (action.Actor.IsDead) { continue; }

                if (action.Type == CombatActionType.Attack)
                {
                    while (action.Target == null || action.Target.IsDead)
                    {
                        action.Target = GetTargetFor(action.Actor);
                    }

                    if (Random.NextDouble() < action.Target.GetBlockChance())
                    {
                        CombatActionEvent e = new CombatActionEvent(
                            action.Actor,
                            action.Target,
                            CombatActionType.Attack,
                            CombatActionResult.Block,
                            null);

                        OnCombatAction?.Invoke(this, e);

                        OnCombatTurnEnd?.Invoke(this, e);
                    }
                    else
                    {
                        BodyPart hitLocation = action.Target.BodyParts[Random.Next(action.Target.BodyParts.Count)];

                        Injury inflictedInj = GetResultingInjuries(action.Actor, hitLocation, action.Target);

                        CombatActionEvent e = new CombatActionEvent(
                            action.Actor,
                            action.Target,
                            CombatActionType.Attack,
                            CombatActionResult.Hit,
                            hitLocation,
                            inflictedInj);

                        OnCombatAction?.Invoke(this, e);

                        if (inflictedInj != null)
                        {
                            action.Target.Injure(hitLocation, inflictedInj, action.Actor);
                        }

                        action.Target.TakeDamage(
                            action.Actor.GetAttackDamage(),
                            hitLocation,
                            DamageSource.MeleeAttack,
                            action.Actor);


                        OnCombatTurnEnd?.Invoke(this, e);
                    }
                }
                Thread.Sleep(800 + Random.Next(1000));
            }
            NextMoveList = GetRoundMoveList();
            OnCombatRoundEnd?.Invoke(this, new CombatRoundEndEvent());
        }

        public Injury GetResultingInjuries(IEntity attacker, BodyPart hitLocation, IEntity defender)
        {
            double seed = Random.NextDouble();
            double dismemberThreshold = attacker.GetDismemberChance() * (1 - defender.GetBodyPartMitigation(hitLocation));
            foreach (Injury inj in hitLocation.GetInjuries())
            {
                dismemberThreshold += attacker.GetDismemberChance() * 0.5 * (1 - defender.GetBodyPartMitigation(hitLocation));
            }
            if (seed < dismemberThreshold)
            {
                return new Injury(InjuryType.Dismemberment);
            }

            if (hitLocation.GetInjuries().Find(x => x.Type == InjuryType.Fracture) == null) // if the hitLocation body part does not already have a fracture injury
            {
                seed = Random.NextDouble();
                double fractureThreshold = attacker.GetFractureChance() * (1 - defender.GetBodyPartMitigation(hitLocation));
                if (seed < fractureThreshold)
                {
                    return new Injury(InjuryType.Fracture);
                }
            }
            double woundThreshold = attacker.GetWoundChance() * (1 - defender.GetBodyPartMitigation(hitLocation));
            if (seed < woundThreshold)
            {
                if (seed * 1.5 < woundThreshold)
                {
                    return new Injury(InjuryType.MajorWound);
                }
                else
                {
                    return new Injury(InjuryType.MinorWound);
                }
            }
            return null;
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
