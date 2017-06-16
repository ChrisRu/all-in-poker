namespace AllInPoker.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using AllInPoker.Controllers;
    using AllInPoker.Models;

    /// <summary>
    /// Single Tournament View with players, tables, etc.
    /// </summary>
    public partial class UpcomingTournamentView : Form
    {
        private TournamentModel Tournament { get; set; }

        private List<PlayerModel> TournamentPlayers { get; set; }

        private List<PlayerModel> AllPlayers { get; set; }

        private List<PlayerModel> tempTournamentPlayers { get; set; }

        private List<PlayerModel> tempAllPlayers { get; set; }

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
            this.Text = "All In Poker - Toernooi " + this.Tournament.Location.City;
            this.txtTitle.Text = this.Tournament.Location.City;
            this.datePicker.Value = this.Tournament.Date;

            this.TournamentPlayers = new List<PlayerModel>();
            this.AllPlayers = new List<PlayerModel>();

            this.lstTournamentPlayers.Columns.Add("Name");
            this.lstAllPlayers.Columns.Add("Name");
            this.ReloadPlayers(true);
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

                PlayerModel player = this.tempTournamentPlayers.Find(tournamentPlayer => tournamentPlayer.GetFullName() == item.Text);

                this.tempAllPlayers.Add(player);
                this.tempTournamentPlayers.Remove(player);
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

                PlayerModel player = this.tempAllPlayers.Find(allPlayer => allPlayer.GetFullName() == item.Text);

                this.tempTournamentPlayers.Add(player);
                this.tempAllPlayers.Remove(player);
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
        private void ReloadPlayers(bool completeReload = false)
        {
            this.lstTournamentPlayers.Clear();
            this.lstAllPlayers.Clear();

            this.TournamentPlayers = new List<PlayerModel>();
            foreach (TournamentEntryModel entry in this.Tournament.Entries)
            {
                this.TournamentPlayers.Add(entry.Player);
            }
            this.AllPlayers = new PlayerController().GetPlayers()
                .Where(player => !this.TournamentPlayers.Select(i => i.Id).Contains(player.Id)).ToList();

            if (completeReload)
            {
                this.tempAllPlayers = this.AllPlayers;
                this.tempTournamentPlayers = this.TournamentPlayers;
            }

            foreach (PlayerModel player in this.tempTournamentPlayers)
            {
                this.lstTournamentPlayers.Items.Add(player.GetFullName());
            }
            foreach (PlayerModel player in this.tempAllPlayers)
            {
                this.lstAllPlayers.Items.Add(player.GetFullName());
            }
        }

        /// <summary>
        /// Search Player in list and remove items that are not in text
        /// </summary>
        /// <param name="list">List containing items</param>
        /// <param name="text">Text to search in list items</param>
        private void SearchPlayer(ListView list, string text)
        {
            text = text.ToLower();

            if (text.Equals(string.Empty))
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

        private void saveTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentController tournamentController = new TournamentController();

            List<int> addchanges = this.tempTournamentPlayers.Select(player => player.Id).Where(player => this.TournamentPlayers.Select(tplayer => tplayer.Id).Contains(player)).ToList();
            foreach (int change in addchanges)
            {
                tournamentController.AddTournamentEntry(change, this.Tournament.Id);
            }

            List<int> removechanges = this.tempAllPlayers.Select(player => player.Id).Where(player => this.AllPlayers.Select(tplayer => tplayer.Id).Contains(player)).ToList();
            foreach (int change in removechanges)
            {
                tournamentController.RemoveTournamentEntry(change, this.Tournament.Id);
            }
        }
    }
}