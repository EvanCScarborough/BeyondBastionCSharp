using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeyondBastion.Entity;
using BeyondBastion.UI;

namespace BeyondBastion
{
    public partial class SelectFromListWithAmountDialog : Form
    {
        public SelectFromListWithAmountDialog(string message, object[] givenArray, int maxAmount, IBeyondBastionUi parentWindow)
        {
            InitializeComponent();

            MessageLabel.Text = message;
            ListedOptions = givenArray;
            ParentWindow = parentWindow;

            if (ListedOptions[0] is Character)
            {
                foreach (Character c in ListedOptions.Cast<Character>())
                {
                    ListBox.Items.Add(c.Name);
                }
            }
            else
            {
                throw new NotImplementedException();
            }

            AmountSelector.Maximum = maxAmount;
        }

        public object ReturnObject { get; set; }
        public int ReturnValue { get; set; }
        public object[] ListedOptions { get; set; }
        public IBeyondBastionUi ParentWindow { get; set; }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedItems.Count > 0)
            {
                SelectButton.Enabled = true;
                AmountSelector.Enabled = true;
            }
            else
            {
                SelectButton.Enabled = false;
                AmountSelector.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ReturnObject = null;
            ReturnValue = -1;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            ReturnObject = ListedOptions[ListBox.SelectedIndex];
            ReturnValue = (int)AmountSelector.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AmountSelector_ValueChanged(object sender, EventArgs e)
        {
        }

        private void SelectFromListWithAmountDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentWindow.UpdateDisplay();
        }
    }
}
