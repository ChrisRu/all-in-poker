using System.Drawing;
using System.Windows.Forms;

namespace AllInPoker
{
    class TournamentButton : Button
    {
        public override string Text
        {
            get { return string.Empty; }
            set { base.Text = value; }
        }

        public string Location { get; set; }
        public int PlayerCount { get; set; }
        public string Date { get; set; }

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
            this.BackColor = Color.FromArgb(255, 255, 255);
            this.RegularFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.BigFont = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            this.UseVisualStyleBackColor = false;
        }

        /// <summary>
        /// Override default paint to custom button with custom text
        /// </summary>
        /// <param name="pEvent">Paint Event Arguments</param>
        protected override void OnPaint(PaintEventArgs pEvent)
        {
            base.OnPaint(pEvent);
            Rectangle rect = ClientRectangle;
            rect.Inflate(-5, -5);
            using (StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Far
            })
            {
                using (Brush brush = new SolidBrush(ForeColor))
                {
                    sf.LineAlignment = StringAlignment.Center;
                    pEvent.Graphics.DrawString(this.Location, this.BigFont, brush, rect, sf);
                    sf.LineAlignment = StringAlignment.Far;
                    pEvent.Graphics.DrawString(this.Date, this.RegularFont, brush, rect, sf);
                    sf.Alignment = StringAlignment.Far;
                    pEvent.Graphics.DrawString(this.PlayerCount + " spelers", this.RegularFont, brush, rect, sf);
                }
            }
        }
    }
}
