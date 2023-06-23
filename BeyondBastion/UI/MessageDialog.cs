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
    public partial class MessageDialog : Form
    {
        public MessageDialog(string message)
        {
            InitializeComponent();
            MessageLabel.Text = message;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
