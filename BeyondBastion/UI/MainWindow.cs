using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeyondBastion.Entity;
using BeyondBastion.Events;
using BeyondBastion.UI;
using BeyondBastion.Events.Combat;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace BeyondBastion
{
    public partial class MainWindow : Form, IBeyondBastionUi
    {
        private World currentWorld;
        private List<GroupBox> PartyBoxes;
        private List<List<StatBar>> PartyStatBars;
        private List<StatBar> TargetStatBars;
        private IEntity Target = null;

        // TODO: merge into 1 tooltip instance with fancy font
        private ToolTip PartyMember1HealthTooltip = new ToolTip();
        private ToolTip PartyMember1EnergyTooltip = new ToolTip();
        private ToolTip PartyMember1SanityTooltip = new ToolTip();

        private ToolTip PartyMember2HealthTooltip = new ToolTip();
        private ToolTip PartyMember2EnergyTooltip = new ToolTip();
        private ToolTip PartyMember2SanityTooltip = new ToolTip();

        private ToolTip PartyMember3HealthTooltip = new ToolTip();
        private ToolTip PartyMember3EnergyTooltip = new ToolTip();
        private ToolTip PartyMember3SanityTooltip = new ToolTip();

        private ToolTip PartyMember4HealthTooltip = new ToolTip();
        private ToolTip PartyMember4EnergyTooltip = new ToolTip();
        private ToolTip PartyMember4SanityTooltip = new ToolTip();

        public MainWindow(World world)
        {
            currentWorld = world;
            currentWorld.Log.LogUpdated += Log_Update;
            currentWorld.Combat.OnCombatStart += CombatStart;
            currentWorld.Combat.OnCombatRoundStart += CombatRoundStart;
            currentWorld.Combat.OnCombatTurnEnd += CombatRoundUpdate;
            currentWorld.Combat.OnCombatRoundEnd += CombatRoundEnd;
            currentWorld.Combat.OnCombatEnd += CombatEnd;

            InitializeComponent();

            StyleRules.SetDefaultFont(Controls);
            PartyBox.Font = StyleRules.Heading1;
            NearbyBox.Font = StyleRules.Heading1;
            LogBox.Font = StyleRules.Heading1;
            ActionsBox.Font = StyleRules.Heading1;

            PartyMember1Box.Font = StyleRules.Heading2;
            PartyMember2Box.Font = StyleRules.Heading2;
            PartyMember3Box.Font = StyleRules.Heading2;
            PartyMember4Box.Font = StyleRules.Heading2;
            TargetBox.Font = StyleRules.Heading2;

            LogTextBox.Font = StyleRules.BigBody;
            NearbyEntitiesList.Font = StyleRules.BigBody;
            DateTimeLabel.Font = StyleRules.BigBody;

            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            PartyStatBars = new List<List<StatBar>>();
            TargetStatBars = new List<StatBar> { };

            PartyBoxes = new List<GroupBox>
            {
                PartyMember1Box, PartyMember2Box, PartyMember3Box, PartyMember4Box
            };

            DateTimeLabel.Text = GetTimeString();
            GirnLabel.Text = $"Girn : {currentWorld.Girn}";

            // Initialize the Party boxes
            for (int i = 0; i < 4; i++)
            {
                if (i < currentWorld.PlayerParty.Count)
                {
                    PartyBoxes[i].Visible = true;

                    if (i == 0)
                    {
                        PartyMember1HealthTooltip.SetToolTip(PartyMember1HealthLabel, $"{currentWorld.PlayerParty[i].Health:0.0}/{currentWorld.PlayerParty[i].GetMaxHealth():0.0}");
                        PartyMember1EnergyTooltip.SetToolTip(PartyMember1EnergyLabel, $"{currentWorld.PlayerParty[i].Energy:0.0}/{currentWorld.PlayerParty[i].GetMaxEnergy():0.0}");
                        PartyMember1SanityTooltip.SetToolTip(PartyMember1SanityLabel, $"{currentWorld.PlayerParty[i].Sanity:0.0}/{currentWorld.PlayerParty[i].GetMaxSanity():0.0}");

                        PartyStatBars.Add(new List<StatBar>
                        {
                            new StatBar("PartyMember1Health", PartyMember1HealthBackground, PartyMember1HealthBar, currentWorld.PlayerParty[i], PartyMember1Table, StatBar.Stat.Health),
                            new StatBar("PartyMember1Energy", PartyMember1EnergyBackground, PartyMember1EnergyBar, currentWorld.PlayerParty[i], PartyMember1Table, StatBar.Stat.Energy),
                            new StatBar("PartyMember1Sanity", PartyMember1SanityBackground, PartyMember1SanityBar, currentWorld.PlayerParty[i], PartyMember1Table, StatBar.Stat.Sanity),
                        });
                    }
                    else if (i == 1)
                    {
                        PartyMember2HealthTooltip.SetToolTip(PartyMember2HealthLabel, $"{currentWorld.PlayerParty[i].Health:0.0}/{currentWorld.PlayerParty[i].GetMaxHealth():0.0}");
                        PartyMember2EnergyTooltip.SetToolTip(PartyMember2EnergyLabel, $"{currentWorld.PlayerParty[i].Energy:0.0}/{currentWorld.PlayerParty[i].GetMaxEnergy():0.0}");
                        PartyMember2SanityTooltip.SetToolTip(PartyMember2SanityLabel, $"{currentWorld.PlayerParty[i].Sanity:0.0}/{currentWorld.PlayerParty[i].GetMaxSanity():0.0}");

                        PartyStatBars.Add(new List<StatBar>
                        {
                            new StatBar("PartyMember2Health", PartyMember2HealthBackground, PartyMember2HealthBar, currentWorld.PlayerParty[i], PartyMember2Table, StatBar.Stat.Health),
                            new StatBar("PartyMember2Energy", PartyMember2EnergyBackground, PartyMember2EnergyBar, currentWorld.PlayerParty[i], PartyMember2Table, StatBar.Stat.Energy),
                            new StatBar("PartyMember2Sanity", PartyMember2SanityBackground, PartyMember2SanityBar, currentWorld.PlayerParty[i], PartyMember2Table, StatBar.Stat.Sanity),
                        });
                    }
                    else if (i == 2)
                    {
                        PartyMember3HealthTooltip.SetToolTip(PartyMember3HealthLabel, $"{currentWorld.PlayerParty[i].Health:0.0}/{currentWorld.PlayerParty[i].GetMaxHealth():0.0}");
                        PartyMember3EnergyTooltip.SetToolTip(PartyMember3EnergyLabel, $"{currentWorld.PlayerParty[i].Energy:0.0}/{currentWorld.PlayerParty[i].GetMaxEnergy():0.0}");
                        PartyMember3SanityTooltip.SetToolTip(PartyMember3SanityLabel, $"{currentWorld.PlayerParty[i].Sanity:0.0}/{currentWorld.PlayerParty[i].GetMaxSanity():0.0}");

                        PartyStatBars.Add(new List<StatBar>
                        {
                            new StatBar("PartyMember3Health", PartyMember3HealthBackground, PartyMember3HealthBar, currentWorld.PlayerParty[i], PartyMember3Table, StatBar.Stat.Health),
                            new StatBar("PartyMember3Energy", PartyMember3EnergyBackground, PartyMember3EnergyBar, currentWorld.PlayerParty[i], PartyMember3Table, StatBar.Stat.Energy),
                            new StatBar("PartyMember3Sanity", PartyMember3SanityBackground, PartyMember3SanityBar, currentWorld.PlayerParty[i], PartyMember3Table, StatBar.Stat.Sanity),
                        });
                    }
                    else if (i == 3)
                    {
                        PartyMember4HealthTooltip.SetToolTip(PartyMember4HealthLabel, $"{currentWorld.PlayerParty[i].Health:0.0}/{currentWorld.PlayerParty[i].GetMaxHealth():0.0}");
                        PartyMember4EnergyTooltip.SetToolTip(PartyMember4EnergyLabel, $"{currentWorld.PlayerParty[i].Energy:0.0}/{currentWorld.PlayerParty[i].GetMaxEnergy():0.0}");
                        PartyMember4SanityTooltip.SetToolTip(PartyMember4SanityLabel, $"{currentWorld.PlayerParty[i].Sanity:0.0}/{currentWorld.PlayerParty[i].GetMaxSanity():0.0}");

                        PartyStatBars.Add(new List<StatBar>
                        {
                            new StatBar("PartyMember4Health", PartyMember4HealthBackground, PartyMember4HealthBar, currentWorld.PlayerParty[i], PartyMember4Table, StatBar.Stat.Health),
                            new StatBar("PartyMember4Energy", PartyMember4EnergyBackground, PartyMember4EnergyBar, currentWorld.PlayerParty[i], PartyMember4Table, StatBar.Stat.Energy),
                            new StatBar("PartyMember4Sanity", PartyMember4SanityBackground, PartyMember4SanityBar, currentWorld.PlayerParty[i], PartyMember4Table, StatBar.Stat.Sanity),
                        });
                    }

                    // Update health bar
                    PartyStatBars[i][0].Background.Visible = true;
                    PartyStatBars[i][0].Bar.Visible = true;
                    PartyStatBars[i][0].Update();

                    // Update energy bar
                    PartyStatBars[i][1].Background.Visible = true;
                    PartyStatBars[i][1].Bar.Visible = true;
                    PartyStatBars[i][1].Update();

                    // Update sanity bar
                    PartyStatBars[i][2].Background.Visible = true;
                    PartyStatBars[i][2].Bar.Visible = true;
                    PartyStatBars[i][2].Update();

                    PartyBoxes[i].Text = currentWorld.PlayerParty[i].Name;
                }
                else
                {
                    PartyBoxes[i].Visible = false;
                }
                PartyBoxes[i].Update();
            }
            // Populate the Nearby Entities list
            NearbyEntitiesList.Items.Clear();
            if (currentWorld.InCombat)
            {
                NearbyBox.Text = "Enemies";

                foreach (IEntity entity in currentWorld.Enemies)
                {
                    NearbyEntitiesList.Items.Add($"{entity.Name} ({GetHealthDescriptor(entity)})");
                }
            }
            else
            {
                NearbyBox.Text = "Nearby";
                foreach (IEntity entity in currentWorld.GetNPCs())
                {
                    NearbyEntitiesList.Items.Add(entity.Name);
                }
            }

            NearbyEntitiesList_Update();
        }

        private string GetHealthDescriptor(IEntity entity)
        {
            double fraction = entity.Health / entity.GetBaseHealth();
            if (fraction == 1) return "Unharmed";
            else if (fraction > 0.8) return "Slightly injured";
            else if (fraction > 0.6) return "Injured";
            else if (fraction > 0.4) return "Severely wounded";
            else if (fraction > 0.2) return "Mutilated";
            else if (fraction > 0) return "Near Death";
            else return "Dead";
        }

        private void Log_Update(object sender, LogUpdate update)
        {
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.SelectionLength = 0;

            LogTextBox.SelectionColor = update.LineColor;
            LogTextBox.AppendText(update.NewLine + "\n");
            LogTextBox.SelectionColor = LogTextBox.ForeColor;
        }

        private void NearbyEntitiesList_Update()
        {
            if (Target != null)
            {
                TargetBox.Text = Target.Name;
                TargetTable.Visible = true;

                TargetStatBars.Clear();
                TargetStatBars.Add(new StatBar("TargetHealth", TargetHealthBackground, TargetHealthBar, Target, TargetTable, StatBar.Stat.Health));

                foreach (StatBar statBar in TargetStatBars)
                {
                    statBar.Update();
                }
            }
            else
            {
                TargetBox.Text = "No Target";
                TargetTable.Visible = false;
            }
            TargetBox.Update();
            TargetTable.Update();
            NearbyEntitiesList.Update();
        }

        private void CombatStart(object sender, CombatStartEvent e)
        {
            ActionButton1.Text = "Continue Combat";
            ActionButton2.Text = "Command Party Members";
            UpdateDisplay();
        }

        private void CombatRoundStart(object sender, CombatRoundStartEvent e)
        {
            InventoryButton.Enabled = false;
            ActionButton1.Enabled = false;
            ActionButton2.Enabled = false;
            ActionButton3.Enabled = false;
            ActionButton4.Enabled = false;
            ActionButton5.Enabled = false;
            ActionButton6.Enabled = false;
            PartyMember1InspectButton.Enabled = false;
            PartyMember2InspectButton.Enabled = false;
            PartyMember3InspectButton.Enabled = false;
            PartyMember4InspectButton.Enabled = false;
            TargetInspectButton.Enabled = false;
            UpdateDisplay();
        }

        private void CombatRoundUpdate(object sender, CombatActionEvent e)
        {
            if (currentWorld.Enemies.Contains(e.Target))
            {
                NearbyEntitiesList.SelectedItem = e.Target;
                Target = e.Target;
                NearbyEntitiesList_Update();
            }
            UpdateDisplay();
            LogTextBox.Update();
        }

        private void CombatRoundEnd(object sender, CombatRoundEndEvent e)
        {
            InventoryButton.Enabled = true;
            ActionButton1.Enabled = true;
            ActionButton2.Enabled = true;
            ActionButton3.Enabled = true;
            ActionButton4.Enabled = true;
            ActionButton5.Enabled = true;
            ActionButton6.Enabled = true;
            PartyMember1InspectButton.Enabled = true;
            PartyMember2InspectButton.Enabled = true;
            PartyMember3InspectButton.Enabled = true;
            PartyMember4InspectButton.Enabled = true;
            TargetInspectButton.Enabled = true;
            UpdateDisplay();
        }

        private void CombatEnd(object sender, CombatEndEvent e)
        {
            ActionButton1.Text = "Action 1";
            ActionButton2.Text = "Action 2";
            UpdateDisplay();
        }
        private string GetTimeString()
        {
            string timeString = $"Day {currentWorld.Day}, {currentWorld.Hour}";
            if (currentWorld.Hour == 1 || currentWorld.Hour == 21) return timeString + "st hour";
            else if (currentWorld.Hour == 2 || currentWorld.Hour == 22) return timeString + "nd hour";
            else if (currentWorld.Hour == 3 || currentWorld.Hour == 23) return timeString + "rd hour";
            else return timeString + "th hour";
        }

        private void OuchieButton_Click(object sender, EventArgs e)
        {
            foreach (Character c in currentWorld.PlayerParty.ToList())
            {
                c.TakeDamage(10, c.BodyParts[0], DamageSource.Absolute);
            }

            UpdateDisplay();
        }

        private void PartyBox_SizeChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void OpenInspectWindow(IEntity character, bool canModifyEquipment=true, bool canViewPrivateInfo = true)
        {
            InspectWindow inspectWindow = new InspectWindow(character, currentWorld, canModifyEquipment, canViewPrivateInfo);
            inspectWindow.ShowDialog();
        }

        private void PartyMember1InspectButton_Click(object sender, EventArgs e)
        {
            OpenInspectWindow(currentWorld.PlayerParty[0]);
        }

        private void PartyMember2InspectButton_Click(object sender, EventArgs e)
        {
            OpenInspectWindow(currentWorld.PlayerParty[1]);
        }

        private void PartyMember3InspectButton_Click(object sender, EventArgs e)
        {
            OpenInspectWindow(currentWorld.PlayerParty[2]);
        }

        private void PartyMember4InspectButton_Click(object sender, EventArgs e)
        {
            OpenInspectWindow(currentWorld.PlayerParty[3]);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            InventoryWindow inventoryWindow = new InventoryWindow(currentWorld, this);
            inventoryWindow.ShowDialog();
        }

        private void PassTimeButton_Click(object sender, EventArgs e)
        {
            currentWorld.PassTime(1);
            UpdateDisplay();
        }

        private void NearbyEntitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NearbyEntitiesList.SelectedIndex != -1) { Target = currentWorld.GetNPCs()[NearbyEntitiesList.SelectedIndex]; }
            else
            {
                Target = null;
            }
            NearbyEntitiesList_Update();
        }

        private void TargetInspectButton_Click(object sender, EventArgs e)
        {
            OpenInspectWindow(Target, false, false);
        }

        private void ActionButton6_Click(object sender, EventArgs e)
        {
            currentWorld.PassTime(1);
        }

        private void ActionButton1_Click(object sender, EventArgs e)
        {
            if (currentWorld.InCombat)
            {
                currentWorld.Combat.SimulateRound();
            }
        }

        private void ActionButton2_Click(object sender, EventArgs e)
        {
            if (currentWorld.InCombat)
            {
                CommandPartyWindow window = new CommandPartyWindow(currentWorld.Combat.NextMoveList, currentWorld);
                window.ShowDialog();
            }
        }

        private void TargetTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
