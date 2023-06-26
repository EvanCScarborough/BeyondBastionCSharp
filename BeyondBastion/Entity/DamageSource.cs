using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Entity
{
    public enum DamageSource // used to determine what reductions to apply and what the log message should display if the damage is fatal
    {
        Absolute,   // damage that should not be mitigated or have body part multiplier applied

        // HEALTH
        MeleeAttack,
        RangedAttack,
        Bleed,

        // SANITY
        WitnessDeath,
        CommitMurder,

        // ENERGY
        Hunger,
    }
}
