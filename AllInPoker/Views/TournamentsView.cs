namespace AllInPoker.Views
{
    using AllInPoker.Buttons;
    using AllInPoker.Controllers;
    using AllInPoker.Models;
    using AllInPoker.Popups;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Main OverView of all active tournaments
    /// </summary>
    public partial class TournamentsView : Form
    {
        public CreateEventPopup CreateTournamentView { get; set; }

        public CreateUserPopup CreateUserView { get; set; }

        public CreateLocationPopup CreateLocationView { get; set; }

        /// <summary>
        /// Initialize TournamentsView
        /// </summary>
        public TournamentsView()
        {
            this.InitializeComponent();

            this.CreateTournamentView = new CreateEventPopup();
            this.CreateUserView = new CreateUserPopup();
            this.CreateLocationView = new CreateLocationPopup();

            UpcomingTournamentView.UpdateTournament += this.ReloadData;
            CreateEventPopup.UpdateEvent += this.ReloadData;
            CreateUserPopup.UpdateUser += this.ReloadData;

            this.ReloadData();
        }

        /// <summary>
        /// On New Tournament Button click, show Create Tournament View
        /// </summary>
        /// <param name="sender">The Tournaments View</param>
        /// <param name="e">Event Arguments for the New Tournament Event</param>
        private void NewEventButtonClick(object sender, System.EventArgs e)
        {
            this.CreateTournamentView.ShowDialog();
        }

        /// <summary>
        /// On New User Button click, show Create User View
        /// </summary>
        /// <param name="sender">The Tournaments View</param>
        /// <param name="e">Event Arguments for the New User Event</param>
        private void NewUserButtonClick(object sender, System.EventArgs e)
        {
            this.CreateUserView.ShowDialog();
        }

        private void ReloadData()
        {
            TournamentController tournamentController = new TournamentController();
            List<TournamentModel> tournaments = tournamentController.GetTournaments();
            MasterclassController masterclassController = new MasterclassController();
            List<MasterclassModel> masterclasses = masterclassController.GetMasterclasses();
            PlayerController playerController = new PlayerController();
            List<PlayerModel> players = playerController.GetPlayers();

            this.pnlTournaments.Controls.Clear();

            for (int i = 0; i < tournaments.Count; i++)
            {
                TournamentButton button =
                    new TournamentButton { Tournament = tournaments[i], Location = new Point(i * 150, 0) };

                // If tournament has finished
                if (tournaments[i].Date < DateTime.Now)
                {
                    button.BackColor = Color.FromArgb(240, 240, 240);
                    button.ForeColor = Color.Gray;
                }

                // If tournament is coming up
                if (tournaments[i].Date.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    button.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
                }

                this.pnlTournaments.Controls?.Add(button);
            }

            this.pnlMasterclasses.Controls.Clear();

            for (int i = 0; i < masterclasses.Count; i++)
            {
                MasterclassButton button =
                    new MasterclassButton { Masterclass = masterclasses[i], Location = new Point(i * 260, 0) };

                // If tournament has finished
                if (masterclasses[i].Date < DateTime.Now)
                {
                    button.BackColor = Color.FromArgb(240, 240, 240);
                    button.ForeColor = Color.Gray;
                }

                // If tournament is coming up
                if (masterclasses[i].Date == DateTime.Now)
                {
                    button.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
                }

                this.pnlMasterclasses.Controls?.Add(button);
            }

            this.dgPlayers.DataSource = players.OrderBy(player => player.FirstName).ToList();
            this.dgPlayers.Columns[7].Visible = false;
            this.dgPlayers.Columns[8].DisplayIndex = 0;
            this.dgPlayers.Columns[9].DisplayIndex = 1;
            this.dgPlayers.Columns[10].DisplayIndex = 2;
            this.dgPlayers.Columns[11].DisplayIndex = 3;
        }

        private void newLocationButton_Click(object sender, EventArgs e)
        {
            this.CreateLocationView.ShowDialog();
        }
    }
}