using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    public class VolleyballSet
    {
        public Teams CurrentlyServingTeam;

        public int HomePoints { get; internal set; }
        public int GuestPoints { get; internal set; }

        public TeamTimeout[] HomeTimeouts { get; internal set; }
        public TeamTimeout[] GuestTimeouts { get; internal set; }

        public PlayerExchange[] HomeExchanges { get; internal set; }
        public PlayerExchange[] GuestExchanges { get; internal set; }

        public Player[] HomeLineup { get; internal set; }
        public Player[] GuestLineup { get; internal set; }
    }
}
