using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Entity.BodyParts
{
    public enum BodyPartType
    {
        Head,
        LeftArm,
        RightArm,
        Torso,
        LeftLeg,
        RightLeg
    }

    public class BodyPart
    {
        public BodyPart(BodyPartType type, List<Injury> injuries = null) 
        {
            Type = type;
            switch (Type)
            {
                case BodyPartType.Head:
                    DamageMultiplier = 3;
                    Name = "Head";
                    break;
                case BodyPartType.LeftArm:
                    DamageMultiplier = 0.5;
                    Name = "Left Arm";
                    break;
                case BodyPartType.RightArm:
                    DamageMultiplier = 0.5;
                    Name = "Right Arm";
                    break;
                case BodyPartType.Torso:
                    DamageMultiplier = 1;
                    Name = "Torso";
                    break;
                case BodyPartType.LeftLeg:
                    DamageMultiplier = 0.5;
                    Name = "Left Leg";
                    break;
                case BodyPartType.RightLeg:
                    DamageMultiplier = 0.5;
                    Name = "Right Leg";
                    break;
                default: throw new Exception();
            }
            if (injuries == null) { Injuries = new List<Injury>(); }
        }

        public BodyPartType Type { get; }
        public double DamageMultiplier { get; }
        public string Name { get; }
        private List<Injury> Injuries { get; set; }

        public Injury AddInjury(InjuryType type)
        {
            Injury injury = new Injury(type);
            if (injury.Type == InjuryType.Dismemberment)
            {
                Injuries = new List<Injury>
                {
                    injury
                };
            }
            else
            {
                Injuries.Add(injury);
            }
            return injury;
        }

        public Injury AddInjury(Injury inj)
        {
            if (inj.Type == InjuryType.Dismemberment)
            {
                Injuries = new List<Injury>
                {
                    inj
                };
            }
            else
            {
                Injuries.Add(inj);
            }
            return inj;
        }

        public List<Injury> GetInjuries()
        {
            return Injuries;
        }

        public double GetPenaltyFromInjuries()
        {
            double penalty = 0;
            foreach (Injury inj in Injuries)
            {
                penalty += inj.GetPenalty();
            }
            return penalty;
        }

        public List<Injury> RemoveInjury(InjuryType type, bool removeAllOfType = false)
        {
            foreach (Injury injury in Injuries)
            {
                if (type.Equals(injury.Type))
                {
                    Injuries.Remove(injury);
                    if (removeAllOfType) { continue; }
                    return Injuries;
                }
            }
            return Injuries;
        }
    }
}
