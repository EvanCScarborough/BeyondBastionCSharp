using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity.BodyParts;
using BeyondBastion.Events;
using BeyondBastion.Items;
using BeyondBastion.Items.Consumables;
using BeyondBastion.Items.Equipment;

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
            Handedness = (random.NextDouble() < 0.12) ? Handedness.Left : Handedness.Right;

            Health = GetMaxHealth();
            Energy = GetMaxEnergy();
            Sanity = GetMaxSanity();
        }
        public Dictionary<EquipmentSlot, EquipmentItem> Equipment { get; set; } = new Dictionary<EquipmentSlot, EquipmentItem> { };

        public string Name { get; }
        public World CurrentWorld { get; }

        public List<BodyPart> BodyParts { get; set; }
        public Handedness Handedness { get; }

        public double Health { get; set; }
        public double Energy { get; set; }
        public double Sanity { get; set;}

        public int Vitality { get; }
        public int Focus { get; }
        public int Endurance { get; }
        public int Strength { get; }
        public int Knowledge { get; }
        public int Charisma { get; }

        public int CooldownTicks { get; set; }
        public bool IsDead { get; set; } = false;

        public event EventHandler<EntityDeathEvent> DeathEvent;
        public event EventHandler<EntityDisarmEvent> DisarmEvent;

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

        public abstract double TakeDamage(double amount, BodyPart target, DamageSource source, IEntity attacker = null);
        public double Heal(double amount)
        {
            if (IsDead) return 0;

            if (Health + amount > GetMaxHealth())
            {
                amount -= Health + amount - GetMaxHealth();
            }
            Health += amount;

            return amount;
        }

        public abstract double TakeSanityDamage(double amount, DamageSource source, IEntity attacker = null);
        public double HealSanity(double amount)
        {
            if (IsDead) return 0;

            if (Sanity + amount > GetMaxSanity())
            {
                amount -= Sanity + amount - GetMaxSanity();
            }
            Sanity += amount;

            return amount;
        }

        public abstract double TakeEnergyDamage(double amount, DamageSource source, IEntity attacker = null);
        public double HealEnergy(double amount)
        {
            if (IsDead) return 0;

            if (Energy + amount > GetMaxEnergy())
            {
                amount -= Energy + amount - GetMaxEnergy();
            }
            Energy += amount;

            return amount;
        }

        public Injury Injure(BodyPart bodyPart, Injury injury, object source = null)
        {
            if ((injury.Type == InjuryType.Fracture || injury.Type == InjuryType.Dismemberment))
            {
                if ((bodyPart.Type == BodyPartType.RightArm && Handedness == Handedness.Right) || 
                    (bodyPart.Type == BodyPartType.LeftArm && Handedness == Handedness.Left))
                {
                    if (Equipment[EquipmentSlot.MainHand] != null)
                    {
                        EquipmentItem heldEquipmentItem = Equipment[EquipmentSlot.MainHand];
                        Equipment[EquipmentSlot.MainHand] = null;
                        if (CurrentWorld.PlayerParty.Contains(this) && !CurrentWorld.InCombat)
                        {
                            CurrentWorld.Inventory.Add(heldEquipmentItem);
                            DisarmEvent?.Invoke(this, new EntityDisarmEvent(this, heldEquipmentItem, true));
                        }
                        else if (CurrentWorld.InCombat)
                        {
                            CurrentWorld.Combat.LootList.Add(new ItemStack(heldEquipmentItem, 1));
                            DisarmEvent?.Invoke(this, new EntityDisarmEvent(this, heldEquipmentItem, false));
                        }
                    }
                }
                else if (injury.Type == InjuryType.Dismemberment && bodyPart.Type == BodyPartType.Head)
                {
                    if (source is Entity)
                    {
                        Die(new EntityDeathEvent(this, DamageSource.Beheading, CurrentWorld.PlayerParty.Contains(this), (IEntity)source));
                    }
                    else
                    {
                        Die(new EntityDeathEvent(this, DamageSource.Beheading, CurrentWorld.PlayerParty.Contains(this)));
                    }
                    return injury;
                }
            }

            Injury inj = bodyPart.AddInjury(injury);
            GetMaxHealth();
            return inj;
        }

        public Injury Injure(BodyPart bodyPart, InjuryType type, object source = null) // Overload method
        {
            Injury injury = new Injury(type);
            return Injure(bodyPart, injury, source);
        } 

        public void Die(EntityDeathEvent e)
        {
            IsDead = true;
            DeathEvent?.Invoke(this, e);
        }
    }
}
