using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items
{
    public abstract class Item
    {
        public Item(string name,
            string description,
            double weight,
            double value,
            bool equippable = false,
            bool consumable = false,
            bool destructible = true)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
            IsEquippable = equippable;
            IsConsumable = consumable;
            IsDestructible = destructible;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Value { get; set; }
        public bool IsEquippable { get; set; } = false;
        public bool IsConsumable { get; set; } = false;
        public bool IsDestructible { get; set; } = true;

        public override string ToString()
        {
            return Name;
        }
    }
}
