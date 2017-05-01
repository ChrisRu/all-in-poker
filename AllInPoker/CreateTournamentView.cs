using System;
using System.Windows.Forms;

namespace AllInPoker
{
    public partial class CreateTournamentView : Form
    {
        /// <summary>
        /// Initialize CreateTournamentComponent
        /// </summary>
        public CreateTournamentView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Override default close, to hide, so data can be recovered on accidental close
        /// </summary>
        /// <param name="e"></param>
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
            this.locationTextBox.ResetText();
            this.datePicker.ResetText();
            this.descriptionTextBox.ResetText();
        }

        /// <summary>
        /// Sumit data
        /// </summary>
        /// <param name="sender">The Create Tournament View</param>
        /// <param name="e">Event Arguments from the Create Tournament Event</param>
        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            string location = this.locationTextBox.Text;
            string date = this.datePicker.Text;
            string description = this.descriptionTextBox.Text;

            this.ResetFields();
            this.Hide();

            MessageBox.Show("Toernooi succesvol aangemaakt!");
        }
    }
}
