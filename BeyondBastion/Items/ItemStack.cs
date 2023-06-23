using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items
{
    public class ItemStack
    {
        public ItemStack(Item item, int count)
        {
            Item = item;
            Count = count;
        }

        public Item Item;
        public int Count;

        public double GetValue()
        {
            return Count * Item.Value;
        }
    }
}
