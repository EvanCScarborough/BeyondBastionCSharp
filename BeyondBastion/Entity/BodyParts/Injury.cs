using BeyondBastion.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Entity.BodyParts
{
    public enum InjuryType
    {
        MinorWound = 1,
        MajorWound = 2,
        Fracture = 3,
        Dismemberment = 10
    }
    public class Injury
    {
        public Injury(InjuryType type)
        {
            Type = type;
            switch (Type)
            {
                case InjuryType.MinorWound:
                    Name = "Minor Wound";
                    Description = $"Reduces maximum health by {GetPenalty() * 100}%.";
                    break;
                case InjuryType.MajorWound:
                    Name = "Major Wound";
                    Description = $"Reduces maximum health by {GetPenalty() * 100}%.";
                    break;
                case InjuryType.Fracture:
                    Name = "Fracture";
                    Description = $"Reduces maximum health by {GetPenalty() * 100}%. Prevents the body part from functioning properly.";
                    break;
                case InjuryType.Dismemberment:
                    Name = "Dismembered";
                    Description = $"Reduces maximum health by {GetPenalty() * 100}%. Dismembered body parts cannot be used or healed by natural means.";
                    break;
            }
        }
        public InjuryType Type { get; }
        public string Name { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public double GetPenalty()
        {
            return (Type == InjuryType.Fracture) ? 0.02 * (int)Type : 0.04 * (int)Type;
        }
    }
}
