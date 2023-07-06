using System;
using System.Drawing;
using System.Collections.Generic;
using BeyondBastion.Entity;
using BeyondBastion.Events;
using BeyondBastion.Events.Combat;
using System.Threading;
using BeyondBastion.Entity.BodyParts;
using System.CodeDom.Compiler;

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
        public EventHandler<LogUpdate> LogUpdated;
        public List<string> AddLine(string line, Color color, bool indent = false)
        {
            if (!CurrentWorld.InCombat) line = $"(Day {CurrentWorld.Day}, hour {CurrentWorld.Hour}) {line}";
            else if (indent) line = "    ⁃ " + line;
            Lines.Add(line);
            LogUpdated?.Invoke(this, new LogUpdate(line, color));
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

                case DamageSource.Beheading:
                    newLine += $"is beheaded{(e.Killer == null ? "." : $" by {e.Killer.Name}.")}";
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
            AddLine(newLine, e.WasPartyMember ? Color.Brown : Color.Crimson, true);
        }

        public void OnCombatRoundStart(object sender, CombatRoundStartEvent e)
        {
            AddLine("A new round of combat begins.", Color.White);
        }

        public void OnCombatAction(object sender, CombatActionEvent e)
        {
            string newLine = $"{e.Actor.Name} ";
            if (e.Result == CombatActionResult.Block)
            {
                AddLine(newLine + $"tries to attack {e.Target.Name}, but {e.Target.Name} blocks.", CurrentWorld.PlayerParty.Contains((Character)e.Target) ? Color.LimeGreen : Color.ForestGreen);
            }
            else if (e.Result == CombatActionResult.Hit)
            {
                AddLine(newLine + $"hits {e.Target.Name} in the {e.HitLocation.Name}.", CurrentWorld.PlayerParty.Contains((Character)e.Target) ? Color.Chocolate : Color.Orange);
            }
            if (e.Injury != null)
            {
                if (e.Injury.Type == Entity.BodyParts.InjuryType.Dismemberment && e.HitLocation.Type == BodyPartType.Head) { return; }
                newLine = $"{e.Target.Name}";
                switch (e.Injury.Type)
                {
                    case Entity.BodyParts.InjuryType.MinorWound:
                        newLine += " receives a Minor Wound.";
                        break;
                    case Entity.BodyParts.InjuryType.MajorWound:
                        newLine += " receives a Major Wound.";
                        break;
                    case Entity.BodyParts.InjuryType.Fracture:
                        newLine = $"A bone in {e.Target.Name}'s {e.HitLocation.Name} is Fractured.";
                        break;
                    case Entity.BodyParts.InjuryType.Dismemberment:
                        newLine += $"'s {e.HitLocation.Name} is dismembered.";
                        break;
                }
                AddLine(newLine, CurrentWorld.PlayerParty.Contains((Character)e.Target) ? Color.IndianRed : Color.LightCoral, true);
            }
        }

        public void OnDisarmEvent(object sender, EntityDisarmEvent e)
        {
            string newLine = $"{e.Actor.Name} drops their {e.DroppedItem.Name}.";
            if (e.PlacedInInventory) { newLine += " It has been placed in the party inventory."; }
            AddLine(newLine, CurrentWorld.PlayerParty.Contains((Character)e.Actor) ? Color.SteelBlue : Color.LightSkyBlue, true);
        }

        public void OnCharacterConsumeEvent(object sender, CharacterConsumeEvent e)
        {
            string newLine = $"{((Character)sender).Name} ";
            if (e.StoppedDueToFullness) newLine += $"eats {e.NumEaten} {e.FoodEaten.Name} before becoming full.";
            else newLine += $"eats {e.NumEaten} {e.FoodEaten.Name}.";
            AddLine(newLine, Color.PowderBlue);
        }
    }
}
