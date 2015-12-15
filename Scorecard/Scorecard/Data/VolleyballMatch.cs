using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    public class VolleyballMatch
    {
        public VolleyballMatch(Team home, Team guest)
        {
            this.HomeTeam = home;
            this.GuestTeam = guest;
            this.SetsOfTheMatch = new List<VolleyballSet>();
        }

        public Team GuestTeam { get; internal set; }
        public Team HomeTeam { get; internal set; }

        public IList<VolleyballSet> SetsOfTheMatch { get; internal set; }
    }
}
