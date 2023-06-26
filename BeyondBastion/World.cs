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

namespace BeyondBastion
{
    public class World
    {
        public World()
        {
            Inventory.Add(new Shortsword());

            log = new Log(this);
            EntitiesList = new List<IEntity>();

            PlayerParty.Add((Character)CreateEntity("Aspartame"));
            PlayerParty.Add((Character)CreateEntity("Horngus"));
            PlayerParty.Add((Character)CreateEntity("Trapezoid"));
            PlayerParty.Add((Character)CreateEntity("Fleep"));
        }
        public List<Character> PlayerParty { get; } = new List<Character>();
        public List<IEntity> EntitiesList { get; }
        public Log log;
        public Inventory Inventory { get; } = new Inventory();

        public IEntity CreateEntity(string name)
        {
            Character character = new Character(name, this);
            EntitiesList.Add(character);
            character.Death += BroadcastEntityDeath;
            return character;
        }

        public void PassTime()
        {

        }

        private void BroadcastEntityDeath(object sender, EntityDeathEvent e)
        {
            foreach (var entity in EntitiesList)
            {
                ((Character)entity).WitnessEntityDeath(e);
            }

            if (e.Killer != null)
            {
                ((Character)e.Killer).TakeSanityDamage(6, SanityDamageSource.Murder);
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
