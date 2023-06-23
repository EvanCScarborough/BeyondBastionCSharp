using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Entity
{
    public interface IEntity
    {
        string Name { get; }
        double Health { get; }
        double Energy { get; }
        double Sanity { get; }

        int Vitality { get; }
        int Focus { get; }
        int Endurance { get; }
        int Strength { get; }
        int Knowledge { get; }
        int Charisma { get; }

        int GetMaxHealth();
        int GetMaxEnergy();
        int GetMaxSanity();
    }
}
