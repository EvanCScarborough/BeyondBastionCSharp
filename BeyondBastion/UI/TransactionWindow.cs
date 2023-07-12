using BeyondBastion.Items;
using BeyondBastion.Items.Equipment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeyondBastion.UI
{
    public partial class TransactionWindow : Form
    {
        public TransactionWindow(string windowTitle, List<ItemStack> sellerInventory, string sellerName, List<ItemStack> buyerInventory, string buyerName, bool costsMoney=false, double sellerValueFactor=0, double buyerValueFactor=0)
        {
            InitializeComponent();

            TitleBox.Text = windowTitle;
            TitleBox.Font = StyleRules.Heading1;

            SellerBox.Text = sellerName;
            BuyerBox.Text = buyerName;

            GirnLabel.Visible = costsMoney;

            InspectButton.Enabled = false;
            SwapButton.Enabled = false;

            OriginalSellerInventory = sellerInventory;
            OriginalBuyerInventory = buyerInventory;
            ProposedSellerInventory = sellerInventory;
            ProposedBuyerInventory = buyerInventory;

            UpdateInventoryBoxes();
        }

        public List<ItemStack> OriginalSellerInventory { get; }
        public List<ItemStack> ProposedSellerInventory { get; }

        public List<ItemStack> OriginalBuyerInventory { get; }
        public List<ItemStack> ProposedBuyerInventory { get; }

        private ItemStack SelectedStack { get; set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuyerInventoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BuyerInventoryBox.SelectedItems.Clear();
            if (BuyerInventoryBox.SelectedItems.Count > 0)
            {
                SelectedStack = BuyerInventoryBox.SelectedItems[0].Tag as ItemStack;

                InspectButton.Enabled = true;
                SwapButton.Enabled = true;
            }
            else
            {
                SelectedStack = null;

                InspectButton.Enabled = false;
                SwapButton.Enabled = false;
            }
        }

        private void SellerInventoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BuyerInventoryBox.SelectedItems.Clear();
            if (SellerInventoryBox.SelectedItems.Count > 0)
            {
                SelectedStack = SellerInventoryBox.SelectedItems[0].Tag as ItemStack;

                InspectButton.Enabled = true;
                SwapButton.Enabled = true;
            }
            else
            {
                SelectedStack = null;

                InspectButton.Enabled = false;
                SwapButton.Enabled = false;
            }
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            if (SelectedStack != null)
            {
                if (ProposedSellerInventory.Contains(SelectedStack))
                {
                    ProposedBuyerInventory.Add(SelectedStack);
                    ProposedSellerInventory.Remove(SelectedStack);

                    UpdateInventoryBoxes();
                }
                else if (ProposedBuyerInventory.Contains(SelectedStack))
                {
                    ProposedSellerInventory.Add(SelectedStack);
                    ProposedBuyerInventory.Remove(SelectedStack);

                    UpdateInventoryBoxes();
                }
            }
        }

        private void UpdateInventoryBoxes()
        {
            SellerInventoryBox.Items.Clear();
            BuyerInventoryBox.Items.Clear();
            UIMethods.WriteInventoryToListView(ProposedSellerInventory, SellerInventoryBox);
            UIMethods.WriteInventoryToListView(ProposedBuyerInventory, BuyerInventoryBox);
        }

        private void InspectButton_Click(object sender, EventArgs e)
        {
            InspectItemWindow inspectWindow = new InspectItemWindow(SelectedStack.Item);
            inspectWindow.ShowDialog();
        }
    }
}
