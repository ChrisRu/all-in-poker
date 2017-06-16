namespace AllInPoker.Popups
{
    partial class CreateLocationPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numMaxPlayers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(138, 85);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(312, 20);
            this.txtCity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nieuwe Locatie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stad / Dorp";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createTournamentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.createTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.White;
            this.createTournamentButton.Location = new System.Drawing.Point(301, 268);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(149, 39);
            this.createTournamentButton.TabIndex = 14;
            this.createTournamentButton.Text = "Maak Speler";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.CreateUserButtonClick);
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Location = new System.Drawing.Point(138, 120);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(312, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(14, 121);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(77, 16);
            this.lblMiddleName.TabIndex = 26;
            this.lblMiddleName.Text = "Straatnaam";
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHouseNumber.Location = new System.Drawing.Point(138, 158);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(312, 20);
            this.txtHouseNumber.TabIndex = 27;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Location = new System.Drawing.Point(138, 196);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(312, 20);
            this.txtPostalCode.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Maximale Spelers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Postcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Huis Nummer";
            // 
            // numMaxPlayers
            // 
            this.numMaxPlayers.Location = new System.Drawing.Point(138, 236);
            this.numMaxPlayers.Name = "numMaxPlayers";
            this.numMaxPlayers.Size = new System.Drawing.Size(68, 20);
            this.numMaxPlayers.TabIndex = 33;
            // 
            // CreateLocationPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 319);
            this.Controls.Add(this.numMaxPlayers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateLocationPopup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All In Poker - Maak Speler";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMaxPlayers;
    }
}