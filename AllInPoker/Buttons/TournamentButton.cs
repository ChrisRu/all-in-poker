namespace AllInPoker.Buttons
{
    using AllInPoker.Models;
    using AllInPoker.Views;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Tournament Button inside the Main Tournaments View
    /// </summary>
    public class TournamentButton : Button
    {
        public override string Text
        {
            get
            {
                return string.Empty;
            }

            set
            {
                base.Text = value;
            }
        }

        private TournamentModel _tournament;

        public TournamentModel Tournament
        {
            get
            {
                return this._tournament;
            }
            set
            {
                this._tournament = value;
                if (this.Tournament.Date <= DateTime.Now)
                {
                    this.Click += (sender, args) => new ActiveTournamentView(this.Tournament).ShowDialog();
                }
                else
                {
                    this.Click += (sender, args) => new UpcomingTournamentView(this.Tournament).ShowDialog();
                }
            }
        }

        private Font RegularFont { get; }

        private Font BigFont { get; }

        /// <summary>
        /// Initialize TournamentButton
        /// </summary>
        public TournamentButton()
        {
            this.Width = 140;
            this.Height = 70;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.RegularFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.BigFont = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            this.UseVisualStyleBackColor = false;
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        /// <summary>
        /// Override default paint to custom button with custom text
        /// </summary>
        /// <param name="paintEventArgs">Paint Event Arguments</param>
        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            base.OnPaint(paintEventArgs);
            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-5, -5);
            using (StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Far
            })
            {
                using (Brush brush = new SolidBrush(this.ForeColor))
                {
                    sf.LineAlignment = StringAlignment.Center;
                    paintEventArgs.Graphics.DrawString(this.Tournament.Location.City, this.BigFont, brush, rect, sf);
                    sf.LineAlignment = StringAlignment.Far;
                    paintEventArgs.Graphics.DrawString(this.Tournament.Date.ToShortDateString(), this.RegularFont, brush, rect, sf);
                    sf.Alignment = StringAlignment.Far;
                    paintEventArgs.Graphics.DrawString(this.Tournament.Entries.Count + "/" + this.Tournament.Location.MaxPlayers + " 웃", this.RegularFont, brush, rect, sf);
                }
            }
        }
    }
}