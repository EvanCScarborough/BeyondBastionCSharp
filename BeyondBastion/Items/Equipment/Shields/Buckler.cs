using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment.Shields
{
    public class Buckler : ShieldItem
    {
        public Buckler() : base
            (
            "Buckler",
            "A small, light metal shield with a curved center. Requires proactive positioning by the wielder due to its size. Best used to deflect enemy attacks with a punching motion and set up a counterattack.",
            2,
            GenerateStat(0.08, 0.16),
            GenerateStat(0.38, 0.48),
            0.45,
            WeaponType.Technique
            ) { }
    }
}