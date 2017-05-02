﻿namespace AllInPoker
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
            this.title = new System.Windows.Forms.Label();
            this.playerListBox = new System.Windows.Forms.ListView();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 46);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(86, 25);
            this.title.TabIndex = 4;
            this.title.Text = "Toernooi";
            // 
            // playerListBox
            // 
            this.playerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerListBox.Location = new System.Drawing.Point(17, 88);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(184, 290);
            this.playerListBox.TabIndex = 5;
            this.playerListBox.UseCompatibleStateImageBehavior = false;
            this.playerListBox.View = System.Windows.Forms.View.List;
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
            // TournamentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 429);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.title);
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
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListView playerListBox;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
    }
}