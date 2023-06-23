using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment
{
    public abstract class EquipmentItem : Item
    {
        public EquipmentItem(string name, string description, double weight, double value, EquipmentSlot slot) : base(name, description, weight, value, true)
        {
            Slot = slot;

            double tierSeed = new Random().NextDouble();
            if (tierSeed >= 0.89)
            {
                Tier = Tier.Hallowed;
            }
            else if (tierSeed >= 0.66)
            {
                Tier = Tier.Blessed;
            }
            else
            {
                Tier = Tier.Common;
            }
        }
        private static Random random = new Random();
        public EquipmentSlot Slot { get; }
        public Tier Tier { get; }

        public static double GenerateStat(double min, double max, bool isPercent=true)
        {
            return isPercent ? Math.Round(min + random.NextDouble() * (max - min), 3) : Math.Round(min + random.NextDouble() * (max - min), 1);
        }
    }
}
