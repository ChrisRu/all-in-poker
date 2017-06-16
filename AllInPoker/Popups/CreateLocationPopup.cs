namespace AllInPoker.Popups
{
    using AllInPoker.Controllers;
    using AllInPoker.Models;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Create User PopUp to add a new User
    /// </summary>
    public partial class CreateLocationPopup : Form
    {
        /// <summary>
        /// Initialize CreateUserComponent
        /// </summary>
        public CreateLocationPopup()
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
        /// <param name="sender">The Create User View</param>
        /// <param name="e">Event Arguments from the Create User Event</param>
        private void CreateUserButtonClick(object sender, EventArgs e)
        {
            string city = this.txtCity.Text;
            string street = this.txtStreet.Text;
            string postal = this.txtPostalCode.Text;
            string housenumber = this.txtHouseNumber.Text;
            int maxPlayers = (int)this.numMaxPlayers.Value;

            bool success = new EventLocationController().CreateEventLocation(
                new EventLocationModel
                {
                    Street = street,
                    City = city,
                    HouseNumber = housenumber,
                    PostalCode = postal,
                    MaxPlayers = maxPlayers
                });

            if (success)
            {
                this.ResetFields();
                this.Hide();
            }
        }
    }
}