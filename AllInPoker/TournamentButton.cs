using System.Drawing;
using System.Windows.Forms;

namespace AllInPoker
{
    class TournamentButton : Button
    {
        public override string Text
        {
            get { return ""; }
            set { base.Text = value; }
        }

        public string LeftText { get; set; }
        public string RightText { get; set; }

        public TournamentButton()
        {
            Width = 140;
            Height = 70;
            BackColor = Color.White;
            Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            UseVisualStyleBackColor = false;
            TextImageRelation = TextImageRelation.ImageAboveText;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
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
                    pevent.Graphics.DrawString(LeftText, Font, brush, rect, sf);
                    sf.Alignment = StringAlignment.Far;
                    pevent.Graphics.DrawString(RightText, Font, brush, rect, sf);
                }
            }
        }
    }
}
