
namespace AllInPoker.Views
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Single Tournament View with players, tables, etc.
    /// </summary>
    public partial class UpcomingTournamentView : Form
    {
        private string TournamentId { get; set; }

        private new string Location { get; set; }
        private List<string> Players { get; set; }
        private List<string> FilteredPlayers { get; set; }
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
            this.FilteredPlayers = this.Players;
            this.Date = "2017-04-11";
            this.TableCount = 4;

            // Initialize View Components
            this.InitializeComponent();
            this.Text = "All In Poker - Toernooi " + this.Location;
            this.txtTitle.Text = "Toernooi " + this.Location;
            this.datePicker.Value = DateTime.Parse(this.Date);

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
        private void BtnShiftRightClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lstTournamentPlayers.SelectedItems)
            {
                this.lstTournamentPlayers.Items.Remove(item);
                this.lstAllPlayers.Items.Add(item);
                this.Players.Add(item.Text);
            }
            this.UnselectAll();
        }

        /// <summary>
        /// Move Items from all players to tournament players
        /// </summary>
        private void BtnShiftLeftClick(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.lstAllPlayers.SelectedItems)
            {
                this.lstAllPlayers.Items.Remove(item);
                this.lstTournamentPlayers.Items.Add(item);
                this.Players.Remove(item.Text);
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

        private void txtSearchPlayerTextChanged(object sender, EventArgs e)
        {
            if (this.txtSearchPlayer.Text == string.Empty)
            {
                // Un highlight items
                foreach (ListViewItem item in this.lstAllPlayers.Items)
                {
                    this.lstAllPlayers.Items.Clear();
                }

                // Re add all players
                foreach (string player in this.Players)
                {
                    this.lstAllPlayers.Items.Add(player + "_");
                }

                return;
            }

            for (int i = this.lstAllPlayers.Items.Count; i-- > 0;)
            {
                ListViewItem item = this.lstAllPlayers.Items[i];
                if (!item.Text.ToLower().Contains(this.txtSearchPlayer.Text.ToLower()))
                {
                    this.lstAllPlayers.Items.Remove(item);
                }
            }

            if (this.lstAllPlayers.Items.Count == 1)
            {
                this.lstAllPlayers.Focus();
                this.lstAllPlayers.Items[0].Selected = true;
            }
        }
    }
}
