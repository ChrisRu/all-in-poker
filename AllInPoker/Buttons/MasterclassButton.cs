namespace AllInPoker.Buttons
{
    using System.Drawing;
    using System.Windows.Forms;

    using AllInPoker.Models;
    using AllInPoker.Views;

    /// <summary>
    /// Tournament Button inside the Main Tournaments View
    /// </summary>
    public class MasterclassButton : Button
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

        private MasterclassModel _masterclass;

        public MasterclassModel Masterclass
        {
            get
            {
                return this._masterclass;
            }

            set
            {
                this._masterclass = value;
                // this.Click += (sender, args) => new UpcomingTournamentView(this.Masterclass).ShowDialog();
            }
        }

        private Font RegularFont { get; }

        private Font BigFont { get; }

        /// <summary>
        /// Initialize TournamentButton
        /// </summary>
        public MasterclassButton()
        {
            this.Width = 250;
            this.Height = 70;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.RegularFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.BigFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            this.UseVisualStyleBackColor = false;
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.White;
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
            using (StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Far
            })
            {
                using (Brush brush = new SolidBrush(this.ForeColor))
                {
                    sf.LineAlignment = StringAlignment.Near;
                    paintEventArgs.Graphics.DrawString(this.Masterclass.Professional.GetFullName(), this.BigFont, brush, rect, sf);
                    sf.LineAlignment = StringAlignment.Center;
                    paintEventArgs.Graphics.DrawString("door " + this.Masterclass.Professional.GetFullName(), this.RegularFont, brush, rect, sf);
                    sf.LineAlignment = StringAlignment.Far;
                    paintEventArgs.Graphics.DrawString(this.Masterclass.Date.ToShortDateString(), this.RegularFont, brush, rect, sf);
                    sf.Alignment = StringAlignment.Far;
                    paintEventArgs.Graphics.DrawString(this.Masterclass.Entries.Count + "/" + this.Masterclass.Location.MaxPlayers + " deelnemers", this.RegularFont, brush, rect, sf);
                }
            }
        }
    }
}