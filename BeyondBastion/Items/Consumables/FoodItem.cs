using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Consumables
{
    public enum FoodType
    {
        Protein,
        Starch,
        Comfort,
    }
    public abstract class FoodItem : Item
    {
        public FoodItem(string name, string description, double weight, int value, FoodType type, double bonusAmnt, double stomachAmnt) : base(name, description, weight, value, consumable: true)
        {
            Type = type;
            BonusAmnt = bonusAmnt;
            FullnessAmnt = stomachAmnt;
        }

        public FoodType Type { get; }
        public double BonusStat { get; }
        public double BonusAmnt { get; }
        public double FullnessAmnt { get; }
    }
}
