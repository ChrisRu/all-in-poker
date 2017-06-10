namespace AllInPokerTesting
{
    using AllInPoker.Buttons;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Windows.Forms;

    [TestClass]
    public class ButtonTest
    {
        [TestMethod]
        public void TestMasterclassButton()
        {
            var form = new Form();
            var button = new MasterclassButton();
            form.Controls.Add(button);
        }

        [TestMethod]
        public void TestPokerTableButton()
        {
            var form = new Form();
            var button = new PokerTableButton();
            form.Controls.Add(button);
        }

        [TestMethod]
        public void TestTournamentButton()
        {
            var form = new Form();
            var button = new TournamentButton();
            form.Controls.Add(button);
        }
    }
}