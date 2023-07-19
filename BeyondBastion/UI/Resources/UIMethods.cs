using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeyondBastion.Items;
using BeyondBastion.Items.Equipment;

namespace BeyondBastion.UI
{
    public static class UIMethods
    {
        public static void WriteInventoryToListView(List<ItemStack> inventory, ListView list)
        {
            string[] listArray = new string[4];

            foreach (ItemStack stack in inventory)
            {
                listArray[0] = stack.Item.Name;
                if (stack.Item is EquipmentItem equipmentItem)
                {
                    listArray[0] += $" ({QualityLevel.GetTier(equipmentItem.Quality)})";
                }
                listArray[1] = stack.Count.ToString();
                listArray[2] = (stack.Count * stack.Item.Weight).ToString("0.0");
                listArray[3] = (stack.Count * stack.Item.Value).ToString();
                ListViewItem listItem = new ListViewItem(listArray)
                {
                    Tag = stack,
                };

                list.Items.Add(listItem);
            }
        }
    }
}
