namespace AllInPoker.Views
{
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

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

            var tafel1 = new DataGridView();
            tafel1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tafel1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tafel1.BackgroundColor = SystemColors.Control;
            tafel1.BorderStyle = BorderStyle.None;
            tafel1.RowHeadersVisible = false;
            tafel1.AutoSize = true;
            tafel1.ScrollBars = ScrollBars.None;
            tafel1.ColumnHeadersVisible = true;
            tafel1.Columns.Add("Naam", "Naam");
            tafel1.Columns.Add("Tafel", "Tafel");
            tafel1.Columns.Add("Seat", "Seat");

            for (int i = 0; i < 5; i++)
            {
                var row = (DataGridViewRow)tafel1.Rows[0].Clone();
                row.Cells[0].Value = "Henk";
                row.Cells[1].Value = 1;
                row.Cells[2].Value = 1;
                tafel1.Rows.Add(row);
            }

            this.pnlTables.Controls.Add(tafel1);

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