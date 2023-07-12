using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment.Weapons
{
    public class Shortsword : WeaponItem
    {
        public Shortsword() : base
            (
                "Shortsword",           // name
                "A Shortsword",         // description
                2.4,                    // weight
                16,                     // base damage
                WeaponType.Technique,   // weapon type
                1.4,                    // attack speed
                0.1,                    // parry chance
                0.26,                   // wound chance
                0.06,                   // fracture chance
                0.06,                   // dismember chance
                0.04,                   // knockdown chance
                0.2                     // damage scaling
            )
        { }
    }
}
