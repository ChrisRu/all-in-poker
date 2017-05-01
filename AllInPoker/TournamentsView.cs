using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AllInPoker
{
    public partial class TournamentsView : Form
    {
        public List<string> ActiveTournaments { get; set; }
        public List<string> UpcomingTournaments { get; set; }

        public CreateTournamentView CreateTournamentView { get; set; }
        public CreateUserView CreateUserView { get; set; }

        private readonly int _buttonMargin;

        /// <summary>
        /// Initialize TournamentsView
        /// </summary>
        public TournamentsView()
        {
            this._buttonMargin = 10;
            this.InitializeComponent();
            this.CreateTournamentView = new CreateTournamentView();
            this.CreateUserView = new CreateUserView();

            this.ActiveTournaments = new List<string>
            {
                "Pijnacker",
                "Zoetermeer",
                "Rijswijk",
                "Amsterdorp"
            };

            this.UpcomingTournaments = new List<string>
            {
                "Rotterdam",
                "Den Haag",
                "Gouda"
            };

            for (int i = 0; i < this.ActiveTournaments.Count; i++)
            {
                this.activeTournamentsPanel.Controls?.Add(this.GetTournamentButton(i, this.ActiveTournaments[i], 16, "01/05/17"));
            }

            for (int i = 0; i < this.UpcomingTournaments.Count; i++)
            {
                this.upcomingTournamentsPanel.Controls?.Add(this.GetTournamentButton(i, this.ActiveTournaments[i], 12, "22/01/18"));
            }
        }

        /// <summary>
        /// Get New Tournament Button
        /// </summary>
        /// <param name="index">Number location in list</param>
        /// <param name="location">Location of tournament</param>
        /// <param name="playerCount">Player Count of tournament</param>
        /// <param name="date">Dat of tournament</param>
        /// <returns>New Custom TournamentButton</returns>
        private TournamentButton GetTournamentButton(int index, string location, int playerCount, string date)
        {
            var button = new TournamentButton
            {
                LocatieText = location,
                PlayerCountText = playerCount.ToString(),
                DatumText = date
            };
            button.Location = new Point(index * (button.Width + this._buttonMargin), 0);
            return button;
        }

        /// <summary>
        /// On New Tournament Button click, show Create Tournament View
        /// </summary>
        /// <param name="sender">The Tournaments View</param>
        /// <param name="e">Event Arguments for the New Tournament Event</param>
        private void newTournamentButton_Click(object sender, System.EventArgs e)
        {
            this.CreateTournamentView.Show();
        }

        /// <summary>
        /// On New User Button click, show Create User View
        /// </summary>
        /// <param name="sender">The Tournaments View</param>
        /// <param name="e">Event Arguments for the New User Event</param>
        private void newUserButton_Click(object sender, System.EventArgs e)
        {
            this.CreateUserView.Show();
        }
    }
}
