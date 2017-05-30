namespace AllInPokerTesting
{
    using AllInPoker.Popups;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PopupTest
    {
        [TestMethod]
        public void TestActiveTournament1()
        {
            new CreateEventPopup();
        }

        [TestMethod]
        public void TestTournamentsView()
        {
            new CreateUserPopup();
        }
    }
}
