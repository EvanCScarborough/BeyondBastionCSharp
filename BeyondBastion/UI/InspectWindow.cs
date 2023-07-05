using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeyondBastion.Entity;
using BeyondBastion.Entity.BodyParts;
using BeyondBastion.Items.Equipment;
using BeyondBastion.UI;

namespace BeyondBastion
{
    public partial class InspectWindow : Form
    {
        public InspectWindow(IEntity character, World world, bool canModifyEquipment=true, bool canViewPrivateInfo=true)
        {
            InitializeComponent();

            DisplayedEntity = character;
            CurrentWorld = world;
            CanModifyEquipment = canModifyEquipment;
            CanViewPrivateInfo = canViewPrivateInfo;

            UpdateDisplay();
        }

        public IEntity DisplayedEntity { get; set; }
        public World CurrentWorld { get; set; }
        public bool CanModifyEquipment { get; set; }
        public bool CanViewPrivateInfo { get; set; }

        private void UpdateDisplay()
        {
            CharacterNameBox.Text = DisplayedEntity.Name;

            // Initialize the Status table
            if (CanViewPrivateInfo)
            {
                HealthLabel.Text = $"{DisplayedEntity.Health:0.0}/{DisplayedEntity.GetMaxHealth():0.0}";
                if (DisplayedEntity.GetMaxHealth() != DisplayedEntity.GetBaseHealth())
                {
                    int modifier = DisplayedEntity.GetMaxHealth() - DisplayedEntity.GetBaseHealth();
                    HealthLabel.Text += $" ({((modifier < 0) ? string.Empty : "+")}{modifier})";
                }

                EnergyLabel.Text = $"{DisplayedEntity.Energy:0.0}/{DisplayedEntity.GetMaxEnergy():0.0}";
                if (DisplayedEntity.GetMaxEnergy() != DisplayedEntity.GetBaseEnergy())
                {
                    int modifier = DisplayedEntity.GetMaxEnergy() - DisplayedEntity.GetBaseEnergy();
                    EnergyLabel.Text += $" ({((modifier < 0) ? string.Empty : "+")}{modifier})";
                }

                SanityLabel.Text = $"{DisplayedEntity.Sanity:0.0}/{DisplayedEntity.GetMaxSanity():0.0}";
                if (DisplayedEntity.GetMaxSanity() != DisplayedEntity.GetBaseSanity())
                {
                    int modifier = DisplayedEntity.GetMaxSanity() - DisplayedEntity.GetBaseSanity();
                    SanityLabel.Text += $" ({((modifier < 0) ? string.Empty : "+")}{modifier})";
                }
            }
            else
            {
                HealthLabel.Text = "???/???";
                EnergyLabel.Text = "???/???";
                SanityLabel.Text = "???/???";
            }


            // Initialize the Attributes table
            if (CanViewPrivateInfo)
            {
                VitalityLabel.Text = $"Vitality: {DisplayedEntity.Vitality}";
                EnduranceLabel.Text = $"Endurance: {DisplayedEntity.Endurance}";
                FocusLabel.Text = $"Focus: {DisplayedEntity.Focus}";
                StrengthLabel.Text = $"Strength: {DisplayedEntity.Strength}";
                KnowledgeLabel.Text = $"Knowledge: {DisplayedEntity.Knowledge}";
                CharismaLabel.Text = $"Charisma: {DisplayedEntity.Charisma}";
            }
            else
            {
                VitalityLabel.Text = $"Vitality: ???";
                EnduranceLabel.Text = $"Endurance: ???";
                FocusLabel.Text = $"Focus: ???";
                StrengthLabel.Text = $"Strength: ???";
                KnowledgeLabel.Text = $"Knowledge: ???";
                CharismaLabel.Text = $"Charisma: ???";
            }


            // Initialize the Combat table
            if (CanViewPrivateInfo)
            {
                if (DisplayedEntity.Equipment[EquipmentSlot.MainHand] == null)
                {
                    AttackDamageLabel.Text = CreateStatLabel(DisplayedEntity.GetAttackDamage(), 1, DisplayedEntity.GetAttackDamageMod());
                    AttackSpeedLabel.Text = $"{DisplayedEntity.GetAttackSpeed():0.0} (1.2 {(DisplayedEntity.GetAttackSpeedMod(1.2) >= 0 ? "+" : "-")} {(DisplayedEntity.GetAttackSpeedMod(1.2) >= 0 ? DisplayedEntity.GetAttackSpeedMod(1.2) : DisplayedEntity.GetAttackSpeedMod(1.2) * -1):0.0})";
                    WoundChanceLabel.Text = "0%";
                    FractureChanceLabel.Text = "0%";
                    DismemberChanceLabel.Text = "0%";
                    KnockdownChanceLabel.Text = CreateStatLabel(DisplayedEntity.GetKnockdownChance(), 0.02, DisplayedEntity.GetKnockdownChanceMod(), true);
                }
                else
                {
                    WeaponItem weapon = DisplayedEntity.Equipment[EquipmentSlot.MainHand] as WeaponItem;
                    AttackDamageLabel.Text = CreateStatLabel(DisplayedEntity.GetAttackDamage(), weapon.BaseDamage, DisplayedEntity.GetAttackDamageMod());
                    AttackSpeedLabel.Text = CreateStatLabel(DisplayedEntity.GetAttackSpeed(), weapon.AttackSpeed, DisplayedEntity.GetAttackSpeedMod(DisplayedEntity.GetAttackSpeed()));
                    WoundChanceLabel.Text = CreateStatLabel(DisplayedEntity.GetWoundChance(), weapon.WoundChance, DisplayedEntity.GetWoundChanceMod(), true);
                    FractureChanceLabel.Text = CreateStatLabel(DisplayedEntity.GetFractureChance(), weapon.FractureChance, DisplayedEntity.GetFractureChanceMod(), true);
                    DismemberChanceLabel.Text = CreateStatLabel(DisplayedEntity.GetDismemberChance(), weapon.DismemberChance, DisplayedEntity.GetDismemberChanceMod(), true);
                    KnockdownChanceLabel.Text = CreateStatLabel(DisplayedEntity.GetKnockdownChance(), 0.02 + weapon.KnockdownChance, DisplayedEntity.GetKnockdownChanceMod(), true);
                }
                BlockChanceLabel.Text = $"{DisplayedEntity.GetBlockChance() * 100}%";
            }
            else
            {
                AttackDamageLabel.Text = "???";
                AttackSpeedLabel.Text = "???";
                WoundChanceLabel.Text = "???";
                FractureChanceLabel.Text = "???";
                DismemberChanceLabel.Text = "???";
                KnockdownChanceLabel.Text = "???";
                BlockChanceLabel.Text = "???";
            }


            // Initialize the Injuries tree
            InjuriesTree.Nodes.Clear();
            foreach (BodyPart part in DisplayedEntity.BodyParts)
            {
                if (part.GetInjuries().Count > 0)
                {
                    TreeNode newParentNode = new TreeNode(part.Name);
                    int nodeIndex = InjuriesTree.Nodes.Add(newParentNode);

                    foreach (Injury inj in part.GetInjuries())
                    {
                        TreeNode newNode = new TreeNode(inj.Name);
                        InjuriesTree.Nodes[nodeIndex].Nodes.Add(newNode);

                        newNode.ToolTipText = inj.Description;
                    }
                }
            }
            if (InjuriesTree.GetNodeCount(false) == 0)
            {
                InjuriesTree.Nodes.Add("None");
            }
            InjuriesTree.ExpandAll();

            // Initialize the Equipment tree
            EquipmentTree.Nodes.Clear();
            foreach (KeyValuePair<EquipmentSlot, EquipmentItem> keyValue in DisplayedEntity.Equipment)
            {
                string Label = keyValue.Key.ToString();
                string Item = keyValue.Value == null ? string.Empty : keyValue.Value.ToString();

                if (Label == "MainHand")
                {
                    Label = "Main Hand";
                }
                else if (Label == "OffHand")
                {
                    Label = "Off Hand";
                }

                TreeNode node = new TreeNode(Label)
                {
                    Tag = keyValue.Key
                };
                int index = EquipmentTree.Nodes.Add(node);
                if (Item != string.Empty)
                {
                    TreeNode childNode = EquipmentTree.Nodes[index].Nodes.Add(Item);
                    childNode.Tag = keyValue.Value;
                }
            }
            EquipmentTree.ExpandAll();

            InspectButton.Enabled = false;
            UnequipButton.Enabled = false;

            if (!CanModifyEquipment)
            {
                EquipmentAndButtonsTable.SetColumnSpan(InspectButton, 2);
                EquipmentAndButtonsTable.Controls.Remove(UnequipButton);
            }
        }

        private string CreateStatLabel(double total, double baseStat, double modifier, bool formatAsPercent=false)
        {
            if (formatAsPercent)
            {
                return $"{total * 100}% ({baseStat * 100} {(modifier < 0 ? $"- {modifier * -100}" : $"+ {modifier * 100}")})";
            }
            return $"{total} ({baseStat} {(modifier < 0 ? $"- {modifier * -1}" : $"+ {modifier}")})";
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InspectWindow_Load(object sender, EventArgs e)
        {

        }

        private void UnequipButton_Click(object sender, EventArgs e)
        {
            if (EquipmentTree.SelectedNode != null)
            {
                YesNoDialog yesNo = new YesNoDialog($"Unequip {DisplayedEntity.Name}'s {EquipmentTree.SelectedNode.Text}?");
                DialogResult result = yesNo.ShowDialog();
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    EquipmentItem item = DisplayedEntity.Equipment[(EquipmentSlot)EquipmentTree.SelectedNode.Parent.Tag];

                    CurrentWorld.Inventory.Add(item);
                    DisplayedEntity.Equipment[item.Slot] = null;
                    UpdateDisplay();
                    MessageDialog msg = new MessageDialog($"{DisplayedEntity.Name} has unequipped {item.Name}.");
                    msg.ShowDialog();
                }
            }
        }

        private void EquipmentTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void EquipmentTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void EquipmentTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            EquipmentTree.BeginUpdate();
            if (EquipmentTree.SelectedNode.Tag is EquipmentSlot)
            {
                EquipmentTree.SelectedNode = null;
                InspectButton.Enabled = false;
                UnequipButton.Enabled = false;
            }
            if (EquipmentTree.SelectedNode != null)
            {
                InspectButton.Enabled = true;
                if (CanModifyEquipment)
                {
                    UnequipButton.Enabled = true;
                }
            }
            EquipmentTree.EndUpdate();
        }

        private void InjuriesTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            InjuriesTree.SelectedNode = null;
        }

        private void InspectWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
