using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scorecard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicScorecardInterfaceTests
{
    [TestClass]
    public class VolleyballMatchTests
    {
        [TestMethod]
        public void MatchTest()
        {
            var m = new VolleyballMatch("Home Team", "Guest Team");

            Assert.AreEqual("Home Team", m.HomeTeam);
            Assert.AreEqual("Guest Team", m.GuestTeam);
            Assert.IsFalse(m.HasEnded());
            Assert.AreEqual(0, m.CurrentSet);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddSetToMatch()
        {
            VolleyballMatch m = new VolleyballMatch("H", "G");
            VolleyballSet set1 = m.AddNewSet();

            // Can't add new set untill the previous one is finished
            VolleyballSet set2 = m.AddNewSet();
        }

        [TestMethod]
        public void CreateMatchBestOf5()
        {
            VolleyballMatch m = new VolleyballMatch("H", "G");
            while (!m.HasEnded())
            {
                VolleyballSet set = m.AddNewSet();
                while (!set.HasEnded())
                {
                    set.ScorePoint(Team.Home);
                }

                if (m.CurrentSet > 3)
                {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(3, m.SetsWonByHomeTeam);
            Assert.AreEqual(0, m.SetsWonByGuestTeam);

        }

        [TestMethod]
        public void CreateMatchBestOf5_Ends2_3()
        {
            VolleyballMatch m = new VolleyballMatch("H", "G");

            while (!m.HasEnded())
            {
                VolleyballSet set = m.AddNewSet();
                while (!set.HasEnded())
                {
                    set.ScorePoint(Team.Home);
                }
                if (m.CurrentSet < 5)
                {
                    VolleyballSet set2 = m.AddNewSet();
                    while (!set2.HasEnded())
                    {
                        set2.ScorePoint(Team.Guest);
                    }
                }

                if (m.CurrentSet > 5)
                {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(3, m.SetsWonByHomeTeam);
            Assert.AreEqual(2, m.SetsWonByGuestTeam);
            Assert.AreEqual(25, m.SetsOfTheMatch[1].HomePoints);
            Assert.AreEqual(0, m.SetsOfTheMatch[2].HomePoints);
            Assert.AreEqual(25, m.SetsOfTheMatch[3].HomePoints);
            Assert.AreEqual(0, m.SetsOfTheMatch[4].HomePoints);
            Assert.AreEqual(15, m.SetsOfTheMatch[5].HomePoints);

            Assert.AreEqual(0, m.SetsOfTheMatch[1].GuestPoints);
            Assert.AreEqual(25, m.SetsOfTheMatch[2].GuestPoints);
            Assert.AreEqual(0, m.SetsOfTheMatch[3].GuestPoints);
            Assert.AreEqual(25, m.SetsOfTheMatch[4].GuestPoints);
            Assert.AreEqual(0, m.SetsOfTheMatch[5].GuestPoints);
        }

        [TestMethod]
        public void CreateMatchBestOf3()
        {
            VolleyballMatch m = new VolleyballMatch("H", "G", 2);

            while (!m.HasEnded())
            {
                VolleyballSet set = m.AddNewSet();
                while (!set.HasEnded())
                {
                    set.ScorePoint(Team.Home);
                }
                if (m.CurrentSet < 3)
                {
                    VolleyballSet set2 = m.AddNewSet();
                    while (!set2.HasEnded())
                    {
                        set2.ScorePoint(Team.Guest);
                    }
                }

                if (m.CurrentSet > 3)
                {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(2, m.SetsWonByHomeTeam);
            Assert.AreEqual(1, m.SetsWonByGuestTeam);
            Assert.AreEqual(25, m.SetsOfTheMatch[1].HomePoints);
            Assert.AreEqual(0, m.SetsOfTheMatch[2].HomePoints);
            Assert.AreEqual(15, m.SetsOfTheMatch[3].HomePoints);

            Assert.AreEqual(0, m.SetsOfTheMatch[1].GuestPoints);
            Assert.AreEqual(25, m.SetsOfTheMatch[2].GuestPoints);
            Assert.AreEqual(0, m.SetsOfTheMatch[3].GuestPoints);
        }
    }
}
