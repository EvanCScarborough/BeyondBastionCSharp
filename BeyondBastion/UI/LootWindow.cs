using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeyondBastion.Items;

namespace BeyondBastion.UI
{
    public partial class LootWindow : Form
    {
        public LootWindow(List<ItemStack> items)
        {
            InitializeComponent();

            LootItems = items;
        }
        public List<ItemStack> LootItems { get; }
        public List<ItemStack> TakeItems { get; }


    }
}
