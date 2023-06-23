using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;
using BeyondBastion.Entity.BodyParts;
using BeyondBastion.Items;
using BeyondBastion.Items.Equipment.Weapons;

namespace BeyondBastion
{
    public class World
    {
        public World()
        {
            Character cha = new Character("Horngus");
            cha.BodyParts[0].AddInjury(InjuryType.MinorWound);
            cha.BodyParts[4].AddInjury(InjuryType.Fracture);
            PlayerParty.Add(cha);

            Inventory.Add(new Shortsword());
        }
        public List<Character> PlayerParty { get; } = new List<Character>
        {
            new Character("Aspartame"),
            new Character("Trapezoid"),
            new Character("Fleep"),
        };

        public Inventory Inventory { get; } = new Inventory();
    }
}
