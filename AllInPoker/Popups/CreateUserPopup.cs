namespace AllInPoker.Popups
{
    using AllInPoker.Controllers;
    using AllInPoker.Models;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public delegate void UpdateUser();

    /// <summary>
    /// Create User PopUp to add a new User
    /// </summary>
    public partial class CreateUserPopup : Form
    {
        public static event UpdateUser UpdateUser;

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
            string firstname = this.txtFirstName.Text;
            string middlename = this.txtMiddleName.Text;
            string lastname = this.txtLastName.Text;
            string adress = this.txtAddress.Text;
            string city = this.txtCity.Text;
            string postal = this.txtPostalCode.Text;
            string phone = this.txtPhone.Text;
            string email = this.txtEmail.Text;
            string iban = this.txtIban.Text;
            string housenumber = this.txtHouseNumber.Text;
            string nationality = this.txtNationality.Text;
            bool professional = this.rdoProfessional.Checked;

            bool success = false;

            if (!professional)
            {
                success = new PlayerController().CreatePlayer(
                    new PlayerModel
                    {
                        Gender = male ? 'm' : 'e',
                        FirstName = firstname,
                        MiddleName = middlename,
                        LastName = lastname,
                        Street = adress,
                        City = city,
                        HouseNumber = housenumber,
                        PostalCode = postal,
                        Emails = new List<string> { email },
                        PhoneNumbers = new List<string> { phone },
                        IbanNumber = iban,
                    });
            }
            else
            {
                success = new ProfessionalController().CreateProfessional(
                    new ProfessionalModel
                    {
                        Gender = male ? 'm' : 'e',
                        FirstName = firstname,
                        MiddleName = middlename,
                        LastName = lastname,
                        Emails = new List<string> { email },
                        PhoneNumbers = new List<string> { phone },
                        Nationality = nationality
                    });
            }

            if (success)
            {
                UpdateUser?.Invoke();
                this.ResetFields();
                this.Hide();
            }
        }
    }
}