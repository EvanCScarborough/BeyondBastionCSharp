using BeyondBastion.Entity.BodyParts;
using BeyondBastion.Items.Equipment;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using BeyondBastion.Items.Equipment.Shields;
using BeyondBastion.Events;
using BeyondBastion.Items.Consumables;

namespace BeyondBastion.Entity
{
    public enum Handedness
    {
        Left, Right
    }

    public class Character : Entity
    {
        public Character(string name, World currentWorld) : base(name, currentWorld, new List<BodyPart>
        {
                new BodyPart(BodyPartType.Head),
                new BodyPart(BodyPartType.LeftArm),
                new BodyPart(BodyPartType.RightArm),
                new BodyPart(BodyPartType.Torso),
                new BodyPart(BodyPartType.LeftLeg),
                new BodyPart(BodyPartType.RightLeg),
        })
        {
            Equipment[EquipmentSlot.Head] = null;
            Equipment[EquipmentSlot.Torso] = null;
            Equipment[EquipmentSlot.Arms] = null;
            Equipment[EquipmentSlot.Legs] = null;
            Equipment[EquipmentSlot.MainHand] = null;
            Equipment[EquipmentSlot.OffHand] = null;
        }

        public double Fullness { get; set; } = 10;

        public event EventHandler<CharacterConsumeEvent> Eat;

        public override double GetAttackDamage() // returns total attack damage from weapon and stats
        {
            if (Equipment[EquipmentSlot.MainHand] == null)
            {
                return 1 + GetAttackDamageMod();
            }
            else
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                return weapon.GetDamage() + GetAttackDamageMod();
            }
        }
        public override double GetAttackDamageMod() // returns attack damage modifier from stats
        {
            if (Equipment[EquipmentSlot.MainHand] == null)
            {
                return Math.Round(Strength * 0.15, 1);
            }
            else
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    return Math.Round(Strength * weapon.Scaling, 1);
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    return Math.Round((Focus + Knowledge) / 2 * weapon.Scaling, 1);
                }
            }
        }


        public override double GetAttackSpeed() // returns total attack speed from weapon and current Energy
        {
            if (Equipment[EquipmentSlot.MainHand] == null)
            {
                return Math.Round(1.2 + GetAttackSpeedMod(1.2), 1);
            }
            else
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                return Math.Round(weapon.GetAttackSpeed() + GetAttackSpeedMod(weapon.GetAttackSpeed()), 1);
            }
        }
        public override double GetAttackSpeedMod(double baseSpeed) // returns attack speed modifier from current Energy
        {
            return Math.Round((baseSpeed * 0.5) + (baseSpeed * 0.5 * (Energy / 100)) - baseSpeed, 1);
        }

        public override double GetParryChance()
        {
            double parryChance = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                parryChance = weapon.GetParryChance() + GetParryChanceMod();
            }
            return Math.Round(parryChance, 2);
        }
        public override double GetParryChanceMod()
        {
            double parryChanceMod = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    parryChanceMod = Strength * 0.01 * weapon.Scaling;
                }
                else
                {
                    parryChanceMod = (Knowledge + Focus) / 2 * 0.01 * weapon.Scaling;
                }
            }
            return Math.Round(parryChanceMod, 2);
        }

        public override double GetWoundChance() // returns total wound chance from weapon and stats
        {
            double woundChance = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                woundChance = weapon.GetWoundChance() + GetWoundChanceMod();
            }
            return Math.Round(woundChance, 2);
        }
        public override double GetWoundChanceMod() // returns wound chance modifier from stats
        {
            double woundChanceMod = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    woundChanceMod = Strength * weapon.Scaling * 0.6 / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    woundChanceMod = (Focus + Knowledge) / 2 * weapon.Scaling * 0.6 / 100;
                }
            }
            return Math.Round(woundChanceMod, 2);
        }

        public override double GetFractureChance()
        {
            double fractureChance = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                fractureChance = weapon.GetFractureChance() + GetFractureChanceMod();
            }
            return Math.Round(fractureChance, 2);
        }
        public override double GetFractureChanceMod()
        {
            double fractureChanceMod = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    fractureChanceMod = Strength * weapon.Scaling * 0.6 / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    fractureChanceMod = (Focus + Knowledge) / 2 * weapon.Scaling * 0.6 / 100;
                }
            }
            return Math.Round(fractureChanceMod, 2);
        }

        public override double GetDismemberChance()
        {
            double dismemberChance = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                dismemberChance = weapon.GetDismemberChance() + GetDismemberChanceMod();
            }
            return Math.Round(dismemberChance, 2);
        }
        public override double GetDismemberChanceMod()
        {
            double dismemberChanceMod = 0;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    dismemberChanceMod = Strength * weapon.Scaling * 0.6 / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    dismemberChanceMod = (Focus + Knowledge) / 2 * weapon.Scaling * 0.6 / 100;
                }
            }
            return Math.Round(dismemberChanceMod, 2);
        }

        public override double GetKnockdownChance()
        {
            double knockdownChance = 0.02;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                knockdownChance += weapon.GetKnockdownChance();
            }
            return Math.Round(knockdownChance + GetKnockdownChanceMod(), 2);
        }
        public override double GetKnockdownChanceMod()
        {
            double knockdownChanceMod;
            if (Equipment[EquipmentSlot.MainHand] != null)
            {
                WeaponItem weapon = (WeaponItem)Equipment[EquipmentSlot.MainHand];
                if (weapon.Type == WeaponType.Power)
                {
                    knockdownChanceMod = Strength * weapon.Scaling * 0.6 / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    knockdownChanceMod = (Focus + Knowledge) / 2 * weapon.Scaling * 0.2 / 100;
                }
            }
            else return Math.Round(Strength * 0.2 / 100, 2);
            return Math.Round(knockdownChanceMod, 2);
        }

        public override double GetBlockChance()
        {
            double blockChance = 0.0;
            if (Equipment[EquipmentSlot.OffHand] != null)
            {
                ShieldItem shield = (ShieldItem)Equipment[EquipmentSlot.OffHand];
                blockChance += shield.GetBlockChance();
            }
            return Math.Round(blockChance + GetBlockChanceMod(), 2); ;
        }
        public override double GetBlockChanceMod()
        {
            double blockChanceMod = 0;
            if (Equipment[EquipmentSlot.OffHand] != null)
            {
                ShieldItem shield = (ShieldItem)Equipment[EquipmentSlot.OffHand];
                if (shield.Type == WeaponType.Power)
                {
                    blockChanceMod = Strength * shield.Scaling / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    blockChanceMod = (Focus + Knowledge) / 2 * shield.Scaling / 100;
                }
            }
            return Math.Round(blockChanceMod, 2);
        }

        public override double GetCounterChance()
        {
            double counterChance = 0.0;
            if (Equipment[EquipmentSlot.OffHand] != null)
            {
                ShieldItem shield = (ShieldItem)Equipment[EquipmentSlot.OffHand];
                counterChance += shield.GetCounterChance();
            }
            return Math.Round(counterChance + GetCounterChanceMod(), 2); ;
        }
        public override double GetCounterChanceMod()
        {
            double counterChanceMod = 0;
            if (Equipment[EquipmentSlot.OffHand] != null)
            {
                ShieldItem shield = (ShieldItem)Equipment[EquipmentSlot.OffHand];
                if (shield.Type == WeaponType.Power)
                {
                    counterChanceMod = Strength * shield.Scaling / 100;
                }
                else /*if (weapon.Type == WeaponType.Technique)*/
                {
                    counterChanceMod = (Focus + Knowledge) / 2 * shield.Scaling / 100;
                }
            }
            return Math.Round(counterChanceMod, 2);
        }

        public override double GetBodyPartMitigation(BodyPart bodyPart) // returns the mitigation of the armor that protects the given body part
        {
            switch (bodyPart.Type)
            {
                case BodyPartType.Head:
                    return Equipment[EquipmentSlot.Head] == null? 0 : ((ArmorItem)Equipment[EquipmentSlot.Head]).Mitigation;

                case BodyPartType.LeftArm:
                    return Equipment[EquipmentSlot.Arms] == null? 0 : ((ArmorItem)Equipment[EquipmentSlot.Arms]).Mitigation;

                case BodyPartType.RightArm:
                    return Equipment[EquipmentSlot.Arms] == null ? 0 : ((ArmorItem)Equipment[EquipmentSlot.Arms]).Mitigation;

                case BodyPartType.Torso:
                    return Equipment[EquipmentSlot.Torso] == null ? 0 : ((ArmorItem)Equipment[EquipmentSlot.Torso]).Mitigation;

                case BodyPartType.LeftLeg:
                    return Equipment[EquipmentSlot.Legs] == null ? 0 : ((ArmorItem)Equipment[EquipmentSlot.Legs]).Mitigation;

                case BodyPartType.RightLeg:
                    return Equipment[EquipmentSlot.Legs] == null ? 0 : ((ArmorItem)Equipment[EquipmentSlot.Legs]).Mitigation;

                default:
                    throw new InvalidOperationException();
            }
        }

        public override double TakeDamage(double amount, BodyPart target, DamageSource source, IEntity entitySource=null)
        {
            if (IsDead) return 0;

            double damageDealt = amount;
            if (source == DamageSource.MeleeAttack || source == DamageSource.RangedAttack) // attacks are mitigated and affected by body part damage multipliers
            {
                damageDealt -= damageDealt * GetBodyPartMitigation(target);
                damageDealt *= target.DamageMultiplier;
            }

            Health -= damageDealt;

            if (Health <= 0) { Die(new EntityDeathEvent(this, source, wasPartyMember: CurrentWorld.PlayerParty.Contains(this), killer: entitySource)); }
            return damageDealt;
        }
        public override double TakeSanityDamage(double amount, DamageSource source, IEntity entitySource=null)
        {
            if (IsDead) return 0;

            double damageDealt = amount;
            Sanity -= damageDealt;

            if (Sanity <= 0) { Die(new EntityDeathEvent(this, source, wasPartyMember: CurrentWorld.PlayerParty.Contains(this), killer: entitySource)); }
            return damageDealt;
        }
        public override double TakeEnergyDamage(double amount, DamageSource source, IEntity entitySource=null)
        {
            if (IsDead) return 0;

            double damageDealt = amount;
            Energy -= damageDealt;

            if (Energy <= 0) { Die(new EntityDeathEvent(this, source, wasPartyMember: CurrentWorld.PlayerParty.Contains(this), killer: entitySource)); }
            return damageDealt;
        }

        public void PassHour()
        {
            if (Fullness <= 0) TakeEnergyDamage(1, DamageSource.Hunger);
            else
            {
                Fullness -= 1;
                HealEnergy(1);
            }
        }

        public void Consume(FoodItem item, int amount)
        {
            if (Fullness >= 30)
            {
                Eat?.Invoke(this, new CharacterConsumeEvent(item, 0, true));
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    if (Fullness >= 30)
                    {
                        Eat?.Invoke(this, new CharacterConsumeEvent(item, i, true));
                        Fullness = 30;
                        return;
                    }
                    else
                    {
                        CurrentWorld.Inventory.Remove(item);
                        switch (item.Type)
                        {
                            case FoodType.Protein:
                                Heal(item.BonusAmnt);
                                break;
                            case FoodType.Starch:
                                HealEnergy(item.BonusAmnt);
                                break;
                            case FoodType.Comfort:
                                HealSanity(item.BonusAmnt);
                                break;
                        }
                        Fullness += item.FullnessAmnt;
                    }
                }
                Eat?.Invoke(this, new CharacterConsumeEvent(item, amount, false));
            }
        }

        public void WitnessEntityDeath(EntityDeathEvent e)
        {
            if (IsDead) return;

            if (e.WasPartyMember && CurrentWorld.PlayerParty.Contains(this))
            {
                TakeSanityDamage(16, DamageSource.WitnessDeath, e.EntityKilled);
            }
            else
            {
                TakeSanityDamage(6, DamageSource.WitnessDeath);
            }
        }
    }
}
