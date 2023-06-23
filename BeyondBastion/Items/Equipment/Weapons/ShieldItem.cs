using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment
{
    public abstract class ShieldItem : EquipmentItem
    {
        public ShieldItem(
            string name, 
            string description,
            double weight,
            double value,
            double blockChance,
            double counterChance
        )
            : base
            (
                name,
                description,
                weight,
                value,
                EquipmentSlot.OffHand
            )
        {
            BlockChance = blockChance;
            CounterChance = counterChance;
        }

        public double BlockChance { get; }
        public double CounterChance { get; }
    }
}
