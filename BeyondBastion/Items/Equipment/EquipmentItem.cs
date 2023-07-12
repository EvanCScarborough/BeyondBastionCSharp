using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment
{
    public abstract class EquipmentItem : Item
    {
        public EquipmentItem(string name, string description, double weight, int value, EquipmentSlot slot) : base(name, description, weight, value, true)
        {
            Slot = slot;
            Quality = QualityLevel.GetRandom();

            double tierSeed = StaticRandom.Double();
            if (tierSeed >= 0.95)
            {
                Tier = Tier.Hallowed;
            }
            else if (tierSeed >= 0.70)
            {
                Tier = Tier.Blessed;
            }
            else
            {
                Tier = Tier.Standard;
            }
        }
        public EquipmentSlot Slot { get; }
        public Tier Tier { get; }
        public double Quality;

        public static double GenerateStat(double min, double max, bool isPercent=true)
        {
            return isPercent ? Math.Round(min + StaticRandom.Double() * (max - min), 2) : Math.Round(min + StaticRandom.Double() * (max - min), 1);
        }
        public abstract void SetValue();
    }
}
