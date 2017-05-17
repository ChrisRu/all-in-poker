
namespace AllInPoker.Views
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    using AllInPoker.Buttons;
    using AllInPoker.Popups;

    /// <summary>
    /// Main OverView of all active tournaments
    /// </summary>
    public partial class TournamentsView : Form
    {
        public List<string> Tournaments { get; set; }

        public CreateTournamentPopup CreateTournamentView { get; set; }
        public CreateUserPopup CreateUserView { get; set; }

        /// <summary>
        /// Initialize TournamentsView
        /// </summary>
        public TournamentsView()
        {
            this.InitializeComponent();

            this.CreateTournamentView = new CreateTournamentPopup();
            this.CreateUserView = new CreateUserPopup();

            this.Tournaments = new List<string>
            {
                "Rotterdam",
                "Pijnacker",
                "Zoetermeer",
                "Rijswijk",
                "Amsterdorp",
                "Rotterdam",
                "Pijnacker",
                "Zoetermeer",
                "Rijswijk",
                "Amsterdorp"
            };

            for (int i = 0; i < this.Tournaments.Count; i++)
            {
                string tournament = this.Tournaments[i];

                TournamentButton button = new TournamentButton
                {
                    TournamentLocation = tournament,
                    TournamentPlayerCount = 16,
                    TournamentDate = "02/05/17",
                    Location = new Point(i * 150, 0)
                };

                // If tournament has finished
                if (tournament.Contains("Pijn"))
                {
                    button.BackColor = Color.FromArgb(240, 240, 240);
                    button.ForeColor = Color.Gray;
                }

                // If tournament is coming up
                if (tournament.Contains("otter"))
                {
                    button.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
                }

                this.pnlTournaments.Controls?.Add(button);
            }
        }

        /// <summary>
        /// On New Tournament Button click, show Create Tournament View
        /// </summary>
        /// <param name="sender">The Tournaments View</param>
        /// <param name="e">Event Arguments for the New Tournament Event</param>
        private void NewTournamentButtonClick(object sender, System.EventArgs e)
        {
            this.CreateTournamentView.ShowDialog();
        }

        /// <summary>
        /// On New User Button click, show Create User View
        /// </summary>
        /// <param name="sender">The Tournaments View</param>
        /// <param name="e">Event Arguments for the New User Event</param>
        private void NewUserButtonClick(object sender, System.EventArgs e)
        {
            this.CreateUserView.ShowDialog();
        }
    }
}
