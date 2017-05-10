﻿
namespace AllInPoker
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using AllInPoker.Tournament;

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
            this.titleLabel.Text = "Toernooi " + this.Location;
            this.dateLabel.Text = this.Date;

            this.playerListBox.Columns.Add("Name");
            foreach (string player in this.Players)
            {
                this.playerListBox.Items.Add(player);
            }

            for (int i = 0; i < this.TableCount; i++)
            {
                this.tablePanel.Controls.Add(new TournamentViewTableButton());
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
            if (this.playerListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Geen spelers geselecteerd om te verwijderen uit het toernooi.");
                return;
            }

            foreach (ListViewItem item in this.playerListBox.SelectedItems)
            {
                this.playerListBox.Items.Remove(item);
                MessageBox.Show(item.Text + " is verwijderd uit het toernooi.");
            }
        }
    }
}