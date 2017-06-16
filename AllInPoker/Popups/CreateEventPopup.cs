namespace AllInPoker.Popups
{
    using AllInPoker.Controllers;
    using AllInPoker.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public delegate void UpdateEvent();

    /// <summary>
    /// Create Tournament PopUp to create a new Tournament
    /// </summary>
    public partial class CreateEventPopup : Form
    {
        public static event UpdateEvent UpdateEvent;

        private List<EventLocationModel> Locations { get; set; }

        /// <summary>
        /// Initialize CreateEventPopup
        /// </summary>
        public CreateEventPopup()
        {
            this.InitializeComponent();

            this.Locations = new EventLocationController().GetEventLocations();

            this.cmbLocation.DisplayMember = "Text";
            this.cmbLocation.ValueMember = "Value";

            foreach (EventLocationModel location in this.Locations)
            {
                this.cmbLocation.Items.Add(
                    new
                    {
                        Text = location.City + ", " + location.Street + " " + location.HouseNumber,
                        Value = location.Id
                    });
            }
        }

        /// <summary>
        /// Override default close, to hide, so data can be recovered on accidental close
        /// </summary>
        /// <param name="e">Form Close Event Arguments</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        /// <summary>
        /// Clear all text from the form
        /// </summary>
        private void ResetFields()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
        }

        /// <summary>
        /// Submit data
        /// </summary>
        /// <param name="sender">The Create Tournament View</param>
        /// <param name="e">Event Arguments from the Create Tournament Event</param>
        private void CreateTournamentButtonClick(object sender, EventArgs e)
        {
            bool success = false;

            DateTime date = this.datePicker.Value;
            decimal cost = 0;
            try
            {
                cost = decimal.Parse(this.txtCost.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Geen valide prijs voor het toernooi");
                Console.WriteLine("Not a valid cost", exception.Message);
                success = false;
            }
            int locationId = this.Locations.ElementAt(this.cmbLocation.SelectedIndex).Id;

            int minAge = (int)this.numMinAge.Value;
            int maxAge = (int)this.numMaxAge.Value;
            int minPlayers = (int)this.numMinPlayers.Value;

            success = new TournamentController().CreateTournament(new TournamentModel
            {
                Date = date,
                Time = date,
                Cost = cost,
                MinPlayers = minPlayers,
                MinAge = minAge,
                MaxAge = maxAge,
                LocationId = locationId
            });
            if (success)
            {
                UpdateEvent?.Invoke();
                this.ResetFields();
                this.Hide();
            }
        }
    }
}