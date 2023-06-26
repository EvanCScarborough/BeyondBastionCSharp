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
        public InspectWindow(Character character, World world)
        {
            InitializeComponent();

            DisplayedCharacter = character;
            CurrentWorld = world;

            UpdateDisplay();
        }

        public Character DisplayedCharacter { get; set; }
        public World CurrentWorld { get; set; }

        private void UpdateDisplay()
        {
            CharacterNameBox.Text = DisplayedCharacter.Name;

            // Initialize the Status table
            HealthLabel.Text = $"{DisplayedCharacter.Health:0.0}/{DisplayedCharacter.GetMaxHealth():0.0}";
            if (DisplayedCharacter.GetMaxHealth() != DisplayedCharacter.GetBaseHealth())
            {
                int modifier = DisplayedCharacter.GetMaxHealth() - DisplayedCharacter.GetBaseHealth();
                HealthLabel.Text += $" ({((modifier < 0) ? string.Empty : "+")}{modifier})";
            }

            EnergyLabel.Text = $"{DisplayedCharacter.Energy:0.0}/{DisplayedCharacter.GetMaxEnergy():0.0}";
            if (DisplayedCharacter.GetMaxEnergy() != DisplayedCharacter.GetBaseEnergy())
            {
                int modifier = DisplayedCharacter.GetMaxEnergy() - DisplayedCharacter.GetBaseEnergy();
                EnergyLabel.Text += $" ({((modifier < 0) ? string.Empty : "+")}{modifier})";
            }

            SanityLabel.Text = $"{DisplayedCharacter.Sanity:0.0}/{DisplayedCharacter.GetMaxSanity():0.0}";
            if (DisplayedCharacter.GetMaxSanity() != DisplayedCharacter.GetBaseSanity())
            {
                int modifier = DisplayedCharacter.GetMaxSanity() - DisplayedCharacter.GetBaseSanity();
                SanityLabel.Text += $" ({((modifier < 0) ? string.Empty : "+")}{modifier})";
            }

            // Initialize the Attributes table
            VitalityLabel.Text = $"Vitality: {DisplayedCharacter.Vitality}";
            EnduranceLabel.Text = $"Endurance: {DisplayedCharacter.Endurance}";
            FocusLabel.Text = $"Focus: {DisplayedCharacter.Focus}";
            StrengthLabel.Text = $"Strength: {DisplayedCharacter.Strength}";
            KnowledgeLabel.Text = $"Knowledge: {DisplayedCharacter.Knowledge}";
            CharismaLabel.Text = $"Charisma: {DisplayedCharacter.Charisma}";

            // Initialize the Combat table
            if (DisplayedCharacter.Equipment[EquipmentSlot.MainHand] == null)
            {
                AttackDamageLabel.Text = CreateStatLabel(DisplayedCharacter.GetAttackDamage(), 1, DisplayedCharacter.GetAttackDamageMod());
                AttackSpeedLabel.Text = $"{DisplayedCharacter.GetAttackSpeed():0.0} (2 {(DisplayedCharacter.GetAttackSpeedMod(2) >= 0 ? "+" : "-")} {(DisplayedCharacter.GetAttackSpeedMod(2) >= 0 ? DisplayedCharacter.GetAttackSpeedMod(2) : DisplayedCharacter.GetAttackSpeedMod(2) * -1):0.0})";
                WoundChanceLabel.Text = "0%";
                FractureChanceLabel.Text = "0%";
                DismemberChanceLabel.Text = "0%";
                KnockdownChanceLabel.Text = CreateStatLabel(DisplayedCharacter.GetKnockdownChance(), 0.02, DisplayedCharacter.GetKnockdownChanceMod(), true);
            }
            else
            {
                WeaponItem weapon = DisplayedCharacter.Equipment[EquipmentSlot.MainHand] as WeaponItem;
                AttackDamageLabel.Text = CreateStatLabel(DisplayedCharacter.GetAttackDamage(), weapon.BaseDamage, DisplayedCharacter.GetAttackDamageMod());
                AttackSpeedLabel.Text = CreateStatLabel(DisplayedCharacter.GetAttackSpeed(), weapon.AttackSpeed, DisplayedCharacter.GetAttackSpeedMod(DisplayedCharacter.GetAttackSpeed()));
                WoundChanceLabel.Text = CreateStatLabel(DisplayedCharacter.GetWoundChance(), weapon.WoundChance, DisplayedCharacter.GetWoundChanceMod(), true);
                FractureChanceLabel.Text = CreateStatLabel(DisplayedCharacter.GetFractureChance(), weapon.FractureChance, DisplayedCharacter.GetFractureChanceMod(), true);
                DismemberChanceLabel.Text = CreateStatLabel(DisplayedCharacter.GetDismemberChance(), weapon.DismemberChance, DisplayedCharacter.GetDismemberChanceMod(), true);
                KnockdownChanceLabel.Text = CreateStatLabel(DisplayedCharacter.GetKnockdownChance(), 0.02 + weapon.KnockdownChance, DisplayedCharacter.GetKnockdownChanceMod(), true);
            }
            BlockChanceLabel.Text = $"{DisplayedCharacter.GetBlockChance() * 100}%";

            // Initialize the Injuries tree
            InjuriesTree.Nodes.Clear();
            foreach (BodyPart part in DisplayedCharacter.BodyParts)
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
            foreach (KeyValuePair<EquipmentSlot, EquipmentItem> keyValue in DisplayedCharacter.Equipment)
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
                YesNoDialog yesNo = new YesNoDialog($"Unequip {DisplayedCharacter.Name}'s {EquipmentTree.SelectedNode.Text}?");
                DialogResult result = yesNo.ShowDialog();
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    EquipmentItem item = DisplayedCharacter.Equipment[(EquipmentSlot)EquipmentTree.SelectedNode.Parent.Tag];

                    CurrentWorld.Inventory.Add(item);
                    DisplayedCharacter.Equipment[item.Slot] = null;
                    UpdateDisplay();
                    MessageDialog msg = new MessageDialog($"{DisplayedCharacter.Name} has unequipped {item.Name}.");
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
                UnequipButton.Enabled = true;
            }
            EquipmentTree.EndUpdate();
        }

        private void InjuriesTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            InjuriesTree.SelectedNode = null;
        }
    }
}
