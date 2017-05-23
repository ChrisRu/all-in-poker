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
            this.lstTournamentPlayers = new System.Windows.Forms.ListView();
            this.lstAllPlayers = new System.Windows.Forms.ListView();
            this.saveTournamentButton = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSearchPlayer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstTournamentPlayers
            // 
            this.lstTournamentPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTournamentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTournamentPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTournamentPlayers.Location = new System.Drawing.Point(207, 55);
            this.lstTournamentPlayers.Name = "lstTournamentPlayers";
            this.lstTournamentPlayers.Size = new System.Drawing.Size(184, 362);
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
            this.lstAllPlayers.Location = new System.Drawing.Point(441, 81);
            this.lstAllPlayers.Name = "lstAllPlayers";
            this.lstAllPlayers.Size = new System.Drawing.Size(184, 336);
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
            this.btnShiftRight.Location = new System.Drawing.Point(397, 55);
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
            this.btnShiftLeft.Location = new System.Drawing.Point(397, 99);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(38, 38);
            this.btnShiftLeft.TabIndex = 14;
            this.btnShiftLeft.Text = "<";
            this.btnShiftLeft.UseVisualStyleBackColor = false;
            this.btnShiftLeft.Click += new System.EventHandler(this.BtnShiftLeftClick);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(17, 87);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(184, 20);
            this.datePicker.TabIndex = 15;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(17, 55);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(184, 26);
            this.txtTitle.TabIndex = 16;
            // 
            // txtSearchPlayer
            // 
            this.txtSearchPlayer.Location = new System.Drawing.Point(441, 55);
            this.txtSearchPlayer.Name = "txtSearchPlayer";
            this.txtSearchPlayer.Size = new System.Drawing.Size(184, 20);
            this.txtSearchPlayer.TabIndex = 17;
            this.txtSearchPlayer.TextChanged += new System.EventHandler(this.txtSearchPlayerTextChanged);
            // 
            // UpcomingTournamentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 429);
            this.Controls.Add(this.txtSearchPlayer);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.datePicker);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstTournamentPlayers;
        private System.Windows.Forms.ListView lstAllPlayers;
        private System.Windows.Forms.Button saveTournamentButton;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSearchPlayer;
    }
}