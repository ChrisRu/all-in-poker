using System;
using System.Windows.Forms;

namespace AllInPoker
{
    public partial class TournamentView : Form
    {
        private string TournamentId { get; set; }

        private new string Location { get; set; }
        private int PlayerCount { get; set; }
        private int TableCount { get; set; }

        /// <summary>
        /// Initialize TournamentView
        /// </summary>
        /// <param name="id">MySQL Tournament ID</param>
        public TournamentView(string id)
        {
            this.TournamentId = id;

            // TODO: Add tables and user view to GUI

            // Temporary variables
            this.Location = id;
            this.PlayerCount = 16;
            this.TableCount = this.PlayerCount / 8;

            // Initialize View Components
            this.InitializeComponent();
            this.Text = "All In Poker - Toernooi " + this.Location;
            this.title.Text = "Toernooi " + this.Location;
        }

        /// <summary>
        /// Get the data about the tournament from the database
        /// </summary>
        private void GetData()
        {
            // TODO: MySQL Request here
        }
    }
}
