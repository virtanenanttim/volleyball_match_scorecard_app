using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    public class VolleyballSet
    {
        #region Properties
        public int SetNumber { get; private set; }

        public Team CurrentlyServingTeam { get; private set; }

        public int TargetPoints { get; private set; }

        public int HomePoints { get; internal set; }

        public int GuestPoints { get; internal set; }

        #endregion

        #region Constructors

        public VolleyballSet(int number, int targetPoints = 25)
        {
            this.SetNumber = number;
            this.TargetPoints = targetPoints;
        }

        #endregion

        #region Methods
        public bool HasEnded()
        {
            return (Math.Abs(this.HomePoints - this.GuestPoints) >= 2 && (this.HomePoints >= this.TargetPoints || this.GuestPoints >= this.TargetPoints));
        }
        public void ScorePoint(Team scorer)
        {
            if (scorer == Team.Home)
            {
                this.HomePoints++;
                this.CurrentlyServingTeam = Team.Home;
            }

            if (scorer == Team.Guest)
            {
                this.GuestPoints++;
                this.CurrentlyServingTeam = Team.Guest;
            }
        }

        public void StartingTeam(Team team)
        {
            this.CurrentlyServingTeam = team;
        }
        #endregion

        //public TeamTimeout[] HomeTimeouts { get; internal set; }
        //public TeamTimeout[] GuestTimeouts { get; internal set; }

        //public PlayerExchange[] HomeExchanges { get; internal set; }
        //public PlayerExchange[] GuestExchanges { get; internal set; }

        //public Player[] HomeLineup { get; internal set; }
        //public Player[] GuestLineup { get; internal set; }
    }
}
