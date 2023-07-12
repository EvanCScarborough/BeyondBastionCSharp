using System.Collections.Generic;
using System.Linq;
using BeyondBastion.Entity;
using BeyondBastion.Events;
using BeyondBastion.Items;
using BeyondBastion.Items.Equipment.Weapons;
using BeyondBastion.Items.Equipment.Shields;
using BeyondBastion.UI;
using BeyondBastion.Items.Consumables;
using System;
using System.Security.AccessControl;
using BeyondBastion.Events.Combat;

namespace BeyondBastion
{
    public class World
    {
        public World()
        {
            Inventory.Add(new Shortsword());
            Inventory.Add(new Shortsword());
            Inventory.Add(new Shortsword());
            Inventory.Add(new Shortsword());
            Inventory.Add(new Shortsword());
            Inventory.Add(new Shortsword());
            Inventory.Add(new Shortsword());
            Inventory.Add(new Shortsword());
            Inventory.Add(new ItemStack(new Bread(), 12));
            Inventory.Add(new Buckler());

            Combat = new CombatHandler(this);
            Log = new Log(this);

            Combat.OnCombatRoundStart += Log.OnCombatRoundStart;
            Combat.OnCombatAction += Log.OnCombatAction;
            Combat.OnCounterAttack += Log.OnCounterAttack;
            Combat.OnCombatEnd += Log.OnCombatEnd;
            Combat.OnCombatEnd += EndCombat;

            NearbyEntities = new List<IEntity>();
            Enemies = new List<IEntity>();

            PlayerParty.Add((Character)CreateEntity("Aspartame"));
            PlayerParty.Add((Character)CreateEntity("Horngus"));
            PlayerParty.Add((Character)CreateEntity("Trapezoid"));
            PlayerParty.Add((Character)CreateEntity("Fleep"));

            Enemies.Add(CreateEntity("Gertie"));
            Enemies.Add(CreateEntity("Sergio"));
            Enemies.Add(CreateEntity("Squaf"));

            Enemies[0].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();
            Enemies[1].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();
            Enemies[2].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();

            Enemies[0].Equipment[Items.Equipment.EquipmentSlot.OffHand] = new Buckler();
            Enemies[1].Equipment[Items.Equipment.EquipmentSlot.OffHand] = new Buckler();
            Enemies[2].Equipment[Items.Equipment.EquipmentSlot.OffHand] = new Buckler();

            PlayerParty[0].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();
            PlayerParty[1].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();
            PlayerParty[2].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();
            PlayerParty[3].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();

            PlayerParty[0].Equipment[Items.Equipment.EquipmentSlot.OffHand] = new Buckler();
            PlayerParty[1].Equipment[Items.Equipment.EquipmentSlot.OffHand] = new Buckler();
            PlayerParty[2].Equipment[Items.Equipment.EquipmentSlot.OffHand] = new Buckler();
            PlayerParty[3].Equipment[Items.Equipment.EquipmentSlot.OffHand] = new Buckler();

            CreateEntity("Flarp");

            Hour = 12;
            Day = 1;
        }

        public List<Character> PlayerParty { get; } = new List<Character>();
        public List<IEntity> NearbyEntities { get; }
        public List<IEntity> Enemies { get; }

        public Log Log;

        public Inventory Inventory { get; } = new Inventory();
        public int Girn { get; set; } = 0;
        public int Hour { get; set; }
        public int Day { get; set; }

        public CombatHandler Combat { get; }
        public bool InCombat { get; set; } = false;

        public IEntity CreateEntity(string name)
        {
            Character character = new Character(name, this);
            NearbyEntities.Add(character);

            character.DeathEvent += Log.OnDeathEvent;
            character.DeathEvent += OnEntityDeath;
            character.DeathEvent += Combat.OnEntityDeath;

            character.DisarmEvent += Log.OnDisarmEvent;
            character.DisarmEvent += Combat.OnDisarmEvent;

            character.Eat += Log.OnCharacterConsumeEvent;

            return character;
        }

        public List<IEntity> GetNPCs()
        {
            List<IEntity> npcs = new List<IEntity>();
            foreach (IEntity entity in NearbyEntities)
            {
                if (PlayerParty.Contains(entity)) { continue; }
                npcs.Add(entity);
            }
            return npcs;
        }

        public void BeginCombat(List<IEntity> enemies) // begins combat with the given list of enemies
        {
            InCombat = true;
            foreach (IEntity entity in enemies)
            {
                if (!Enemies.Contains(entity)) Enemies.Add(entity);
            }
            Combat.Commence();
        }

        public void EndCombat(object sender, CombatEndEvent e)
        {
            if (e.Result == CombatEndEvent.CombatEndResult.Victory && e.LootList != null)
            {
                TransactionWindow transWindow = new TransactionWindow("Loot", e.LootList, "Corpses", Inventory.Contents, "Party Inventory");
                transWindow.ShowDialog();
            }
            InCombat = false;
        }

        public void PassTime(int hours)
        {
            bool shouldBreak = false;
            for (int i = 0; i < hours; i++)
            {
                foreach (Character character in PlayerParty.ToList())
                {
                    if (!character.IsDead)
                    {
                        character.PassHour();
                        if (character.IsDead) shouldBreak = true;
                    }
                }

                BeginCombat(Enemies);

                // LAST: update time
                Hour++;
                if (Hour > 24)
                {
                    Day++;
                    Hour = 1;
                }
                if (shouldBreak) break;
            }
        }

        private void OnEntityDeath(object sender, EntityDeathEvent e)
        {
            foreach (var entity in NearbyEntities.ToList())
            {
                if (entity != e.EntityKilled && entity is Character character) character.WitnessEntityDeath(e);
            }

            if (e.Killer != null)
            {
                ((Character)e.Killer).TakeSanityDamage(6, DamageSource.CommitMurder);
            }

            if (PlayerParty.Contains(e.EntityKilled)) PlayerParty.Remove((Character)e.EntityKilled);
            NearbyEntities.Remove(e.EntityKilled);
            if (Enemies.Contains(e.EntityKilled)) Enemies.Remove(e.EntityKilled);

            if (PlayerParty.Count == 0)
            {
                MessageDialog msg = new MessageDialog("Your party has been destroyed.\n\nNot all souls are destined for salvation.");
                msg.ShowDialog();
            }
        }
    }
}
