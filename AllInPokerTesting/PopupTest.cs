namespace AllInPokerTesting
{
    using AllInPoker.Popups;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PopupTest
    {
        [TestMethod]
        public void TestCreateEventPopup()
        {
            new CreateEventPopup();
        }

        [TestMethod]
        public void TestCreateUserPopup()
        {
            new CreateUserPopup();
        }
    }
}