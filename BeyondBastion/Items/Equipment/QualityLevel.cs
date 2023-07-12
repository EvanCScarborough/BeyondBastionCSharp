using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondBastion.Items.Equipment
{
    public static class QualityLevel
    {
        public const double Perfected   = 1.1;
        public const double Refined     = 1.05;
        public const double Standard    = 1.0;
        public const double Worn        = 0.9;
        public const double Battered    = 0.8;
        public const double Damaged     = 0.65;

        public static double GetRandom()
        {
            double seed = StaticRandom.Double();
            if (seed >= 0.95)
            {
                return Perfected;
            }
            else if (seed >= 0.85)
            {
                return Refined;
            }
            else if (seed >= 0.65)
            {
                return Standard;
            }
            else if (seed >= 0.4)
            {
                return Worn;
            }
            else if (seed >= 0.15)
            {
                return Battered;
            }
            else return Damaged;
        }

        public static string GetTier(double quality)
        {
            switch (quality)
            {
                case Perfected:
                    return "Perfected";
                case Refined:
                    return "Refined";
                case Standard:
                    return "Standard";
                case Worn:
                    return "Worn";
                case Battered:
                    return "Battered";
                case Damaged:
                    return "Damaged";
                default: throw new InvalidCastException();
            }
        }

        public static Color GetColor(double quality)
        {
            switch (quality)
            {
                case Perfected:
                    return Color.Magenta;
                case Refined:
                    return Color.Turquoise;
                case Standard:
                    return Color.White;
                case Worn:
                    return Color.NavajoWhite;
                case Battered:
                    return Color.DarkGoldenrod;
                case Damaged:
                    return Color.Brown;
                default: throw new InvalidCastException();
            }
        }
    }
}
