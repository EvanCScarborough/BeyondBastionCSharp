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

namespace BeyondBastion.UI
{
    public partial class CommandPartyWindow : Form
    {
        public CommandPartyWindow(List<CombatAction> actionsList, World currentWorld)
        {
            InitializeComponent();
            ModifyActionTable.Visible = false;
            ActionsList = actionsList;
            DisplayedActions = new List<CombatAction>();

            foreach (CombatAction action in ActionsList)
            {
                if (currentWorld.PlayerParty.Contains(action.Actor))
                {
                    ListViewItem newAction = ActionsListView.Items.Add(action.Actor.Name);
                    newAction.SubItems.Add(action.Type.ToString());
                    if (action.Target != null)
                    {
                        newAction.SubItems.Add(action.Target.Name);
                    }
                    newAction.Tag = action;
                    DisplayedActions.Add(action);
                }
            }
        }

        public List<CombatAction> DisplayedActions { get; set; }
        public List<CombatAction> ActionsList { get; set; }
        private ListViewItem SelectedActionItem { get; set; }

        private void ActionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActionsListView.SelectedItems.Count > 0)
            {
                ModifyActionTable.Visible = true;
                SelectedActionItem = ActionsListView.SelectedItems[0];

                CombatAction selectedAction = (CombatAction)ActionsListView.SelectedItems[0].Tag;
                PartyMemberName.Text = selectedAction.Actor.Name;
                ActionSelector.SelectedIndex = (int)selectedAction.Type;
            } 
            else
            {
                ModifyActionTable.Visible = false;
            }
        }

        private void ActionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            CombatAction selectedAction = SelectedActionItem.Tag as CombatAction;
            selectedAction.Type = (CombatActionType)ActionSelector.SelectedIndex;
            SelectedActionItem.SubItems[1].Text = selectedAction.Type.ToString();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
