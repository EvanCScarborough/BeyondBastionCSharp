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

namespace BeyondBastion
{
    public partial class SelectFromListDialog : Form
    {
        public SelectFromListDialog(string message, object[] givenArray)
        {
            InitializeComponent();

            MessageLabel.Text = message;
            ListedOptions = givenArray;

            if (ListedOptions[0] is Character)
            {
                foreach (Character c in ListedOptions.Cast<Character>())
                {
                    int index = ListBox.Items.Add(c.Name);
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public object ReturnObject { get; set; }
        public object[] ListedOptions { get; set; }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedItems.Count > 0)
            {
                SelectButton.Enabled = true;
            }
            else
            {
                SelectButton.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ReturnObject = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            ReturnObject = ListedOptions[ListBox.SelectedIndex];
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
