using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity.BodyParts;
using BeyondBastion.Events;

namespace BeyondBastion.Entity
{
    public abstract class Entity : IEntity
    {
        protected static Random random = new Random();
        protected static int GetRandomStatValue()
        {
            return (int)Math.Round(((random.NextDouble() * 50) + (random.NextDouble() * 50)) / 2);
        }

        protected Entity(string name, World currentWorld, List<BodyPart> bodyParts)
        {
            Name = name;
            CurrentWorld = currentWorld;

            Vitality = GetRandomStatValue();
            Focus = GetRandomStatValue();
            Endurance = GetRandomStatValue();
            Strength = GetRandomStatValue();
            Knowledge = GetRandomStatValue();
            Charisma = GetRandomStatValue();

            BodyParts = bodyParts;

            Health = GetMaxHealth();
            Energy = GetMaxEnergy();
            Sanity = GetMaxSanity();
        }

        public string Name { get; }
        public World CurrentWorld { get; }

        public List<BodyPart> BodyParts { get; set; }

        public double Health { get; set; }
        public double Energy { get; set; }
        public double Sanity { get; set;}

        public int Vitality { get; }
        public int Focus { get; }
        public int Endurance { get; }
        public int Strength { get; }
        public int Knowledge { get; }
        public int Charisma { get; }

        public event EventHandler<EntityDeathEvent> Death;

        public int GetBaseHealth()
        {
            return 50 + Vitality * 2;
        }
        public int GetMaxHealth()
        {
            int maxMax = GetBaseHealth();
            int actualMax = maxMax;
            foreach (BodyPart part in BodyParts)
            {
                foreach (Injury inj in part.GetInjuries())
                {
                    actualMax -= (int)Math.Ceiling(maxMax * part.GetPenaltyFromInjuries());
                }
            }

            if (Health > actualMax) { Health = actualMax; }
            return actualMax;
        }

        public int GetBaseEnergy()
        {
            return 50 + Endurance * 2;
        }
        public int GetMaxEnergy()
        {
            int maxMax = GetBaseEnergy();
            int actualMax = maxMax;

            if (Energy > actualMax) { Energy = actualMax; }
            return actualMax;
        }

        public int GetBaseSanity()
        {
            return 50 + Focus * 2;
        }
        public int GetMaxSanity()
        {
            int maxMax = GetBaseSanity();
            int actualMax = maxMax;

            if (Sanity > actualMax) { Sanity = actualMax; }
            return actualMax;
        }
        public void UpdateStats()
        {
            GetMaxHealth();
            GetMaxEnergy();
            GetMaxSanity();
        }

        public abstract double GetAttackDamage();
        public abstract double GetAttackDamageMod();

        public abstract double GetAttackSpeed();
        public abstract double GetAttackSpeedMod(double baseSpeed);

        public abstract double GetBlockChance();

        public abstract double GetWoundChance();
        public abstract double GetWoundChanceMod();

        public abstract double GetFractureChance();
        public abstract double GetFractureChanceMod();

        public abstract double GetDismemberChance();
        public abstract double GetDismemberChanceMod();

        public abstract double GetKnockdownChance();
        public abstract double GetKnockdownChanceMod();

        public abstract double GetBodyPartMitigation(BodyPart bodyPart);

        public abstract double TakeDamage(double amount, BodyPart target, DamageSource source);
        public abstract double TakeSanityDamage(double amount, SanityDamageSource source);
        public abstract double TakeEnergyDamage(double amount, EnergyDamageSource source);

        public void Injure(BodyPart bodyPart, InjuryType type)
        {
            bodyPart.AddInjury(type);
            GetMaxHealth();
        }

        public void Die()
        {
            Death?.Invoke(this, new EntityDeathEvent(this));
        }
    }
}
