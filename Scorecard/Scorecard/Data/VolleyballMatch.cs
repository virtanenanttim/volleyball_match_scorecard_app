using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    public class VolleyballMatch
    {
        public VolleyballMatch(string home, string guest)
        {
            this.HomeTeam = home;
            this.GuestTeam = guest;
            this.SetsOfTheMatch = new Dictionary<int, VolleyballSet>();
        }

        public string GuestTeam { get; internal set; }
        public string HomeTeam { get; internal set; }

        public IDictionary<int, VolleyballSet> SetsOfTheMatch { get; internal set; }
    }
}
