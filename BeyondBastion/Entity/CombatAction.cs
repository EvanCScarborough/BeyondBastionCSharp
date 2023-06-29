using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Entity
{
    public enum CombatActionType
    {
        Attack,
        UseItem,
        Defend
    }
    public class CombatAction
    {
        public CombatAction(IEntity actor, CombatActionType type, IEntity target=null)
        {
            Actor = actor;
            Type = type;
            Target = target;
        }
        public IEntity Actor;
        public IEntity Target;
        public CombatActionType Type;
    }
}
