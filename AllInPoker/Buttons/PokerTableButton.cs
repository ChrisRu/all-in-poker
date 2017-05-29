namespace AllInPoker.Buttons
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    /// <summary>
    /// Table Button inside the Tournament View
    /// </summary>
    public class PokerTableButton : Button
    {
        public override string Text
        {
            get { return string.Empty; }
            set { base.Text = value; }
        }

        public int TablePlayerCount { get; set; }

        private Font RegularFont { get; }
        private Font BigFont { get; }

        /// <summary>
        /// Initialize TournamentTableButton
        /// </summary>
        public PokerTableButton()
        {
            this.Width = 140;
            this.Height = 70;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Margin = new Padding(0, 0, 35, 35);
            this.BackColor = Color.FromArgb(126, 86, 51);
            this.RegularFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.BigFont = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            this.UseVisualStyleBackColor = false;

            this.Click += (sender, args) => MessageBox.Show("Tafel Aangeklikt.");
        }

        /// <summary>
        /// Override default paint to custom button with rounded rectangle
        /// </summary>
        /// <param name="e">Paint Event Arguments</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath graphPath = this.GetRoundPath(new Rectangle(0, 0, this.Width, this.Height), 35);

            this.Region = new Region(graphPath);
            using (Pen pen = new Pen(this.BackColor, 1f))
            {
                pen.Alignment = PenAlignment.Outset;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, graphPath);
            }
        }

        /// <summary>
        /// Get Rounded Path for drawing the button
        /// </summary>
        /// <param name="bounds">Rectangle with size of button</param>
        /// <param name="radius">Radius of rounded rectangle</param>
        /// <returns>Rounded Rectangle Path</returns>
        private GraphicsPath GetRoundPath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc
            path.AddArc(arc, 180, 90);

            // top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}