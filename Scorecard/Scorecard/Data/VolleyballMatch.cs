using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    public class VolleyballMatch
    {
        public VolleyballMatch(string home, string guest, int requiredSetsForWin = 3)
        {
            this.HomeTeam = home;
            this.GuestTeam = guest;
            this.SetsOfTheMatch = new Dictionary<int, VolleyballSet>();
            this.CurrentSet = 0;
            this.SetVictoriesToWinMatch = requiredSetsForWin;
        }

        public int SetVictoriesToWinMatch { get; private set; }
        public string GuestTeam { get; internal set; }
        public string HomeTeam { get; internal set; }

        public IDictionary<int, VolleyballSet> SetsOfTheMatch { get; internal set; }

        public int CurrentSet { get; internal set; }
        public int SetsWonByGuestTeam { get { return this.SetsWonBy(Team.Guest); } }
        public int SetsWonByHomeTeam { get { return this.SetsWonBy(Team.Home); } }

        public bool HasEnded()
        {
            if (this.SetsWonBy(Team.Home) == this.SetVictoriesToWinMatch || this.SetsWonBy(Team.Guest) == this.SetVictoriesToWinMatch)
            {
                return true;
            }
            return false;
        }

        private int SetsWonBy(Team team)
        {
            return this.SetsOfTheMatch.Values.Count(s => s.Winner() == team);
        }

        public VolleyballSet AddNewSet()
        {
            if (this.CurrentSet == 0 || this.SetsOfTheMatch[this.CurrentSet].HasEnded())
            {
                this.CurrentSet++;
                VolleyballSet result;
                if (this.CurrentSet < (this.SetVictoriesToWinMatch * 2 - 1))
                {
                    result = new VolleyballSet(this.CurrentSet);
                }
                else
                {
                    result = new VolleyballSet(this.CurrentSet, 15);
                }

                SetsOfTheMatch.Add(this.CurrentSet, result);
                return result;
            }
            else
            {
                throw new InvalidOperationException("Can't add new set before previous set has completed");
            }
        }
    }
}
