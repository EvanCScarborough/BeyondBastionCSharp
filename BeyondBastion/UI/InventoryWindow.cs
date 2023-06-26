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
using BeyondBastion.UI;
using BeyondBastion.Items.Equipment;
using BeyondBastion.Entity;
using System.Collections;

namespace BeyondBastion
{
    public partial class InventoryWindow : Form
    {
        public InventoryWindow(World world)
        {
            InitializeComponent();
            InventoryList.ShowItemToolTips = true;

            LabelValuePairs = new Dictionary<Label, Label>()
            {
                { Label1, Value1 },
                { Label2, Value2 },
                { Label3, Value3 },
                { Label4, Value4 },
                { Label5, Value5 },
                { Label6, Value6 },
                { Label7, Value7 },
                { Label8, Value8 },
                { Label9, Value9 },
                { Label10, Value10 },
            };

            currentWorld = world;

            UpdateDisplay();
        }

        public World currentWorld;
        public ItemStack SelectedStack;
        public Dictionary<Label, Label> LabelValuePairs;

        private void UpdateDisplay()
        {
            SelectedStack = null;
            InventoryList.BeginUpdate();
            InventoryList.Items.Clear();

            EquipButton.Enabled = false;
            ConsumeButton.Enabled = false;
            DestroyButton.Enabled = false;

            string[] listArray = new string[4];
            
            foreach (ItemStack stack in currentWorld.Inventory.Contents)
            {
                listArray[0] = stack.Item.Name;
                listArray[1] = stack.Count.ToString();
                listArray[2] = (stack.Count * stack.Item.Weight).ToString("0.0");
                listArray[3] = (stack.Count * stack.Item.Value).ToString();

                ListViewItem listItem = new ListViewItem(listArray)
                {
                    Tag = stack,
                };

                InventoryList.Items.Add(listItem);
            }
            InventoryList.EndUpdate();
            UpdateDetailsBox();
        }

        private void UpdateDetailsBox()
        {
            if (SelectedStack != null)
            {
                if (SelectedStack.Item is WeaponItem)
                {
                    WeaponItem weaponItem = (WeaponItem)SelectedStack.Item;

                    ItemNameLabel.Text = weaponItem.Name;
                    switch (weaponItem.Tier)
                    {
                        case Tier.Standard:
                            ItemNameLabel.ForeColor = Color.White;
                            break;
                        case Tier.Blessed:
                            ItemNameLabel.ForeColor = Color.Turquoise;
                            break;
                        case Tier.Hallowed:
                            ItemNameLabel.ForeColor = Color.Magenta;
                            break;
                    }
                    ItemDescriptionLabel.Text = weaponItem.Description;

                    Label1.Text = "Damage:";
                    Value1.Text = weaponItem.BaseDamage.ToString();
                    Label2.Text = "Attack Speed:";
                    Value2.Text = weaponItem.AttackSpeed.ToString();
                    Label3.Text = "Weapon Type:";
                    Value3.Text = weaponItem.Type.ToString() + $" ({weaponItem.DamageScaling * 100}%)";
                    Label4.Text = "Block:";
                    Value4.Text = (weaponItem.BlockChance * 100).ToString() + "%";
                    Label5.Text = "Wound:";
                    Value5.Text = (weaponItem.WoundChance * 100).ToString() + "%";
                    Label6.Text = "Fracture:";
                    Value6.Text = (weaponItem.FractureChance * 100).ToString() + "%";
                    Label7.Text = "Dismemberment:";
                    Value7.Text = (weaponItem.DismemberChance * 100).ToString() + "%";
                    Label8.Text = "Knockdown:";
                    Value8.Text = (weaponItem.KnockdownChance * 100).ToString() + "%";
                }
            }
            else
            {
                ItemNameLabel.Text = string.Empty;
                ItemDescriptionLabel.Text = "No item selected.";
                BlessingDescriptionLabel.Text = string.Empty;

                foreach (KeyValuePair<Label, Label> pair in LabelValuePairs)
                {
                    pair.Key.Text = string.Empty;
                    pair.Value.Text = string.Empty;
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InventoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InventoryList.SelectedItems.Count > 0)
            {
                SelectedStack = InventoryList.SelectedItems[0].Tag as ItemStack;

                EquipButton.Enabled = SelectedStack.Item.IsEquippable;
                ConsumeButton.Enabled = SelectedStack.Item.IsConsumable;
                DestroyButton.Enabled = SelectedStack.Item.IsDestructible;
            }
            else
            {
                SelectedStack = null;

                EquipButton.Enabled = false;
                ConsumeButton.Enabled = false;
                DestroyButton.Enabled = false;
            }
            UpdateDetailsBox();
        }

        private void InventoryWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void EquipButton_Click(object sender, EventArgs e)
        {
            EquipmentItem SelectedEquipmentItem = (EquipmentItem)SelectedStack.Item;

            SelectFromListDialog selectDialog = new SelectFromListDialog($"Who should equip the {SelectedStack.Item.Name}?", currentWorld.PlayerParty.ToArray());
            DialogResult result = selectDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Character selectedCharacter = (Character)selectDialog.ReturnObject;
                if (selectedCharacter.Equipment[SelectedEquipmentItem.Slot] != null)
                {
                    YesNoDialog yesNo = new YesNoDialog($"{selectedCharacter.Name} already has {selectedCharacter.Equipment[SelectedEquipmentItem.Slot].Name} equipped in their {SelectedEquipmentItem.Slot}. Swap it out for {SelectedEquipmentItem.Name}?");
                    result = yesNo.ShowDialog();
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        currentWorld.Inventory.Add(selectedCharacter.Equipment[SelectedEquipmentItem.Slot]);
                        currentWorld.Inventory.Remove(SelectedStack);
                        selectedCharacter.Equipment[SelectedEquipmentItem.Slot] = SelectedEquipmentItem;
                        UpdateDisplay();
                        MessageDialog msg = new MessageDialog($"{selectedCharacter.Name} has equipped {SelectedEquipmentItem}.");
                        msg.ShowDialog();
                    }
                }
                else
                {
                    selectedCharacter.Equipment[SelectedEquipmentItem.Slot] = SelectedEquipmentItem;
                    currentWorld.Inventory.Remove(SelectedStack);
                    UpdateDisplay();
                    MessageDialog msg = new MessageDialog($"{selectedCharacter.Name} has equipped {SelectedEquipmentItem}.");
                    msg.ShowDialog();
                }
            }
        }
    }
}
