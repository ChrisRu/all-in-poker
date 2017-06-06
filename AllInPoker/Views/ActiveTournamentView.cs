namespace AllInPoker.Views
{
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    using AllInPoker.Controllers;

    /// <summary>
    /// Single Tournament View with players, tables, etc.
    /// </summary>
    public partial class ActiveTournamentView : Form
    {
        private string TournamentId { get; set; }

        private new string Location { get; set; }

        private List<string> Players { get; set; }

        private int TableCount { get; set; }

        private string Date { get; set; }

        /// <summary>
        /// Initialize TournamentView
        /// </summary>
        /// <param name="id">MySQL Tournament ID</param>
        public ActiveTournamentView(string id)
        {
            this.TournamentId = id;
            this.Location = id;
            this.Players = new List<string> { "Henk", "Aard", "Erik", "Joop", "Bob", "Marie" };
            this.TableCount = 4;
            this.Date = "15/04/2017";
            
            // Initialize View Components
            this.InitializeComponent();
            this.lblTitle.Text = "Toernooi " + this.Location;
            this.lblDate.Text = this.Date;
            this.Text = "All In Poker - Toernooi " + this.Location;

            for (int j = 0; j < 8; j++)
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

                for (int i = 0; i < 5; i++)
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
            TournamentController controller = new TournamentController("localhost", "allin_poker", "root", "root");
            controller.GetTournaments();
        }
    }
}