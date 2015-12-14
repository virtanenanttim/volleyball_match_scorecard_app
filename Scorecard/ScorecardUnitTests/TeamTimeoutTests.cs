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
    public class TeamTimeoutTests
    {
        [TestMethod]
        public void TimeoutPropertiesTest()
        {
            var t = new TeamTimeout(12,24);

            Assert.AreEqual(12, t.HomePoints);
            Assert.AreEqual(24, t.GuestPoints);


        }
    }
}
