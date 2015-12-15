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
    public class TeamTests
    {
        [TestMethod]
        public void TeamTest()
        {
            Team t = new Team("Test Team", "TeTe");

            Assert.AreEqual("Test Team", t.Name);
            Assert.AreEqual("TeTe", t.Abbreviation);
        }

        [TestMethod]
        public void TeamRosterTest()
        {
            Team t = new Team("Test Team", "TeTe");
            t.SetCoach("Coach Coacher");
            t.SetAssistantCoach("ACoach ACoacher");
            t.SetPlayers(new[]
            {
                new Player("1st", "ln1", 1),
                new Player("2nd", "ln2", 2),
                new Player("3rd", "ln3", 3),
                new Player("4th", "ln4", 4),
                new Player("5th", "ln5", 5),
                new Player("6th", "ln6", 6),
                new Player("7th", "ln7", 7),
                new Player("8th", "ln8", 8),
                new Player("9th", "ln9", 9),
                new Player("10th", "ln10", 10),
                new Player("11th", "ln11", 11),
                new Player("12th", "ln12", 12),
        });

            Assert.AreEqual("Coach Coacher", t.Coach);
            Assert.AreEqual("ACoach ACoacher", t.AssistantCoach);

            Assert.AreEqual(12, t.Players.Count);

        }


    }
}
