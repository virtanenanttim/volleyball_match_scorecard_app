using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    internal class VolleyballSet
    {
        public int HomePoints { get; set; }
        public int GuestPoints { get; set; }

        public TeamTimeout[] HomeTimeouts { get; set; }
        public TeamTimeout[] GuestTimeouts { get; set; }

        public PlayerExchange[] HomeExchanges { get; set; }
        public PlayerExchange[] GuestExchanges { get; set; }

        public Player[] HomeLineup { get; set; }
        public Player[] GuestLineup { get; set; }
    }
}
