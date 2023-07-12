using BeyondBastion.Entity.BodyParts;
using BeyondBastion.Items.Equipment;
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
        Dictionary<EquipmentSlot, EquipmentItem> Equipment { get; set; }
        List<BodyPart> BodyParts { get; set; }

        int Vitality { get; }
        int Focus { get; }
        int Endurance { get; }
        int Strength { get; }
        int Knowledge { get; }
        int Charisma { get; }

        int CooldownTicks { get; set; }
        bool IsDead { get; }

        int GetMaxHealth();
        int GetBaseHealth();
        int GetMaxEnergy();
        int GetBaseEnergy();
        int GetMaxSanity();
        int GetBaseSanity();

        double GetAttackDamage();
        double GetAttackDamageMod();

        double GetAttackSpeed();
        double GetAttackSpeedMod(double baseSpeed);

        double GetParryChance();
        double GetParryChanceMod();

        double GetWoundChance();
        double GetWoundChanceMod();

        double GetFractureChance();
        double GetFractureChanceMod();

        double GetDismemberChance();
        double GetDismemberChanceMod();

        double GetKnockdownChance();
        double GetKnockdownChanceMod();

        double GetBlockChance();
        double GetBlockChanceMod();

        double GetCounterChance();
        double GetCounterChanceMod();

        double GetBodyPartMitigation(BodyPart bodyPart);

        double TakeDamage(double amount, BodyPart target, DamageSource source, IEntity entitySource = null);

        Injury Injure(BodyPart bodyPart, InjuryType type, object source);
        Injury Injure(BodyPart bodyPart, Injury injury, object source);
    }
}
