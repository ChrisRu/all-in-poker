﻿namespace AllInPokerTesting
{
    using AllInPoker.Views;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ViewTest
    {
        [TestMethod]
        public void TestActiveTournament()
        {
            new ActiveTournamentView("id");
        }

        [TestMethod]
        public void TestTournamentsView()
        {
            new TournamentsView();
        }

        [TestMethod]
        public void TestUpcomingTournamentView()
        {
            new UpcomingTournamentView("id");
        }
    }
}
