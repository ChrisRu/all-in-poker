namespace AllInPoker.Popups
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Create User PopUp to add a new User
    /// </summary>
    public partial class CreateUserPopup : Form
    {
        /// <summary>
        /// Initialize CreateUserComponent
        /// </summary>
        public CreateUserPopup()
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

            this.rdoFemale.Checked = false;
            this.rdoMale.Checked = true;
            this.rdoProfessional.Checked = false;
            this.rdoSpeler.Checked = true;
        }

        /// <summary>
        /// Submit data
        /// </summary>
        /// <param name="sender">The Create User View</param>
        /// <param name="e">Event Arguments from the Create User Event</param>
        private void CreateUserButtonClick(object sender, EventArgs e)
        {
            bool male = this.rdoMale.Checked;
            string name = this.txtFirstName.Text;
            string surname = this.txtSurName.Text;
            string adress = this.txtAddress.Text;
            string city = this.txtCity.Text;
            string postal = this.txtPostalCode.Text;
            string phone = this.txtPhone.Text;
            string email = this.txtEmail.Text;
            string iban = this.txtIban.Text;
            string nationaliteit = this.txtNationality.Text;
            bool professional = this.rdoProfessional.Checked;

            this.ResetFields();
            this.Hide();

            MessageBox.Show("Speler succesvol aangemaakt!");
        }
    }
}