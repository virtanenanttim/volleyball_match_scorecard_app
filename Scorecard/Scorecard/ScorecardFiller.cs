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
        }
        #endregion

        #region Actions during match

        #endregion

        #region Post-match actions

        #endregion

    }
}
