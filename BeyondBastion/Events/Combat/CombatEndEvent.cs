using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;
using BeyondBastion.Items;

namespace BeyondBastion.Events.Combat
{
    public class CombatEndEvent
    {
        public enum CombatEndResult
        {
            Victory,
            Defeat,
        }
        public CombatEndEvent(CombatEndResult result, List<IEntity> enemiesKilled, List<IEntity> partyMembersKilled, List<ItemStack> lootList=null)
        {
            Result = result;
            EnemiesKilled = enemiesKilled;
            PartyMembersKilled = partyMembersKilled;
            LootList = lootList;
        }
        public CombatEndResult Result { get; }
        public List<IEntity> EnemiesKilled { get; }
        public List<IEntity> PartyMembersKilled { get; }
        public List<ItemStack> LootList { get; }
    }
}
