using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;
using BeyondBastion.Entity.BodyParts;
using BeyondBastion.Events;
using BeyondBastion.Items;
using BeyondBastion.Items.Equipment.Weapons;
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
            Inventory.Add(new ItemStack(new Bread(), 12));

            log = new Log(this);
            Combat.OnCombatRoundStart += log.OnCombatRoundStart;
            Combat.OnCombatAction += log.OnCombatAction;
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

            PlayerParty[0].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();
            PlayerParty[1].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();
            PlayerParty[2].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();
            PlayerParty[3].Equipment[Items.Equipment.EquipmentSlot.MainHand] = new Shortsword();


            CreateEntity("Flarp");

            Hour = 12;
            Day = 1;
        }

        public List<Character> PlayerParty { get; } = new List<Character>();
        public List<IEntity> NearbyEntities { get; }
        public List<IEntity> Enemies { get; }

        public Log log;

        public Inventory Inventory { get; } = new Inventory();
        public int Girn { get; set; } = 0;
        public int Hour { get; set; }
        public int Day { get; set; }

        public CombatHandler Combat { get; set; } = new CombatHandler();
        public bool InCombat { get; set; } = false;

        public IEntity CreateEntity(string name)
        {
            Character character = new Character(name, this);
            NearbyEntities.Add(character);

            character.DeathEvent += log.OnDeathEvent;
            character.DeathEvent += Combat.OnEntityDeath;
            character.DeathEvent += OnEntityDeath;

            character.DisarmEvent += log.OnDisarmEvent;

            character.Eat += log.OnCharacterConsumeEvent;

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
            Combat.Commence(this);
        }

        public void EndCombat(object sender, CombatEndEvent e)
        {
            foreach (IEntity enemy in e.EnemiesKilled)
            {
                // TODO: allow looting of dead enemies
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
