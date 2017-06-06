namespace AllInPoker.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Windows.Forms;

    using MySql.Data.MySqlClient;

    public class TournamentController : DatabaseController
    {
        public TournamentController(string server, string database, string uid, string password)
            : base(server, database, uid, password)
        {
        }

        public void GetTournaments()
        {
            // List<Tournament> tournaments = new List<Tournament>();
            try
            {
                this.Connection.Open();

                string query = @"SELECT * FROM tournament";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    DateTime date = reader.GetDateTime("date");
                    decimal cost = reader.IsDBNull(reader.GetOrdinal("cost")) ? 0 : reader.GetDecimal("cost");
                    short minPlayers = reader.IsDBNull(reader.GetOrdinal("min_players")) ? (short)0 : reader.GetInt16("min_players");
                    /*
                    short minAge = reader.GetInt16("min_age");
                    short maxAge = reader.GetInt16("max_age");
                    int locationId = reader.GetInt32("location_id");
                    int employeeId = reader.GetInt32("employee_id");
                    int winner = reader.GetInt32("winner");
                    short round = reader.GetInt16("round");
                    */

                    // Tournament tournament = new Tournament { ID = id, Date = date, Cost = cost, MinPlayers = MinPlayers }
                    // tournaments.Add(tournament);
                    MessageBox.Show(cost.ToString(CultureInfo.InvariantCulture));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching tournaments failed", e);
                MessageBox.Show(e.Message);
            }
            finally
            {
                this.Connection.Close();
            }

            // return tournaments;
        }
    }
}
