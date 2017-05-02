using System;
using System.Windows.Forms;

namespace AllInPoker
{
    public partial class CreateUserView : Form
    {
        /// <summary>
        /// Initialize CreateTournamentComponent
        /// </summary>
        public CreateUserView()
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
            this.femaleRadioButton.Checked = false;
            this.maleRadioButton.Checked = true;
            this.nameTextBox.ResetText();
            this.surnameTextBox.ResetText();
            this.adressTextBox.ResetText();
            this.cityTextBox.ResetText();
            this.postalTextBox.ResetText();
            this.phoneTextBox.ResetText();
            this.emailTextBox.ResetText();
            this.ibanTextBox.ResetText();
        }

        /// <summary>
        /// Submit data
        /// </summary>
        /// <param name="sender">The Create User View</param>
        /// <param name="e">Event Arguments from the Create User Event</param>
        private void CreateUserButtonClick(object sender, EventArgs e)
        {
            bool male = this.maleRadioButton.Checked;
            string name = this.nameTextBox.Text;
            string surname = this.surnameTextBox.Text;
            string adress = this.adressTextBox.Text;
            string city = this.cityTextBox.Text;
            string postal = this.postalTextBox.Text;
            string phone = this.phoneTextBox.Text;
            string email = this.emailTextBox.Text;
            string iban = this.ibanTextBox.Text;

            this.ResetFields();
            this.Hide();

            MessageBox.Show("Speler succesvol aangemaakt!");
        }
    }
}
