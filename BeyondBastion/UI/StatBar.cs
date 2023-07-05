using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeyondBastion.Entity;

namespace BeyondBastion.UI
{
    public class StatBar
    {
        public enum Stat
        {
            Health,
            Energy,
            Sanity
        }

        public StatBar(string id, Panel backgroundPanel, Panel barPanel, IEntity linkedCharacter, TableLayoutPanel container, Stat linkedStat)
        {
            Id = id;
            Background = backgroundPanel;
            Bar = barPanel;
            LinkedCharacter = linkedCharacter;
            Container = container;
            LinkedStat = linkedStat;
        }

        public string Id { get; }
        public TableLayoutPanel Container { get; }
        public Panel Background;
        public Panel Bar { get; }
        public IEntity LinkedCharacter { get; }
        public Stat LinkedStat { get; }

        public void Update()
        {
            int width = Background.Width;
            Bar.Height = Background.Height;
            double fraction = 1;
            switch (LinkedStat)
            {
                case Stat.Health:
                    fraction = LinkedCharacter.Health / LinkedCharacter.GetMaxHealth();
                    break;
                case Stat.Energy:
                    fraction = LinkedCharacter.Energy / LinkedCharacter.GetMaxEnergy();
                    break;
                case Stat.Sanity:
                    fraction = LinkedCharacter.Sanity / LinkedCharacter.GetMaxSanity();
                    break;
            }
            Bar.Width = (int)Math.Round(width * fraction);
            if (Bar.Width > Background.Width) Bar.Width = Background.Width;
            Bar.Update();
            Background.Update();
        }
    }
}
