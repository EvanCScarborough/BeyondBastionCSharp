using BeyondBastion.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Events.Combat
{
    public class CounterAttackEvent
    {
        public CounterAttackEvent(IEntity actor, IEntity target)
        {
            Actor = actor;
            Target = target;
        }
        public IEntity Actor { get; }
        public IEntity Target { get; }
    }
}
