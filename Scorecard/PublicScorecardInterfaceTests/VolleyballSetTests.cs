using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scorecard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicScorecardInterfaceTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class VolleyballSetTests
    {
        [TestMethod]
        public void CreateNewSet()
        {
            VolleyballSet set = new VolleyballSet(1);
            
            Assert.AreEqual(1, set.SetNumber);
            Assert.AreEqual(0, set.HomePoints);
            Assert.AreEqual(0, set.GuestPoints);
            Assert.IsFalse(set.HasEnded());

            Assert.AreEqual(25, set.TargetPoints);
        }

        [TestMethod]
        public void CreateFifthSet()
        {
            VolleyballSet fifthSet = new VolleyballSet(5, 15);

            Assert.AreEqual(5, fifthSet.SetNumber);
            Assert.AreEqual(0, fifthSet.HomePoints);
            Assert.AreEqual(0, fifthSet.GuestPoints);
            Assert.IsFalse(fifthSet.HasEnded());

            Assert.AreEqual(15, fifthSet.TargetPoints);
        }

        [TestMethod]
        public void ScorePointsTest()
        {
            VolleyballSet set = new VolleyballSet(1);

            Assert.AreEqual(0, set.HomePoints);
            set.ScorePoint(Team.Home);
            Assert.AreEqual(1, set.HomePoints);
            for (int i = 1; i <= 24; i++)
            {
                set.ScorePoint(Team.Guest);
                Assert.AreEqual(i, set.GuestPoints);
            }

            Assert.AreEqual(1, set.HomePoints);
            Assert.AreEqual(24, set.GuestPoints);
            Assert.IsFalse(set.HasEnded());
            Assert.AreEqual(Team.NotDefined, set.Winner());
        }

        [TestMethod]
        public void TeamWinsSet()
        {
            VolleyballSet set = new VolleyballSet(1);
            for (int i = 1; i <= 25; i++)
            {
                set.ScorePoint(Team.Guest);
            }

            Assert.IsTrue(set.HasEnded());
            Assert.AreEqual(0, set.HomePoints);
            Assert.AreEqual(25, set.GuestPoints);
            Assert.AreEqual(Team.Guest, set.Winner());
        }

        [TestMethod]
        public void TeamWinsFifthSet()
        {
            VolleyballSet set = new VolleyballSet(5, 15);
            for (int i = 1; i <= 15; i++)
            {
                set.ScorePoint(Team.Home);
            }

            Assert.IsTrue(set.HasEnded());
            Assert.AreEqual(15, set.HomePoints);
            Assert.AreEqual(0, set.GuestPoints);

            Assert.AreEqual(Team.Home, set.Winner());
        }

        [TestMethod]
        public void TeamWinsSetAt40Points()
        {
            VolleyballSet set = new VolleyballSet(1);
            for (int i = 1; i <= 38; i++)
            {
                set.ScorePoint(Team.Home);
                set.ScorePoint(Team.Guest);
                Assert.AreEqual(i, set.HomePoints);
                Assert.AreEqual(i, set.GuestPoints);
                Assert.IsFalse(set.HasEnded(), "Ended at " + String.Format("{0}:{1}", set.HomePoints, set.GuestPoints));
            }

            set.ScorePoint(Team.Guest);
            Assert.AreEqual(38, set.HomePoints);
            Assert.AreEqual(39, set.GuestPoints);
            Assert.IsFalse(set.HasEnded());
            set.ScorePoint(Team.Guest);
            Assert.AreEqual(38, set.HomePoints);
            Assert.AreEqual(40, set.GuestPoints);
            Assert.IsTrue(set.HasEnded());
        }

        [TestMethod]
        public void TeamWinsFifthSetAt20Points()
        {
            VolleyballSet set = new VolleyballSet(5, 15);
            for (int i = 1; i <= 18; i++)
            {
                set.ScorePoint(Team.Home);
                set.ScorePoint(Team.Guest);
                Assert.AreEqual(i, set.HomePoints);
                Assert.AreEqual(i, set.GuestPoints);
                Assert.IsFalse(set.HasEnded(), "Ended at " + String.Format("{0}:{1}", set.HomePoints, set.GuestPoints));
            }

            set.ScorePoint(Team.Home);
            Assert.AreEqual(18, set.GuestPoints);
            Assert.AreEqual(19, set.HomePoints);
            Assert.AreEqual(Team.NotDefined, set.Winner());
            Assert.IsFalse(set.HasEnded());
            set.ScorePoint(Team.Home);
            Assert.AreEqual(20, set.HomePoints);
            Assert.AreEqual(18, set.GuestPoints);
            Assert.IsTrue(set.HasEnded());
            Assert.AreEqual(Team.Home, set.Winner());
        }

        [TestMethod]
        public void ServingTeamCheck()
        {
            VolleyballSet set = new VolleyballSet(1);

            Assert.AreEqual(Team.NotDefined, set.CurrentlyServingTeam);

            set.StartingTeam(Team.Home);

            set.ScorePoint(Team.Home);
            set.ScorePoint(Team.Home);

            Assert.AreEqual(Team.Home, set.CurrentlyServingTeam);

            set.ScorePoint(Team.Guest);
            Assert.AreEqual(Team.Guest, set.CurrentlyServingTeam);

            set.ScorePoint(Team.Home);
            
            Assert.AreEqual(Team.Home, set.CurrentlyServingTeam);

        }
    }
}
