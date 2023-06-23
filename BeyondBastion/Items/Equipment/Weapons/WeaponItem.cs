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
            double value,
            double baseDamage,
            WeaponType type,
            double attackSpeed,
            double blockChance, 
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
                value,
                EquipmentSlot.MainHand
            )
        {
            BaseDamage = baseDamage;
            Type = type;
            AttackSpeed = attackSpeed;
            BlockChance = blockChance;
            WoundChance = woundChance;
            FractureChance = fractureChance;
            DismemberChance = dismemberChance;
            KnockdownChance = knockdownChance;
            DamageScaling = damageScaling;
        }

        public double BaseDamage { get; }
        public WeaponType Type { get; }
        public double AttackSpeed { get; }
        public double BlockChance { get; }
        public double WoundChance { get; }
        public double FractureChance { get; }
        public double DismemberChance { get; }
        public double KnockdownChance { get; }
        public double DamageScaling { get; }
    }
}
