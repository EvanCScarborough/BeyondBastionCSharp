using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment
{
    public abstract class WeaponItem : EquipmentItem
    {
        public WeaponItem(
            string name,
            string description,
            double weight,
            double baseDamage,
            WeaponType type,
            double attackSpeed,
            double parryChance,
            double woundChance,
            double fractureChance,
            double dismemberChance,
            double knockdownChance,
            double damageScaling
        )
            : base
            (
                name,
                description,
                weight,
                0,
                EquipmentSlot.MainHand
            )
        {
            BaseDamage = baseDamage;
            Type = type;
            AttackSpeed = attackSpeed;
            ParryChance = parryChance;
            WoundChance = woundChance;
            FractureChance = fractureChance;
            DismemberChance = dismemberChance;
            KnockdownChance = knockdownChance;
            Scaling = damageScaling;
            SetValue();
        }

        private double BaseDamage { get; }
        public WeaponType Type { get; }
        private double AttackSpeed { get; }
        private double ParryChance { get; }
        private double WoundChance { get; }
        private double FractureChance { get; }
        private double DismemberChance { get; }
        private double KnockdownChance { get; }
        public double Scaling { get; }

        public override void SetValue()
        {
            Value = (int)Math.Ceiling(120 * Quality + ((int)Tier * 60));
        }

        public double GetDamage() { return Math.Round(BaseDamage * Quality, 1); }

        public double GetAttackSpeed() { return AttackSpeed; }

        public double GetParryChance() { return Math.Round(ParryChance * Quality, 2); }

        public double GetWoundChance() { return Math.Round(WoundChance * Quality, 2);}

        public double GetFractureChance() { return Math.Round(FractureChance * Quality, 2);}

        public double GetDismemberChance() { return Math.Round(DismemberChance * Quality, 2); }

        public double GetKnockdownChance() { return Math.Round(KnockdownChance * Quality, 2);}
    }
}
