namespace AllInPoker.Views
{
    using AllInPoker.Models;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Single Tournament View with players, tables, etc.
    /// </summary>
    public partial class ActiveTournamentView : Form
    {
        private TournamentModel Tournament { get; set; }

        /// <summary>
        /// Initialize TournamentView
        /// </summary>
        /// <param name="tournament">MySQL Tournament</param>
        public ActiveTournamentView(TournamentModel tournament)
        {
            this.Tournament = tournament;

            // Initialize View Components
            this.InitializeComponent();
            this.lblTitle.Text = "Toernooi " + this.Tournament.Location.City;
            this.lblDate.Text = this.Tournament.Date.ToLongDateString();
            this.Text = "All In Poker - Toernooi " + this.Tournament.Location.City;

            for (int j = 0; j < this.Tournament.Tables.Count; j++)
            {
                var table = new DataGridView
                {
                    AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                    BackgroundColor = SystemColors.Control,
                    BorderStyle = BorderStyle.None,
                    RowHeadersVisible = false,
                    AutoSize = true,
                    ScrollBars = ScrollBars.None,
                    ColumnHeadersVisible = true,
                    ReadOnly = true
                };
                table.Columns.Add("Naam", "Naam");
                table.Columns.Add("Tafel", "Tafel");
                table.Columns.Add("Seat", "Seat");

                for (int i = 0; i < this.Tournament.Tables.Count; i++)
                {
                    int rowIndex = table.Rows.Add();

                    // Name
                    table.Rows[rowIndex].Cells[0].Value = "Henk";

                    // Table
                    table.Rows[rowIndex].Cells[1].Value = j + 1;

                    // Seat
                    table.Rows[rowIndex].Cells[2].Value = i + 1;
                }

                this.pnlTables.Controls.Add(table);
            }

            this.GetData();
        }

        /// <summary>
        /// Get the data about the tournament from the database
        /// </summary>
        private void GetData()
        {
            // TODO: MySQL Request here
        }
    }
}