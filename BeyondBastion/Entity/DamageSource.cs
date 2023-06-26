using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Entity
{
    public enum DamageSource
    {
        MeleeAttack,
        RangedAttack,
        Bleed,
        Absolute,       // damage that should not be mitigated or have body part multiplier applied
    }
    public enum SanityDamageSource
    {
        WitnessDeath,
        Murder,
    }

    public enum EnergyDamageSource
    {
        Hunger,
    }
}
