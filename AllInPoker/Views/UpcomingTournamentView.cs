namespace AllInPoker.Views
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using AllInPoker.Models;

    /// <summary>
    /// Single Tournament View with players, tables, etc.
    /// </summary>
    public partial class UpcomingTournamentView : Form
    {
        private TournamentModel Tournament { get; set; }

        /// <summary>
        /// Initialize TournamentView
        /// </summary>
        /// <param name="id">MySQL Tournament ID</param>
        public UpcomingTournamentView(TournamentModel tournament)
        {
            this.Tournament = tournament;

            // TODO: Add tables and user view to GUI

            // Initialize View Components
            this.InitializeComponent();
            this.Text = "All In Poker - Toernooi " + this.Location;
            this.txtTitle.Text = "Toernooi " + this.Location;
            this.datePicker.Value = this.Tournament.Date;

            this.lstTournamentPlayers.Columns.Add("Name");
            this.lstAllPlayers.Columns.Add("Name");
            this.ReloadPlayers();
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
                // this.AllPlayers.Remove(item.Text);
                // this.Players.Add(item.Text);
            }

            this.UnselectAll();
        }

        /// <summary>
        /// Move Items from all players to tournament players
        /// </summary>
        private void BtnShiftLeftClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lstAllPlayers.SelectedItems)
            {
                this.lstAllPlayers.Items.Remove(item);
                this.lstTournamentPlayers.Items.Add(item);
                // this.AllPlayers.Add(item.Text);
                // this.Players.Remove(item.Text);
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

        /// <summary>
        /// Reload all lists with current players
        /// </summary>
        private void ReloadPlayers()
        {
            this.lstTournamentPlayers.Clear();
            this.lstAllPlayers.Clear();
            /*
            foreach (string player in this.Players)
            {
                this.lstTournamentPlayers.Items.Add(player);
            }
            
            foreach (string player in this.AllPlayers)
            {
                this.lstAllPlayers.Items.Add(player);
            }*/
        }

        /// <summary>
        /// Search Player in list and remove items that are not in text
        /// </summary>
        /// <param name="list">List containing items</param>
        /// <param name="text">Text to search in list items</param>
        private void SearchPlayer(ListView list, string text)
        {
            text = text.ToLower();

            if (text == string.Empty)
            {
                this.ReloadPlayers();

                return;
            }

            for (int i = list.Items.Count; i-- > 0;)
            {
                ListViewItem item = list.Items[i];
                if (!item.Text.ToLower().Contains(text))
                {
                    list.Items.Remove(item);
                }
            }

            if (list.Items.Count == 1)
            {
                list.Items[0].Selected = true;
            }
        }

        /// <summary>
        /// Fire search method for search tournament players textbox
        /// </summary>
        private void txtSearchTournamentPlayersTextChanged(object sender, EventArgs e)
            => this.SearchPlayer(this.lstTournamentPlayers, this.txtSearchTournamentPlayers.Text);

        /// <summary>
        /// Fire search method for search all players textbox
        /// </summary>
        private void txtSearchAllPlayersTextChanged(object sender, EventArgs e)
            => this.SearchPlayer(this.lstAllPlayers, this.txtSearchAllPlayers.Text);
    }
}