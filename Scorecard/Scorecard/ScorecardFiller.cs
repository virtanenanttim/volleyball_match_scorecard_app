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

        public void SetTeams(string homeTeamName, string guestTeamName)
        {
            //Team home = new Team(homeTeamName, homeTeamAbbreviation);
            //home.SetCoach(homeCoach);
            //home.SetAssistantCoach(homeAssistantCoach);
            //home.SetPlayers(homePlayers);

            //Team guest = new Team(guestTeamName, guestTeamAbbreviation);
            //guest.SetCoach(guestCoach);
            //guest.SetAssistantCoach(guestAssistantCoach);
            //guest.SetPlayers(guestPlayers);

            this.VolleyballMatch = new VolleyballMatch(homeTeamName, guestTeamName);

            this.CurrentSet = 1;
        }

        //public void SetHomeTeamCaptain(int number)
        //{
        //    this.VolleyballMatch.HomeTeam.Players.First(p => p.Number == number).IsCaptain = true; 
        //}

        //public void SetGuestTeamCaptain(int number)
        //{
        //    this.VolleyballMatch.GuestTeam.Players.First(p => p.Number == number).IsCaptain = true;
        //}

        public bool CheckAllPrematchActionsCompleted()
        {
            //if (this.VolleyballMatch.HomeTeam.Players.Count < 6 || this.VolleyballMatch.GuestTeam.Players.Count < 6)
            //{
            //    return false;
            //}

            //if (!this.VolleyballMatch.HomeTeam.Players.Single(p => p.IsCaptain).IsCaptain)
            //{
            //    return false;
            //}

            //if (!this.VolleyballMatch.GuestTeam.Players.Single(p => p.IsCaptain).IsCaptain)
            //{
            //    return false;
            //}

            this.CurrentSet = 1;

            return true;
        }

        public void StartNextSet()
        {
            int nextSetNumber = this.VolleyballMatch.SetsOfTheMatch.LastOrDefault().Key+1;
            this.VolleyballMatch.SetsOfTheMatch.Add(nextSetNumber, new VolleyballSet());

        }

        #endregion

        #region Actions during match



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
                this.VolleyballMatch.SetsOfTheMatch[this.CurrentSet ].HomePoints++;
            }

            if (team == Teams.Guest)
            {
                this.VolleyballMatch.SetsOfTheMatch[this.CurrentSet].GuestPoints++;
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
