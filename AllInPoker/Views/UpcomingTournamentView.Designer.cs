namespace AllInPoker.Views
{
    partial class UpcomingTournamentView
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
            this.components = new System.ComponentModel.Container();
            this.lstTournamentPlayers = new System.Windows.Forms.ListView();
            this.lstAllPlayers = new System.Windows.Forms.ListView();
            this.saveTournamentButton = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.txtSearchAllPlayers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchTournamentPlayers = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPlayers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTournamentPlayers
            // 
            this.lstTournamentPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTournamentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTournamentPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTournamentPlayers.Location = new System.Drawing.Point(217, 114);
            this.lstTournamentPlayers.Name = "lstTournamentPlayers";
            this.lstTournamentPlayers.Size = new System.Drawing.Size(184, 303);
            this.lstTournamentPlayers.TabIndex = 5;
            this.lstTournamentPlayers.UseCompatibleStateImageBehavior = false;
            this.lstTournamentPlayers.View = System.Windows.Forms.View.List;
            // 
            // lstAllPlayers
            // 
            this.lstAllPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAllPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAllPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllPlayers.Location = new System.Drawing.Point(451, 114);
            this.lstAllPlayers.Name = "lstAllPlayers";
            this.lstAllPlayers.Size = new System.Drawing.Size(184, 303);
            this.lstAllPlayers.TabIndex = 9;
            this.lstAllPlayers.UseCompatibleStateImageBehavior = false;
            this.lstAllPlayers.View = System.Windows.Forms.View.List;
            // 
            // saveTournamentButton
            // 
            this.saveTournamentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveTournamentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.saveTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTournamentButton.ForeColor = System.Drawing.Color.White;
            this.saveTournamentButton.Location = new System.Drawing.Point(777, 378);
            this.saveTournamentButton.Name = "saveTournamentButton";
            this.saveTournamentButton.Size = new System.Drawing.Size(149, 39);
            this.saveTournamentButton.TabIndex = 10;
            this.saveTournamentButton.Text = "Opslaan";
            this.saveTournamentButton.UseVisualStyleBackColor = false;
            this.saveTournamentButton.Click += new System.EventHandler(this.saveTournamentButton_Click);
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShiftRight.BackColor = System.Drawing.Color.LightGray;
            this.btnShiftRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShiftRight.FlatAppearance.BorderSize = 0;
            this.btnShiftRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftRight.ForeColor = System.Drawing.Color.Black;
            this.btnShiftRight.Location = new System.Drawing.Point(407, 87);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(38, 38);
            this.btnShiftRight.TabIndex = 13;
            this.btnShiftRight.Text = ">";
            this.btnShiftRight.UseVisualStyleBackColor = false;
            this.btnShiftRight.Click += new System.EventHandler(this.BtnShiftRightClick);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShiftLeft.BackColor = System.Drawing.Color.LightGray;
            this.btnShiftLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShiftLeft.FlatAppearance.BorderSize = 0;
            this.btnShiftLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftLeft.ForeColor = System.Drawing.Color.Black;
            this.btnShiftLeft.Location = new System.Drawing.Point(407, 131);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(38, 38);
            this.btnShiftLeft.TabIndex = 14;
            this.btnShiftLeft.Text = "<";
            this.btnShiftLeft.UseVisualStyleBackColor = false;
            this.btnShiftLeft.Click += new System.EventHandler(this.BtnShiftLeftClick);
            // 
            // txtSearchAllPlayers
            // 
            this.txtSearchAllPlayers.Location = new System.Drawing.Point(451, 87);
            this.txtSearchAllPlayers.Name = "txtSearchAllPlayers";
            this.txtSearchAllPlayers.Size = new System.Drawing.Size(184, 20);
            this.txtSearchAllPlayers.TabIndex = 17;
            this.txtSearchAllPlayers.TextChanged += new System.EventHandler(this.txtSearchAllPlayersTextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Toernooi Spelers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Alle Spelers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchTournamentPlayers
            // 
            this.txtSearchTournamentPlayers.Location = new System.Drawing.Point(217, 87);
            this.txtSearchTournamentPlayers.Name = "txtSearchTournamentPlayers";
            this.txtSearchTournamentPlayers.Size = new System.Drawing.Size(184, 20);
            this.txtSearchTournamentPlayers.TabIndex = 20;
            this.txtSearchTournamentPlayers.TextChanged += new System.EventHandler(this.txtSearchTournamentPlayersTextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(12, 58);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 20);
            this.lblCity.TabIndex = 21;
            this.lblCity.Text = "Locatie";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 87);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 16);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Locatie";
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostal.Location = new System.Drawing.Point(13, 109);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(52, 16);
            this.lblPostal.TabIndex = 23;
            this.lblPostal.Text = "Locatie";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(13, 131);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(52, 16);
            this.lblCost.TabIndex = 24;
            this.lblCost.Text = "Locatie";
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(13, 153);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(52, 16);
            this.lblPlayers.TabIndex = 25;
            this.lblPlayers.Text = "Locatie";
            // 
            // UpcomingTournamentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 429);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtSearchTournamentPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchAllPlayers);
            this.Controls.Add(this.btnShiftLeft);
            this.Controls.Add(this.btnShiftRight);
            this.Controls.Add(this.saveTournamentButton);
            this.Controls.Add(this.lstAllPlayers);
            this.Controls.Add(this.lstTournamentPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpcomingTournamentView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All In Poker - Toernooi";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstTournamentPlayers;
        private System.Windows.Forms.ListView lstAllPlayers;
        private System.Windows.Forms.Button saveTournamentButton;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.TextBox txtSearchAllPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchTournamentPlayers;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPlayers;
    }
}