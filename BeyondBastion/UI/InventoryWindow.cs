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
using BeyondBastion.Items.Consumables;
using System.Collections;
using BeyondBastion.Items.Equipment.Shields;

namespace BeyondBastion
{
    public partial class InventoryWindow : Form, IBeyondBastionUi
    {
        public InventoryWindow(World world, IBeyondBastionUi parentWindow)
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
            ParentWindow = parentWindow;

            UpdateDisplay();
        }

        public World currentWorld;
        public ItemStack SelectedStack;
        public Dictionary<Label, Label> LabelValuePairs;
        public IBeyondBastionUi ParentWindow;

        public void UpdateDisplay()
        {
            SelectedStack = null;
            InventoryList.BeginUpdate();
            InventoryList.Items.Clear();

            EquipButton.Enabled = false;
            ConsumeButton.Enabled = false;
            DestroyButton.Enabled = false;

            UIMethods.WriteInventoryToListView(currentWorld.Inventory.Contents, InventoryList);

            InventoryList.EndUpdate();
            UpdateDetailsBox();
            ParentWindow.UpdateDisplay();
        }

        private void UpdateDetailsBox()
        {
            ItemNameLabel.Text = string.Empty;
            ItemDescriptionLabel.Text = "No item selected.";
            BlessingDescriptionLabel.Text = string.Empty;

            foreach (KeyValuePair<Label, Label> pair in LabelValuePairs)
            {
                pair.Key.Text = string.Empty;
                pair.Value.Text = string.Empty;
            }

            if (SelectedStack != null)
            {
                ItemNameLabel.Text = SelectedStack.Item.Name;
                ItemQualityLabel.Text = string.Empty;
                ItemNameLabel.ForeColor = Color.White;
                ItemDescriptionLabel.Text = SelectedStack.Item.Description;

                if (SelectedStack.Item is EquipmentItem equipmentItem)
                {
                    switch (equipmentItem.Tier)
                    {
                        case Tier.Blessed:
                            ItemNameLabel.ForeColor = Color.Turquoise;
                            break;
                        case Tier.Hallowed:
                            ItemNameLabel.ForeColor = Color.Magenta;
                            break;
                    }

                    ItemQualityLabel.Text = QualityLevel.GetTier(equipmentItem.Quality);
                    ItemQualityLabel.ForeColor = QualityLevel.GetColor(equipmentItem.Quality);

                    if (SelectedStack.Item is WeaponItem weaponItem)
                    {
                        Label1.Text = "Damage:";
                        Value1.Text = weaponItem.GetDamage().ToString();
                        Label2.Text = "Attack Speed:";
                        Value2.Text = weaponItem.GetAttackSpeed().ToString();
                        Label3.Text = "Weapon Type:";
                        Value3.Text = weaponItem.Type.ToString() + $" ({weaponItem.Scaling * 100}%)";
                        Label4.Text = "Wound:";
                        Value4.Text = (weaponItem.GetWoundChance() * 100).ToString() + "%";
                        Label5.Text = "Fracture:";
                        Value5.Text = (weaponItem.GetFractureChance() * 100).ToString() + "%";
                        Label6.Text = "Dismemberment:";
                        Value6.Text = (weaponItem.GetDismemberChance() * 100).ToString() + "%";
                        Label7.Text = "Knockdown:";
                        Value7.Text = (weaponItem.GetKnockdownChance() * 100).ToString() + "%";
                        Label8.Text = "Parry:";
                        Value8.Text = (weaponItem.GetParryChance() * 100).ToString() + "%";
                    }
                    else if (SelectedStack.Item is ShieldItem shieldItem)
                    {
                        Label1.Text = "Block:";
                        Value1.Text = (shieldItem.GetBlockChance() * 100).ToString() + "%";
                        Label2.Text = "Counter:";
                        Value2.Text = (shieldItem.GetCounterChance() * 100).ToString() + "%";
                        Label3.Text = "Shield Type:";
                        Value3.Text = shieldItem.Type.ToString() + $" ({shieldItem.Scaling * 100}%)";
                    }
                }
                else
                {
                    ItemDescriptionLabel.Text = SelectedStack.Item.Description;
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
                    YesNoDialog yesNo = new YesNoDialog($"{selectedCharacter.Name} already has {selectedCharacter.Equipment[SelectedEquipmentItem.Slot].Name} equipped in their {SelectedEquipmentItem.Slot}. Replace it with {SelectedEquipmentItem.Name}?");
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

        private void ConsumeButton_Click(object sender, EventArgs e)
        {
            FoodItem SelectedFoodItem = (FoodItem)SelectedStack.Item;

            SelectFromListWithAmountDialog selectDialog = new SelectFromListWithAmountDialog($"Who should eat {SelectedStack.Item.Name}?", currentWorld.PlayerParty.ToArray(), SelectedStack.Count, this);
            DialogResult result = selectDialog.ShowDialog();

            if (result == DialogResult.Cancel) { return; }
            else
            {
                Character selectedCharacter = (Character)selectDialog.ReturnObject;
                selectedCharacter.Consume(SelectedFoodItem, selectDialog.ReturnValue);
                UpdateDisplay();
                MessageDialog msg = new MessageDialog($"Gave {SelectedFoodItem.Name} to {selectedCharacter.Name}.");
                msg.ShowDialog();
            }
        }
    }
}
