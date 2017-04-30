using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AllInPoker
{
    public partial class Form1 : Form
    {
        public List<string> ActiveTournaments { get; set; }
        public List<string> UpcomingTournaments { get; set; }

        public Form1()
        {
            InitializeComponent();

            this.ActiveTournaments = new List<string> {
                "Pijnacker",
                "Zoetermeer",
                "Rijswijk",
                "Amsterdorp"
            };

            this.UpcomingTournaments = new List<string>
            {
                "Rotterdam",
                "Den Haag",
                "Gouda"
            };

            for (int i = 0; i < this.ActiveTournaments.Count; i++)
            {
                var button = new TournamentButton
                {
                    LeftText = this.ActiveTournaments[i],
                    RightText = "16"
                };
                button.Location = new Point(i * (button.Width + 10) + 10, 80);
                Controls.Add(button);
            }

            for (int i = 0; i < this.UpcomingTournaments.Count; i++)
            {
                var button = new TournamentButton
                {
                    LeftText = this.UpcomingTournaments[i],
                    RightText = "16"
                };
                button.Location = new Point(i * (button.Width + 10) + 10, 220);
                Controls.Add(button);
            }
        }
    }
}
