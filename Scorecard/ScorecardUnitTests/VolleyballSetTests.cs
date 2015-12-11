using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scorecard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorecardUnitTests
{
    [TestClass]
    class VolleyballSetTests
    {
        [TestMethod]
        public void CreateVolleyballSet()
        {
            var s = new VolleyballSet();
            List<Player> homePlayers = new List<Player>();
            homePlayers.Add(new Player("1st", "ln1", 1));
            homePlayers.Add(new Player("2nd", "ln2", 2));
            homePlayers.Add(new Player("3rd", "ln3", 3));
            homePlayers.Add(new Player("4th", "ln4", 4));
            homePlayers.Add(new Player("5th", "ln5", 5));
            homePlayers.Add(new Player("6th", "ln6", 6));
            s.HomeStartingLineup = homePlayers.ToArray();


        }
    }
}
