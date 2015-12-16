﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scorecard;

namespace PublicScorecardInterfaceTests
{
    [TestClass]
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


            filler.SetTeams("Home Team", "HoTe", "HoT C", "", "", homePlayers, "Guest Team", "GuTe", "GuT C", "", "", guestPlayers);
            filler.SetHomeTeamCaptain(1);
            filler.SetGuestTeamCaptain(5);

            Assert.AreEqual("Home Team", filler.VolleyballMatch.HomeTeam.Name);
            Assert.AreEqual("GuTe", filler.VolleyballMatch.GuestTeam.Abbreviation);


            filler.SetHomeLineup(1, filler.VolleyballMatch.HomeTeam.Players[0], filler.VolleyballMatch.HomeTeam.Players[1], filler.VolleyballMatch.HomeTeam.Players[2], filler.VolleyballMatch.HomeTeam.Players[3], filler.VolleyballMatch.HomeTeam.Players[4], filler.VolleyballMatch.HomeTeam.Players[5]);

            Assert.IsTrue(filler.CheckAllPrematchActionsCompleted());

            Assert.AreEqual(1, filler.CurrentSet);
        }

        [TestMethod]
        public void PlayOneSetWithSubstitutions()
        {
            ScorecardFiller filler = new ScorecardFiller();
            Player[] homePlayers = new Player[] {new Player("SetterF", "SetterL", 1),new Player("Receiver1F", "Receiver1L",2), new Player("Receiver2F", "Receiver2L", 3),
                                                new Player ("Blocker1F", "Blocke1L", 4), new Player("Blocker2F", "Blocker2L", 5), new Player("SpikerF", "SpikerL", 6), new Player("LiberoF", "LiberoL", 7)};

            Player[] guestPlayers = new Player[] {new Player("SetterFg", "SetterLg", 1),new Player("Receiver1Fg", "Receiver1Lg",2), new Player("Receiver2Fg", "Receiver2Lg", 3),
                                                new Player ("Blocker1Fg", "Blocke1Lg", 4), new Player("Blocker2Fg", "Blocker2Lg", 5), new Player("SpikerFg", "SpikerLg", 6), new Player("LiberoFg", "LiberoLg", 7)};


            filler.SetTeams("Home Team", "HoTe", "HoT C", "", "", homePlayers, "Guest Team", "GuTe", "GuT C", "", "", guestPlayers);
            filler.SetHomeTeamCaptain(1);
            filler.SetGuestTeamCaptain(5);
            filler.SetStartingTeam(Teams.Home);
            // Start 1st set
            filler.SetHomeLineup(1, filler.VolleyballMatch.HomeTeam.Players[0], filler.VolleyballMatch.HomeTeam.Players[1], filler.VolleyballMatch.HomeTeam.Players[2], filler.VolleyballMatch.HomeTeam.Players[3], filler.VolleyballMatch.HomeTeam.Players[4], filler.VolleyballMatch.HomeTeam.Players[5]);

            //now can be either timeouts, exchanges, points or warnings/other penalties
            filler.AddPoint(Teams.Home);

            
        }
    }
}
