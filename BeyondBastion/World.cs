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

namespace BeyondBastion
{
    public class World
    {
        public World()
        {
            Inventory.Add(new Shortsword());
            Inventory.Add(new Bread());

            log = new Log(this);
            EntitiesList = new List<IEntity>();

            PlayerParty.Add((Character)CreateEntity("Aspartame"));
            PlayerParty.Add((Character)CreateEntity("Horngus"));
            PlayerParty.Add((Character)CreateEntity("Trapezoid"));
            PlayerParty.Add((Character)CreateEntity("Fleep"));

            Hour = 12;
            Day = 1;
        }
        public List<Character> PlayerParty { get; } = new List<Character>();
        public List<IEntity> EntitiesList { get; }
        public Log log;
        public Inventory Inventory { get; } = new Inventory();
        public int Girn { get; set; } = 0;
        public int Hour { get; set; }
        public int Day { get; set; }

        public IEntity CreateEntity(string name)
        {
            Character character = new Character(name, this);
            EntitiesList.Add(character);
            character.Death += log.OnDeathEvent;
            character.Death += OnEntityDeath;
            return character;
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
            foreach (var entity in EntitiesList)
            {
                if (entity != e.EntityKilled) ((Character)entity).WitnessEntityDeath(e);
            }

            if (e.Killer != null)
            {
                ((Character)e.Killer).TakeSanityDamage(6, DamageSource.CommitMurder);
            }

            if (PlayerParty.Contains(e.EntityKilled)) PlayerParty.Remove((Character)e.EntityKilled);
            if (PlayerParty.Count == 0)
            {
                MessageDialog msg = new MessageDialog("Your party has been destroyed.\n\nNot all souls are destined for salvation.");
                msg.ShowDialog();
            }
        }
    }
}
