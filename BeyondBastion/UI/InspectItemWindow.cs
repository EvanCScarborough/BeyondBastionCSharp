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
using BeyondBastion.Items.Equipment.Shields;
using BeyondBastion.Items.Equipment;

namespace BeyondBastion.UI
{
    public partial class InspectItemWindow : Form
    {
        public InspectItemWindow(Item item)
        {
            InitializeComponent();

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

            foreach (KeyValuePair<Label, Label> pair in LabelValuePairs)
            {
                pair.Key.Text = string.Empty;
                pair.Value.Text = string.Empty;
            }

            SelectedItem = item;
            UpdateDetailsBox();
        }

        public Item SelectedItem { get; }
        private readonly Dictionary<Label, Label> LabelValuePairs;
        private void UpdateDetailsBox()
        {
            ItemNameLabel.Text = string.Empty;
            ItemDescriptionLabel.Text = "No item selected.";
            BlessingDescriptionLabel.Text = string.Empty;

            if (SelectedItem != null)
            {
                ItemNameLabel.Text = SelectedItem.Name;
                ItemQualityLabel.Text = string.Empty;
                ItemNameLabel.ForeColor = Color.White;
                ItemDescriptionLabel.Text = SelectedItem.Description;

                if (SelectedItem is EquipmentItem equipmentItem)
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

                    if (SelectedItem is WeaponItem weaponItem)
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
                    else if (SelectedItem is ShieldItem shieldItem)
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
                    ItemDescriptionLabel.Text = SelectedItem.Description;
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
