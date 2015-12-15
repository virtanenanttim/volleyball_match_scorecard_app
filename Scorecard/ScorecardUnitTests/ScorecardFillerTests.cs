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
    public class ScorecardFillerTests
    {
        [TestMethod]
        public void SetTeamRosters()
        {
            ScorecardFiller filler = new ScorecardFiller();
            Player[] homePlayers = new Player[] {new Player("SetterF", "SetterL", 1),new Player("Receiver1F", "Receiver1L",2), new Player("Receiver2F", "Receiver2L", 3),
                                                new Player ("Blocker1F", "Blocke1L", 4), new Player("Blocker2F", "Blocker2L", 5), new Player("SpikerF", "SpikerL", 6), new Player("LiberoF", "LiberoL", 7)};

            Player[] guestPlayers = new Player[] {new Player("SetterFg", "SetterLg", 1),new Player("Receiver1Fg", "Receiver1Lg",2), new Player("Receiver2Fg", "Receiver2Lg", 3),
                                                new Player ("Blocker1Fg", "Blocke1Lg", 4), new Player("Blocker2Fg", "Blocker2Lg", 5), new Player("SpikerFg", "SpikerLg", 6), new Player("LiberoFg", "LiberoLg", 7)};


            filler.SetTeams("Home Team", "HoTe", "HoT C", "", "", homePlayers, "Guest Team", "GuTe", "GuT C", "", "", guestPlayers );
        }


    }
}
