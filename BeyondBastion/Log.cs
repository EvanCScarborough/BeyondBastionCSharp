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

            foreach (Character playerChar in currentWorld.PlayerParty)
            {
                playerChar.Death += PlayerParty_Death;
            }
        }
        public List<string> Lines { get; }
        public World CurrentWorld { get; }
        public EventHandler<string> LogUpdated;
        public List<string> AddLine(string line)
        {
            Lines.Add(line);
            LogUpdated?.Invoke(this, line);
            return Lines;
        }

        private void PlayerParty_Death(object sender, EntityDeathEvent e)
        {
            string newLine = $"{e.EntityKilled.Name} ";
            if (e.Killer != null)
            {
                if (e.EntityKilled.Health <= 0)
                {
                    newLine += "was slain by " + e.Killer.Name;
                }
                else if (e.EntityKilled.Energy <= 0)
                {
                    newLine += "was driven to exhaustion by " + e.Killer.Name;
                }
                else if (e.EntityKilled.Sanity <= 0)
                {
                    newLine += "was driven insane by " + e.Killer.Name;
                }
            }
            else
            {
                newLine += "has died.";
            }
            AddLine(newLine);
        }
    }
}
