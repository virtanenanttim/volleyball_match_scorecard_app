using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    internal class Team
    {
        public Team(string name, string abbreviation)
        {
            this.Players = new List<Player>();
            this.Name= name;
            this.Abbreviation = abbreviation;
        }

        public string Name { get; private set; }

        public string Abbreviation { get; private set; }

        public IList<Player> Players { get; private set; }

        public string Coach { get; private set; }

        public string AssistantCoach { get; private set; }

        internal void SetCoach(string coachName)
        {
            this.Coach= coachName;
        }

        internal void SetAssistantCoach(string assistantCoach)
        {
            this.AssistantCoach = assistantCoach;
        }

        internal void SetPlayers(Player[] players)
        {
            foreach (Player item in players)
            {
                this.Players.Add(item);
            }
        }
    }
}
