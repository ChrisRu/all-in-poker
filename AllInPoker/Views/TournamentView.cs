
namespace AllInPoker.Views
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using AllInPoker.Buttons;

    /// <summary>
    /// Single Tournament View with players, tables, etc.
    /// </summary>
    public partial class TournamentView : Form
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
        public TournamentView(string id)
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

            this.lstPlayer.Columns.Add("Name");
            foreach (string player in this.Players)
            {
                this.lstPlayer.Items.Add(player);
            }

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

        /// <summary>
        /// Remove Selected Players
        /// </summary>
        /// <param name="sender">The ListView</param>
        /// <param name="e">Event Arguments Remove Player Button Click Event</param>
        private void RemovePlayerButtonClick(object sender, EventArgs e)
        {
            if (this.lstPlayer.SelectedItems.Count == 0)
            {
                MessageBox.Show("Geen spelers geselecteerd om te verwijderen uit het toernooi.");
                return;
            }

            int selectedCount = this.lstPlayer.SelectedItems.Count;
            string players = string.Empty;
            for (int i = selectedCount; i-- > 0;)
            {
                players += this.lstPlayer.SelectedItems[i].Text;
                
                if (i == 1)
                {
                    players += " en ";
                }
                else if (i > 1)
                {
                    players += ", ";
                }

                this.lstPlayer.Items.Remove(this.lstPlayer.SelectedItems[i]);
            }

            if (selectedCount <= 1)
            {
                MessageBox.Show(players + " is verwijderd uit het toernooi.");
            }
            else
            {
                MessageBox.Show(players + " zijn verwijderd uit het toernooi.");
            }       
        }
    }
}
