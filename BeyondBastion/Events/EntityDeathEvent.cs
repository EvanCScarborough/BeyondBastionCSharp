using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;
using BeyondBastion.Items.Equipment;

namespace BeyondBastion.Events
{
    public class EntityDeathEvent
    {
        public EntityDeathEvent(IEntity entityKilled, IEntity killer=null, WeaponItem weapon=null)
        {
            EntityKilled = entityKilled;
            Killer = killer;
            Weapon = weapon;
        }

        public IEntity EntityKilled { get; }
        public IEntity Killer { get; }
        public WeaponItem Weapon { get; }
    }
}
