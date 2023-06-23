using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items
{
    public class Inventory
    {
        public List<ItemStack> Contents { get; } = new List<ItemStack>();

        public bool Add(ItemStack newStack) // returns true if the itemstack was added successfully
        {
            foreach (var oldStack in Contents)
            {
                if (oldStack.Item == newStack.Item)
                {
                    oldStack.Count += newStack.Count;
                    return true;
                }
            }
            Contents.Add(newStack);
            return true;
        }
        public bool Add(Item item, int count = 1)
        {
            ItemStack stack = new ItemStack(item, count);
            return Add(stack);
        }

        public bool Remove(Item item, int count = 1)
        {
            foreach (var oldStack in Contents)
            {
                if (oldStack.Item == item)
                {
                    if (count == -1 || count >= oldStack.Count)
                    {
                        Contents.Remove(oldStack);
                    }
                    else
                    {
                        oldStack.Count -= count;
                    }
                    return true;
                }
            }
            return false;
        }
        public bool Remove(ItemStack stack)
        {
            Item item = stack.Item;
            int count = stack.Count;
            return Remove(item, count);
        }
    }
}
