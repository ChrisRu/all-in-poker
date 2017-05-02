using System;
using System.Windows.Forms;

namespace AllInPoker
{
    public partial class TournamentView : Form
    {
        private string tournamentId { get; set; }

        private new string Location { get; set; }
        private int PlayerCount { get; set; }
        private int TableCount { get; set; }

        /// <summary>
        /// Initialize TournamentView
        /// </summary>
        /// <param name="id">MySQL Tournament ID</param>
        public TournamentView(string id)
        {
            this.tournamentId = id;

            // Temporary variables
            this.Location = this.tournamentId;
            this.PlayerCount = 16;
            this.TableCount = this.PlayerCount / 8;

            // Initialize View Components
            this.InitializeComponent();
            this.Text = "All In Poker - Toernooi " + this.Location;
            this.title.Text = "Toernooi " + this.Location;
        }
    }
}
