namespace AllInPoker.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using AllInPoker.Models;

    using MySql.Data.MySqlClient;

    public class TournamentController : DatabaseController
    {
        public TournamentController(string server, string database, string uid, string password)
            : base(server, database, uid, password)
        {
        }

        /// <summary>
        /// Get all tournaments in a list
        /// </summary>
        /// <returns>List with TournamentItems</returns>
        public List<TournamentItem> GetTournaments()
        {
            List<TournamentItem> tournaments = new List<TournamentItem>();

            try
            {
                this.Connection.Open();

                string query = @"SELECT * FROM tournament ORDER BY date DESC";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tournaments.Add(new TournamentItem
                                        {
                                            Id = reader.GetInt32("id"),
                                            Date = reader.GetDateTime("date").ToLocalTime(),
                                            //// Time = reader.GetDateTime("time").ToLocalTime(),
                                            Cost = reader.GetDecimal("cost"),
                                            MinPlayers = reader.GetInt32("min_players"),
                                            MinAge = reader.GetInt32("min_age"),
                                            MaxAge = reader.GetInt32("max_age"),
                                            LocationId = reader.GetInt32("location_id"),
                                            WinnerId = reader.IsDBNull(reader.GetOrdinal("winner_id")) ? -1 : reader.GetInt32("winner_id")
                                        });
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

            // Add City Name to tournament
            tournaments.ForEach(tournament => tournament.CityName = this.GetCityName(tournament.LocationId));

            return tournaments;
        }

        /// <summary>
        /// Fetch City Name based on location id
        /// </summary>
        /// <param name="locationId">ID in event_location table</param>
        /// <returns>City Name</returns>
        private string GetCityName(int locationId)
        {
            try
            {
                this.Connection.Open();

                string query = $@"SELECT city FROM event_location where id = {locationId}";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return reader.GetString("city");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching city failed", e);
                MessageBox.Show(e.Message);
            }
            finally
            {
                this.Connection.Close();
            }

            return "-";
        }
    }
}
