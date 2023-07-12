using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment.Shields
{
    public abstract class ShieldItem : EquipmentItem
    {
        public ShieldItem(
            string name, 
            string description,
            double weight,
            double blockChance,
            double counterChance,
            double scaling,
            WeaponType type
        )
            : base
            (
                name,
                description,
                weight,
                0,
                EquipmentSlot.OffHand
            )
        {
            BlockChance = blockChance;
            CounterChance = counterChance;
            Scaling = scaling;
            Type = type;
            SetValue();
        }

        private double BlockChance { get; }
        private double CounterChance { get; }
        public double Scaling { get; }
        public WeaponType Type { get; }
        public override void SetValue()
        {
            Value = (int)Math.Ceiling((BlockChance * 350) + (CounterChance * 550 * BlockChance));
        }

        public double GetBlockChance()
        {
            return Math.Round(BlockChance * Quality, 2);
        }

        public double GetCounterChance()
        {
            return Math.Round(CounterChance * Quality, 2);
        }
    }
}
