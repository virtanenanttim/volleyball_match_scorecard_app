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
            var m = new VolleyballMatch(new Team("Home Team", "HoTe"), new Team("Guest Team", "GuTe"));

            Assert.AreEqual("Home Team", m.HomeTeam.Name);
            Assert.AreEqual("HoTe", m.HomeTeam.Abbreviation);
            Assert.AreEqual("Guest Team", m.GuestTeam.Name);
            Assert.AreEqual("GuTe", m.GuestTeam.Abbreviation);
        }
    }
}
