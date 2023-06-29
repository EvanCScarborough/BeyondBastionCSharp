using BeyondBastion.Items.Consumables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondBastion.Entity;

namespace BeyondBastion.Events
{
    public class CharacterConsumeEvent
    {
        public CharacterConsumeEvent(FoodItem foodEaten, int numEaten, bool stoppedDueToFullness)
        {
            FoodEaten = foodEaten;
            NumEaten = numEaten;
            StoppedDueToFullness = stoppedDueToFullness;
        }
        public Character Character;
        public FoodItem FoodEaten;
        public int NumEaten;
        public bool StoppedDueToFullness;
    }
}
