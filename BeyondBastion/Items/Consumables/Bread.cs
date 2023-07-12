using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Consumables
{
    public class Bread : FoodItem
    {
        public Bread() : base("Bread", "A roll of crusty bread. Staple food of the peasantry.", 0.2, 10, FoodType.Starch, 4, 7)
        {

        }
    }
}
