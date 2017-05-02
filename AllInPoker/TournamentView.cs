using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AllInPoker
{
    using System.Runtime.CompilerServices;

    public partial class TournamentView : Form
    {
        private string TournamentId { get; set; }

        private new string Location { get; set; }
        private List<string> Players { get; set; }
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
            this.Players = new List<string>
            {
                "Henk", "Aard", "Erik", "Joop", "Bob", "Marie"                     
            };
            this.TableCount = 4;

            // Initialize View Components
            this.InitializeComponent();
            this.Text = "All In Poker - Toernooi " + this.Location;
            this.title.Text = "Toernooi " + this.Location;

            this.playerListBox.Columns.Add("Name");
            foreach (string player in this.Players)
            {
                this.playerListBox.Items.Add(player);
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
        /// <param name="sender">ListView</param>
        /// <param name="e">Event Arguments Remove Player Button Click Event</param>
        private void RemovePlayerButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.playerListBox.SelectedItems)
            {
                MessageBox.Show(item.Text);
            }
        }
    }
}
