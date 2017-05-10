namespace AllInPoker.Tournament
{
    partial class TournamentView
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstPlayer = new System.Windows.Forms.ListView();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Toernooi";
            // 
            // lstPlayer
            // 
            this.lstPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlayer.Location = new System.Drawing.Point(17, 103);
            this.lstPlayer.Name = "lstPlayer";
            this.lstPlayer.Size = new System.Drawing.Size(184, 275);
            this.lstPlayer.TabIndex = 5;
            this.lstPlayer.UseCompatibleStateImageBehavior = false;
            this.lstPlayer.View = System.Windows.Forms.View.List;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayerButton.BackColor = System.Drawing.Color.LightGray;
            this.addPlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPlayerButton.FlatAppearance.BorderSize = 0;
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.ForeColor = System.Drawing.Color.Black;
            this.addPlayerButton.Location = new System.Drawing.Point(17, 384);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(144, 32);
            this.addPlayerButton.TabIndex = 6;
            this.addPlayerButton.Text = "+ Voeg Speler Toe";
            this.addPlayerButton.UseVisualStyleBackColor = false;
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removePlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.removePlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removePlayerButton.FlatAppearance.BorderSize = 0;
            this.removePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayerButton.ForeColor = System.Drawing.Color.White;
            this.removePlayerButton.Location = new System.Drawing.Point(168, 384);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(33, 32);
            this.removePlayerButton.TabIndex = 7;
            this.removePlayerButton.Text = "🗑️";
            this.removePlayerButton.UseVisualStyleBackColor = false;
            this.removePlayerButton.Click += new System.EventHandler(this.RemovePlayerButtonClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 73);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 16);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "01/01/2017";
            // 
            // pnlTable
            // 
            this.pnlTable.Location = new System.Drawing.Point(208, 103);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(718, 275);
            this.pnlTable.TabIndex = 9;
            // 
            // TournamentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 429);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.lstPlayer);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TournamentView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All In Poker - Toernooi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lstPlayer;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.FlowLayoutPanel pnlTable;
    }
}