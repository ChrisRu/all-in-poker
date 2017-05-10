namespace AllInPoker.Tournaments
{
    partial class TournamentsView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newTournamentButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.activeTournamentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upcomingTournamentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actieve Toernooien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aankomende Toernooien";
            // 
            // newTournamentButton
            // 
            this.newTournamentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newTournamentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.newTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newTournamentButton.FlatAppearance.BorderSize = 0;
            this.newTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTournamentButton.ForeColor = System.Drawing.Color.White;
            this.newTournamentButton.Location = new System.Drawing.Point(623, 12);
            this.newTournamentButton.Name = "newTournamentButton";
            this.newTournamentButton.Size = new System.Drawing.Size(149, 39);
            this.newTournamentButton.TabIndex = 2;
            this.newTournamentButton.Text = "+ Nieuw Toernooi";
            this.newTournamentButton.UseVisualStyleBackColor = false;
            this.newTournamentButton.Click += new System.EventHandler(this.NewTournamentButtonClick);
            // 
            // newUserButton
            // 
            this.newUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserButton.BackColor = System.Drawing.Color.LightGray;
            this.newUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newUserButton.FlatAppearance.BorderSize = 0;
            this.newUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserButton.ForeColor = System.Drawing.Color.Black;
            this.newUserButton.Location = new System.Drawing.Point(462, 12);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(149, 39);
            this.newUserButton.TabIndex = 5;
            this.newUserButton.Text = "+ Nieuwe Speler";
            this.newUserButton.UseVisualStyleBackColor = false;
            this.newUserButton.Click += new System.EventHandler(this.NewUserButtonClick);
            // 
            // activeTournamentsPanel
            // 
            this.activeTournamentsPanel.AutoSize = true;
            this.activeTournamentsPanel.Location = new System.Drawing.Point(17, 91);
            this.activeTournamentsPanel.Name = "activeTournamentsPanel";
            this.activeTournamentsPanel.Size = new System.Drawing.Size(755, 75);
            this.activeTournamentsPanel.TabIndex = 6;
            // 
            // upcomingTournamentsPanel
            // 
            this.upcomingTournamentsPanel.AutoSize = true;
            this.upcomingTournamentsPanel.Location = new System.Drawing.Point(17, 228);
            this.upcomingTournamentsPanel.Name = "upcomingTournamentsPanel";
            this.upcomingTournamentsPanel.Size = new System.Drawing.Size(755, 75);
            this.upcomingTournamentsPanel.TabIndex = 7;
            // 
            // TournamentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 338);
            this.Controls.Add(this.upcomingTournamentsPanel);
            this.Controls.Add(this.activeTournamentsPanel);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.newTournamentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TournamentsView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All In Poker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newTournamentButton;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.FlowLayoutPanel activeTournamentsPanel;
        private System.Windows.Forms.FlowLayoutPanel upcomingTournamentsPanel;
    }
}

