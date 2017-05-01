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

        public readonly int buttonMargin;

        /// <summary>
        /// Initialize TournamentsView
        /// </summary>
        public TournamentsView()
        {
            this.buttonMargin = 10;
            this.InitializeComponent();
            this.CreateTournamentView = new CreateTournamentView();

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
                var button = new TournamentButton
                {
                    LocatieText = this.ActiveTournaments[i],
                    PlayerCountText = "16",
                    DatumText = "01/05/17"
                };
                button.Location = new Point(i * (button.Width + this.buttonMargin), 0);
                this.activeTournamentsPanel.Controls?.Add(button);
            }

            for (int i = 0; i < this.UpcomingTournaments.Count; i++)
            {
                var button = new TournamentButton
                {
                     LocatieText = this.ActiveTournaments[i],
                     PlayerCountText = "12",
                     DatumText = "22/01/18"
                };
                button.Location = new Point(i * (button.Width + this.buttonMargin), 0);
                this.upcomingTournamentsPanel.Controls?.Add(button);
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
    }
}
