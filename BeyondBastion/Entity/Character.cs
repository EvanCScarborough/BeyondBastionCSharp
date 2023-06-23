using BeyondBastion.Entity.BodyParts;
using BeyondBastion.Items.Equipment;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Entity
{
    public enum Handedness
    {
        Left, Right
    }

    public class Character : IEntity
    {
        private static Random random = new Random();
        private static int GetRandomStatValue()
        {
            return (int)Math.Round(((random.NextDouble() * 50) + (random.NextDouble() * 50)) / 2);
        }

        public Character(string name)
        {
            Name = name;
            Vitality = GetRandomStatValue();
            Focus = GetRandomStatValue();
            Endurance = GetRandomStatValue();
            Strength = GetRandomStatValue();
            Knowledge = GetRandomStatValue();
            Charisma = GetRandomStatValue();

            BodyParts = new List<BodyPart>
            {
                new BodyPart(this, BodyPartType.Head),
                new BodyPart(this, BodyPartType.LeftArm),
                new BodyPart(this, BodyPartType.RightArm),
                new BodyPart(this, BodyPartType.Torso),
                new BodyPart(this, BodyPartType.LeftLeg),
                new BodyPart(this, BodyPartType.RightLeg),
            };

            Handedness = (random.NextDouble() >= 0.12) ? Handedness.Right : Handedness.Left;

            Health = GetMaxHealth();
            Energy = GetMaxEnergy();
            Sanity = GetMaxSanity();

            Equipment[EquipmentSlot.Head] = null;
            Equipment[EquipmentSlot.Torso] = null;
            Equipment[EquipmentSlot.Arms] = null;
            Equipment[EquipmentSlot.Legs] = null;
            Equipment[EquipmentSlot.MainHand] = null;
            Equipment[EquipmentSlot.OffHand] = null;
        }

        public List<BodyPart> BodyParts { get; }

        public string Name { get; }

        public int Vitality { get; }
        public int Focus { get; }
        public int Endurance { get; }
        public int Strength { get; }
        public int Knowledge { get; }
        public int Charisma { get; }

        public Handedness Handedness { get; }

        public double Health { get; set; }
        public double Energy { get; set; }
        public double Sanity { get; set; }

        public Dictionary<EquipmentSlot, EquipmentItem> Equipment { get; set; } = new Dictionary<EquipmentSlot, EquipmentItem> { };

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
                foreach (Injury inj in part.Injuries)
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

        public double GetAttackDamage() // returns total attack damage from weapon and stats
        {
            if (Equipment[EquipmentSlot.MainHand] == null)
            {
                return 1 + GetAttackDamageMod();
            }
            else
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                return weapon.BaseDamage + GetAttackDamageMod();
            }
        }
        public double GetAttackDamageMod() // returns attack damage modifier from stats
        {
            if (Equipment[EquipmentSlot.MainHand] == null)
            {
                return Strength * 0.15;
            }
            else
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    return Strength * weapon.DamageScaling;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    return (Focus + Knowledge) / 2 * weapon.DamageScaling;
                }
            }
        }


        public double GetAttackSpeed() // returns total attack speed from weapon and current Energy
        {
            if (Equipment[EquipmentSlot.MainHand] == null)
            {
                return 2 + GetAttackSpeedMod(2);
            }
            else
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                return weapon.AttackSpeed + GetAttackSpeedMod(weapon.AttackSpeed);
            }
        }
        public double GetAttackSpeedMod(double baseSpeed) // returns attack speed modifier from current Energy
        {
            return (baseSpeed * 0.5) + (baseSpeed * 0.5 * (Energy / 100)) - baseSpeed;
        }

        public double GetBlockChance()
        {
            double blockChance = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                blockChance = weapon.BlockChance;
            }
            if (Equipment[EquipmentSlot.OffHand] != null)
            {
                ShieldItem shield = (ShieldItem)Equipment[EquipmentSlot.OffHand];
                blockChance += shield.BlockChance;
            }
            return blockChance;
        }

        public double GetWoundChance() // returns total wound chance from weapon and stats
        {
            double woundChance = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                woundChance = weapon.WoundChance + GetWoundChanceMod();
            }
            return woundChance;
        }
        public double GetWoundChanceMod() // returns wound chance modifier from stats
        {
            double woundChanceMod = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    woundChanceMod = Strength * weapon.DamageScaling * 0.6 / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    woundChanceMod = (Focus + Knowledge) / 2 * weapon.DamageScaling * 0.6 / 100;
                }
            }
            return woundChanceMod;
        }

        public double GetFractureChance()
        {
            double fractureChance = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                fractureChance = weapon.FractureChance + GetFractureChanceMod();
            }
            return fractureChance;
        }
        public double GetFractureChanceMod()
        {
            double fractureChanceMod = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    fractureChanceMod = Strength * weapon.DamageScaling * 0.6 / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    fractureChanceMod = (Focus + Knowledge) / 2 * weapon.DamageScaling * 0.6 / 100;
                }
            }
            return fractureChanceMod;
        }

        public double GetDismemberChance()
        {
            double dismemberChance = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                dismemberChance = weapon.DismemberChance + GetDismemberChanceMod();
            }
            return dismemberChance;
        }
        public double GetDismemberChanceMod()
        {
            double dismemberChanceMod = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    dismemberChanceMod = Strength * weapon.DamageScaling * 0.6 / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    dismemberChanceMod = (Focus + Knowledge) / 2 * weapon.DamageScaling * 0.6 / 100;
                }
            }
            return dismemberChanceMod;
        }

        public double GetKnockdownChance()
        {
            double knockdownChance = 0.02;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                knockdownChance += weapon.KnockdownChance;
            }
            return knockdownChance + GetKnockdownChanceMod();
        }
        public double GetKnockdownChanceMod()
        {
            double knockdownChanceMod;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    knockdownChanceMod = Strength * weapon.DamageScaling * 0.6 / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    knockdownChanceMod = Math.Round((Focus + Knowledge) / 2 * weapon.DamageScaling * 0.2 / 100, 3);
                }
            }
            else return Math.Round(Strength * 0.2 / 100, 3);
            return knockdownChanceMod;
        }

        public void TakeDamage(double amount, BodyPart target)
        {

        }
    }
}
