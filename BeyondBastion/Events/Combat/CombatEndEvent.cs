using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;

namespace BeyondBastion.Events.Combat
{
    public class CombatEndEvent
    {
        public enum CombatEndResult
        {
            Victory,
            Defeat,
        }
        public CombatEndEvent(CombatEndResult result, List<IEntity> enemiesKilled, List<IEntity> partyMembersKilled)
        {
            Result = result;
            EnemiesKilled = enemiesKilled;
            PartyMembersKilled = partyMembersKilled;
        }
        public CombatEndResult Result { get; }
        public List<IEntity> EnemiesKilled { get; }
        public List<IEntity> PartyMembersKilled { get; }
    }
}
