using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeyondBastion.UI
{
    public static class StyleRules
    {
        public static Font Heading1 { get; } = new Font("Felix Titling", 48, FontStyle.Regular, GraphicsUnit.Pixel, (byte)(0));
        public static Font Heading2 { get; } = new Font("Felix Titling", 32, FontStyle.Regular, GraphicsUnit.Pixel, (byte)(0));
        public static Font Body { get; } = new Font("Bookman Old Style", 22, FontStyle.Regular, GraphicsUnit.Pixel, (byte)(0));
        public static Font BigBody { get; } = new Font("Bookman Old Style", 28, FontStyle.Regular, GraphicsUnit.Pixel, (byte)(0));


        public static void SetDefaultFont(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Controls != null)
                {
                    SetDefaultFont(control.Controls);
                    control.Font = Body;
                    control.AutoSize = true;
                }
            }
        }
    }
}
