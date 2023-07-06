using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;
using BeyondBastion.Items;

namespace BeyondBastion.Events
{
    public class EntityDisarmEvent
    {
        public EntityDisarmEvent(IEntity actor, Item droppedItem, bool placedInInventory)
        {
            Actor = actor;
            DroppedItem = droppedItem;
            PlacedInInventory = placedInInventory;
        }
        public IEntity Actor;
        public Item DroppedItem { get; }
        public bool PlacedInInventory { get; }
    }
}
