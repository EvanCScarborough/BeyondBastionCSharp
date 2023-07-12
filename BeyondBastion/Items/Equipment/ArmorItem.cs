using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment
{
    abstract class ArmorItem : EquipmentItem
    {
        public ArmorItem(string name, 
            string description, 
            double weight, 
            int value, 
            EquipmentSlot slot) : base(name, description, weight, value, slot) { }
        public double Mitigation { get; }
        //public double InjuryProtection { get; }
    }
}
