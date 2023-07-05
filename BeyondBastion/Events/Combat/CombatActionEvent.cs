using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;
using BeyondBastion.Entity.BodyParts;

namespace BeyondBastion.Events.Combat
{
    public enum CombatActionResult
    {
        Hit,
        Block,
    }
    public class CombatActionEvent
    {
        public CombatActionEvent(IEntity actor, IEntity target, CombatActionType type, CombatActionResult result, BodyPart hitLoc=null)
        {
            Actor = actor;
            Target = target;
            Type = type;
            Result = result;
            HitLocation = hitLoc;
        }

        public IEntity Actor;
        public IEntity Target;
        public CombatActionType Type;
        public CombatActionResult Result;
        public BodyPart HitLocation;
    }
}
