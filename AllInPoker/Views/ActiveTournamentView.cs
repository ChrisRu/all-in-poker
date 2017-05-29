namespace AllInPoker.Views
{
    using AllInPoker.Buttons;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Single Tournament View with players, tables, etc.
    /// </summary>
    public partial class ActiveTournamentView : Form
    {
        private string TournamentId { get; set; }

        private new string Location { get; set; }
        private List<string> Players { get; set; }
        private int TableCount { get; set; }
        private string Date { get; set; }

        /// <summary>
        /// Initialize TournamentView
        /// </summary>
        /// <param name="id">MySQL Tournament ID</param>
        public ActiveTournamentView(string id)
        {
            this.TournamentId = id;

            // TODO: Add tables and user view to GUI

            // Temporary variables
            this.Location = id;
            this.Players = new List<string> { "Henk", "Aard", "Erik", "Joop", "Bob", "Marie" };
            this.Date = "15/04/2017";
            this.TableCount = 4;

            // Initialize View Components
            this.InitializeComponent();
            this.Text = "All In Poker - Toernooi " + this.Location;
            this.lblTitle.Text = "Toernooi " + this.Location;
            this.lblDate.Text = this.Date;
            for (int i = 0; i < this.TableCount; i++)
            {
                this.pnlTable.Controls.Add(new PokerTableButton());
            }
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