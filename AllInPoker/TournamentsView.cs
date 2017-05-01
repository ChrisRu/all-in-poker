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

        /// <summary>
        /// Initialize TournamentsView
        /// </summary>
        public TournamentsView()
        {
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

            foreach (string tournament in this.ActiveTournaments)
            {
                this.activeTournamentsPanel.Controls?.Add(new TournamentButton
                {
                    Location = tournament,
                    PlayerCount = 16,
                    Date = "02/05/17"
                });
            }

            foreach (string tournament in this.UpcomingTournaments)
            {
                this.upcomingTournamentsPanel.Controls?.Add(new TournamentButton
                {
                    Location = tournament,
                    PlayerCount = 12,
                    Date = "18/11/17"
                });
            }
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
