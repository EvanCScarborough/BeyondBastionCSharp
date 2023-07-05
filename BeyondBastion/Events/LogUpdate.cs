using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Events
{
    public class LogUpdate
    {
        public LogUpdate(string newLine, Color lineColor)
        {
            NewLine = newLine;
            LineColor = lineColor;
        }

        public string NewLine { get; }
        public Color LineColor { get; }
    }
}
