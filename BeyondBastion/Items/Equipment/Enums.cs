using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment
{
    public enum EquipmentSlot
    {
        Head = 0,
        Torso = 1,
        Arms = 2,
        Legs = 3,
        MainHand = 4,
        OffHand = 5,
    }

    public enum Tier
    {
        Common = 0,
        Blessed = 1,
        Hallowed = 2,
    }

    public enum WeaponType
    {
        Power,
        Technique
    }
}