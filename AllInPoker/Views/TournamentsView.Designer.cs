namespace AllInPoker.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentsView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newEventButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.pnlTournaments = new System.Windows.Forms.Panel();
            this.pnlMasterclasses = new System.Windows.Forms.Panel();
            this.newLocationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgPlayers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toernooien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masterclasses";
            // 
            // newEventButton
            // 
            this.newEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.newEventButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEventButton.FlatAppearance.BorderSize = 0;
            this.newEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEventButton.ForeColor = System.Drawing.Color.White;
            this.newEventButton.Location = new System.Drawing.Point(610, 12);
            this.newEventButton.Name = "newEventButton";
            this.newEventButton.Size = new System.Drawing.Size(162, 39);
            this.newEventButton.TabIndex = 2;
            this.newEventButton.Text = "+ Nieuw Evenement";
            this.newEventButton.UseVisualStyleBackColor = false;
            this.newEventButton.Click += new System.EventHandler(this.NewEventButtonClick);
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
            this.newUserButton.Location = new System.Drawing.Point(466, 12);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(138, 39);
            this.newUserButton.TabIndex = 5;
            this.newUserButton.Text = "+ Nieuwe Speler";
            this.newUserButton.UseVisualStyleBackColor = false;
            this.newUserButton.Click += new System.EventHandler(this.NewUserButtonClick);
            // 
            // pnlTournaments
            // 
            this.pnlTournaments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTournaments.AutoScroll = true;
            this.pnlTournaments.Location = new System.Drawing.Point(17, 93);
            this.pnlTournaments.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnlTournaments.MinimumSize = new System.Drawing.Size(100, 100);
            this.pnlTournaments.Name = "pnlTournaments";
            this.pnlTournaments.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlTournaments.Size = new System.Drawing.Size(755, 100);
            this.pnlTournaments.TabIndex = 8;
            // 
            // pnlMasterclasses
            // 
            this.pnlMasterclasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMasterclasses.AutoScroll = true;
            this.pnlMasterclasses.Location = new System.Drawing.Point(17, 264);
            this.pnlMasterclasses.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnlMasterclasses.MinimumSize = new System.Drawing.Size(100, 100);
            this.pnlMasterclasses.Name = "pnlMasterclasses";
            this.pnlMasterclasses.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlMasterclasses.Size = new System.Drawing.Size(755, 100);
            this.pnlMasterclasses.TabIndex = 9;
            // 
            // newLocationButton
            // 
            this.newLocationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.newLocationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newLocationButton.FlatAppearance.BorderSize = 0;
            this.newLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLocationButton.ForeColor = System.Drawing.Color.White;
            this.newLocationButton.Location = new System.Drawing.Point(317, 12);
            this.newLocationButton.Name = "newLocationButton";
            this.newLocationButton.Size = new System.Drawing.Size(143, 39);
            this.newLocationButton.TabIndex = 12;
            this.newLocationButton.Text = "+ Nieuwe Locatie";
            this.newLocationButton.UseVisualStyleBackColor = false;
            this.newLocationButton.Click += new System.EventHandler(this.newLocationButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Spelers";
            // 
            // dgPlayers
            // 
            this.dgPlayers.AllowUserToDeleteRows = false;
            this.dgPlayers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayers.Location = new System.Drawing.Point(17, 436);
            this.dgPlayers.Name = "dgPlayers";
            this.dgPlayers.Size = new System.Drawing.Size(755, 187);
            this.dgPlayers.TabIndex = 11;
            // 
            // TournamentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 640);
            this.Controls.Add(this.newLocationButton);
            this.Controls.Add(this.dgPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlMasterclasses);
            this.Controls.Add(this.pnlTournaments);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.newEventButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All In Poker";
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newEventButton;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Panel pnlTournaments;
        private System.Windows.Forms.Panel pnlMasterclasses;
        private System.Windows.Forms.Button newLocationButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgPlayers;
    }
}

