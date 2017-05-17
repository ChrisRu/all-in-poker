
namespace AllInPoker.CreateViews
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Create User PopUp to add a new User
    /// </summary>
    public partial class CreateUserView : Form
    {
        /// <summary>
        /// Initialize CreateUserComponent
        /// </summary>
        public CreateUserView()
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
            this.rdoFemale.Checked = false;
            this.rdoMale.Checked = true;
            this.txtFirstName.ResetText();
            this.txtSurName.ResetText();
            this.txtAddress.ResetText();
            this.txtCity.ResetText();
            this.txtPostalCode.ResetText();
            this.txtPhone.ResetText();
            this.txtEmail.ResetText();
            this.txtIban.ResetText();
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
            bool professional = this.rdoProfessional.Checked;

            this.ResetFields();
            this.Hide();

            MessageBox.Show("Speler succesvol aangemaakt!");
        }
    }
}
