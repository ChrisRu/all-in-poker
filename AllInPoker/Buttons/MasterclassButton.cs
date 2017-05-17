
namespace AllInPoker.Buttons
{
    using System.Drawing;
    using System.Windows.Forms;

    using AllInPoker.Views;

    /// <summary>
    /// Tournament Button inside the Main Tournaments View
    /// </summary>
    public class MasterclassButton : Button
    {
        public override string Text
        {
            get { return string.Empty; }
            set { base.Text = value; }
        }

        public string MasterclassTitle { get; set; }
        public string MasterclassTutor { get; set; }
        public int MasterclassPlayerCount { get; set; }
        public string MasterclassDate { get; set; }

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
            this.BackColor = Color.FromArgb(255, 255, 255);
            this.RegularFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.BigFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            this.UseVisualStyleBackColor = false;

            this.Click += (sender, args) => new TournamentView(this.MasterclassTitle).ShowDialog();
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
                    sf.LineAlignment = StringAlignment.Near;
                    pEvent.Graphics.DrawString(this.MasterclassTitle, this.BigFont, brush, rect, sf);
                    sf.LineAlignment = StringAlignment.Center;
                    pEvent.Graphics.DrawString("door " + this.MasterclassTutor, this.RegularFont, brush, rect, sf);
                    sf.LineAlignment = StringAlignment.Far;
                    pEvent.Graphics.DrawString(this.MasterclassDate, this.RegularFont, brush, rect, sf);
                    sf.Alignment = StringAlignment.Far;
                    pEvent.Graphics.DrawString(this.MasterclassPlayerCount + " spelers", this.RegularFont, brush, rect, sf);
                }
            }
        }
    }
}
