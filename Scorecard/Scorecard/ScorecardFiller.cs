using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    public class ScorecardFiller
    {
        #region Constructor
        public ScorecardFiller()
        {

        }
        #endregion

        #region Properties
        public VolleyballMatch VolleyballMatch { get; private set; }
        #endregion

        #region Pre-match actions

        public void SetTeams(string homeTeamName, string homeTeamAbbreviation, string homeCoach, string homeAssistantCoach, string v5, Player[] homePlayers, string guestTeamName, string guestTeamAbbreviation, string guestCoach, string guestAssistantCoach, string v10, Player[] guestPlayers)
        {
            Team home = new Team(homeTeamName, homeTeamAbbreviation);
            home.SetCoach(homeCoach);
            home.SetAssistantCoach(homeAssistantCoach);
            home.SetPlayers(homePlayers);

            Team guest = new Team(guestTeamName, guestTeamAbbreviation);
            guest.SetCoach(guestCoach);
            guest.SetAssistantCoach(guestAssistantCoach);
            guest.SetPlayers(guestPlayers);

            this.VolleyballMatch = new VolleyballMatch(home, guest);

            this.CurrentSet = 1;
        }

        public void SetHomeTeamCaptain(int number)
        {
            this.VolleyballMatch.HomeTeam.Players.First(p => p.Number == number).IsCaptain = true; 
        }

        public void SetGuestTeamCaptain(int number)
        {
            this.VolleyballMatch.GuestTeam.Players.First(p => p.Number == number).IsCaptain = true;
        }

        public bool CheckAllPrematchActionsCompleted()
        {
            if (this.VolleyballMatch.HomeTeam.Players.Count < 6 || this.VolleyballMatch.GuestTeam.Players.Count < 6)
            {
                return false;
            }

            if (!this.VolleyballMatch.HomeTeam.Players.Single(p => p.IsCaptain).IsCaptain)
            {
                return false;
            }

            if (!this.VolleyballMatch.GuestTeam.Players.Single(p => p.IsCaptain).IsCaptain)
            {
                return false;
            }

            this.CurrentSet = 1;

            return true;
        }
        #endregion

        #region Actions during match
        public void SetHomeLineup(int set, Player player1, Player player2, Player player3, Player player4, Player player5, Player player6)
        {
            this.VolleyballMatch.SetsOfTheMatch.Add(new VolleyballSet());

            this.VolleyballMatch.SetsOfTheMatch[set - 1].HomeLineup = new Player[] { player1, player2, player3, player4, player5, player6 };
        }


        #endregion

        #region Post-match actions

        #endregion

        #region Checks that must be done time to time
        public int CurrentSet { get; private set; }

     
        public void SetStartingTeam(Teams home)
        {
            
        }

        public void AddPoint(Teams team)
        {
            if (team == Teams.Home)
            {
                this.VolleyballMatch.SetsOfTheMatch[this.CurrentSet - 1].HomePoints++;
            }

            if (team == Teams.Guest)
            {
                this.VolleyballMatch.SetsOfTheMatch[this.CurrentSet - 1].GuestPoints++;
            }
        }


        #endregion
    }

    public enum Teams
    {
        None,
        Home,
        Guest
    }
}
