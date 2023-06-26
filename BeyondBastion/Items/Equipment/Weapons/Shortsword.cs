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
                "Shortsword",                       // name
                "A Shortsword",                     // description
                GenerateStat(2.2, 2.6, false),      // weight
                10,                                 // value
                GenerateStat(12, 18, false),        // base damage
                WeaponType.Technique,               // weapon type
                GenerateStat(1.4, 1.6, false),      // attack speed
                GenerateStat(0.08, 0.16),           // block chance
                GenerateStat(0.18, 0.26),           // wound chance
                GenerateStat(0.06, 0.08),           // fracture chance
                GenerateStat(0.02, 0.06),           // dismember chance
                GenerateStat(0.06, 0.10),           // knockdown chance
                0.2                                 // damage scaling
            )
        { }
    }
}
