using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;
using BeyondBastion.Events;

namespace BeyondBastion
{
    public class CombatHandler
    {
        private static Random Random = new Random();
        public List<IEntity> Combatants { get; set; }
        public List<IEntity> EnemiesKilled { get; set; }
        public void Commence(World currentWorld)
        {
            Combatants = currentWorld.PlayerParty.Concat(currentWorld.Enemies).ToList();
            foreach (var entity in Combatants)
            {
                entity.CooldownTicks = Random.Next(GetMaxCooldown(entity));
            }
        }

        public List<CombatAction> GetRoundMoveOrder()
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

        public static int GetMaxCooldown(IEntity entity)
        {
            return (int)Math.Ceiling(100 / entity.GetAttackSpeed());
        }
    }
}
