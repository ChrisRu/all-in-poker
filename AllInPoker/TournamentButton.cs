using System.Drawing;
using System.Linq;
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

        public string LeftText { get; set; }
        public string RightText { get; set; }

        public TournamentButton()
        {
            this.Width = 140;
            this.Height = 70;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.BackColor = Color.FromArgb(255, 255, 255);
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.Cursor = Cursors.Hand;
            this.UseVisualStyleBackColor = false;
            this.TextImageRelation = TextImageRelation.ImageAboveText;
        }

        protected override void OnPaint(PaintEventArgs pEvent)
        {
            base.OnPaint(pEvent);
            Rectangle rect = ClientRectangle;
            rect.Inflate(-5, -5);
            using (StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            })
            {
                using (Brush brush = new SolidBrush(ForeColor))
                {
                    pEvent.Graphics.DrawString(this.LeftText, this.Font, brush, rect, sf);
                    sf.Alignment = StringAlignment.Far;
                    pEvent.Graphics.DrawString(this.RightText, this.Font, brush, rect, sf);
                }
            }
        }
    }
}
