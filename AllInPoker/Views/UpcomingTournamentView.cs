
namespace AllInPoker.Views
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Single Tournament View with players, tables, etc.
    /// </summary>
    public partial class UpcomingTournamentView : Form
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
        public UpcomingTournamentView(string id)
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

            this.lstTournamentPlayers.Columns.Add("Name");
            foreach (string player in this.Players)
            {
                this.lstTournamentPlayers.Items.Add(player);
                this.lstAllPlayers.Items.Add(player + "_");
            }
        }

        /// <summary>
        /// Get the data about the tournament from the database
        /// </summary>
        private void GetData()
        {
            // TODO: MySQL Request here
        }

        /// <summary>
        /// Move Items from tournament players to all players
        /// </summary>
        private void btnShiftRight_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lstTournamentPlayers.SelectedItems)
            {
                this.lstTournamentPlayers.Items.Remove(item);
                this.lstAllPlayers.Items.Add(item);
            }
            this.UnselectAll();
        }

        /// <summary>
        /// Move Items from all players to tournament players
        /// </summary>
        private void btnShiftLeft_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lstAllPlayers.SelectedItems)
            {
                this.lstAllPlayers.Items.Remove(item);
                this.lstTournamentPlayers.Items.Add(item);
            }
            this.UnselectAll();
        }

        /// <summary>
        /// Unselect all ListView items
        /// </summary>
        private void UnselectAll()
        {
            this.lstTournamentPlayers.SelectedIndices.Clear();
            this.lstAllPlayers.SelectedIndices.Clear();
        }
    }
}
