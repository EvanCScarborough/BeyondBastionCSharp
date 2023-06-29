using System;
using System.Collections.Generic;
using BeyondBastion.Entity;
using BeyondBastion.Events;

namespace BeyondBastion
{
    public class Log
    {
        public Log(World currentWorld)
        {
            CurrentWorld = currentWorld;
            Lines = new List<string>();
        }
        public List<string> Lines { get; }
        public World CurrentWorld { get; }
        public EventHandler<string> LogUpdated;
        public List<string> AddLine(string line)
        {
            line = line.Trim();
            line = $"(Day {CurrentWorld.Day}, hour {CurrentWorld.Hour}) {line}";
            Lines.Add(line);
            LogUpdated?.Invoke(this, line);
            return Lines;
        }

        public void OnDeathEvent(object sender, EntityDeathEvent e)
        {
            string newLine = $"{e.EntityKilled.Name} ";
            switch (e.DamageSource)
            {
                case DamageSource.Absolute:
                    newLine += "is struck down by the gods.";
                    break;

                case DamageSource.MeleeAttack:
                    newLine += $"is slain{(e.Killer == null ? "." : $" by {e.Killer.Name}.")}";
                    break;
                case DamageSource.RangedAttack:
                    newLine += $"is slain{(e.Killer == null ? "." : $" by {e.Killer.Name}.")}";
                    break;

                case DamageSource.WitnessDeath:
                    newLine += $"is driven insane{(e.Killer == null ? "." : $" by the death of {e.Killer.Name}.")}";
                    break;
                case DamageSource.CommitMurder:
                    newLine += $"succumbs to madness{(e.Killer == null ? "." : $" while killing {e.Killer.Name}.")}";
                    break;

                case DamageSource.Hunger:
                    newLine += $"starves to death.";
                    break;
            }
            AddLine(newLine);
        }

        public void OnCharacterConsumeEvent(object sender, CharacterConsumeEvent e)
        {
            string newLine = $"{((Character)sender).Name} ";
            if (e.StoppedDueToFullness) newLine += $"eats {e.NumEaten} {e.FoodEaten.Name} before becoming full.";
            else newLine += $"eats {e.NumEaten} {e.FoodEaten.Name}.";
            AddLine(newLine);
        }
    }
}
