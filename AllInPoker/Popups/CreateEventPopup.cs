namespace AllInPoker.Popups
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Create Tournament PopUp to create a new Tournament
    /// </summary>
    public partial class CreateEventPopup : Form
    {
        /// <summary>
        /// Initialize CreateTournamentComponent
        /// </summary>
        public CreateEventPopup()
        {
            this.InitializeComponent();
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
            string date = this.datePicker.Text;
            string city = this.txtCity.Text;
            string address = this.txtAdress.Text;
            string cost = this.txtCost.Text;

            decimal minAge = this.numMinAge.Value;
            decimal maxAge = this.numMaxAge.Value;
            decimal minPlayers = this.numMinPlayers.Value;
            decimal maxPlayers = this.numMaxPlayers.Value;

            bool isTournament = this.rdoToernooi.Checked;

            this.ResetFields();
            this.Hide();

            MessageBox.Show("Toernooi succesvol aangemaakt!");
        }
    }
}