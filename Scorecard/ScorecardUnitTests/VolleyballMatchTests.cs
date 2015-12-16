using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scorecard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorecardUnitTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class VolleyballMatchTests
    {
        [TestMethod]
        public void MatchTest()
        {
            var m = new VolleyballMatch("Home Team","Guest Team");

            Assert.AreEqual("Home Team", m.HomeTeam);
            Assert.AreEqual("Guest Team", m.GuestTeam);
        }
    }
}
