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

        public void CreateTournament(
            DateTime date,
            decimal cost,
            int minPlayers,
            int minAge,
            int maxAge,
            int locationId,
            int winnerId)
        {
            MySqlTransaction trans = null;

            try
            {
                this.Connection.Open();
                trans = this.Connection.BeginTransaction();

                const string InsertString = @"INSERT INTO tournament (date, time, cost, min_players, min_age, max_age, location_id, winner_id) VALUES (@date, @time, @cost, @min_players, @min_age, @location_id, @winner_id)";

                MySqlCommand command =
                    new MySqlCommand(InsertString, this.Connection)
                        {
                            Parameters =
                                {
                                    new MySqlParameter(
                                        "@date",
                                        MySqlDbType.DateTime)
                                        {
                                            Value
                                                = date
                                        },
                                    new MySqlParameter(
                                        "@time",
                                        MySqlDbType.Time)
                                        {
                                            Value
                                                = date
                                                    .ToLocalTime()
                                        },
                                    new MySqlParameter(
                                        "@cost",
                                        MySqlDbType.Decimal)
                                        {
                                            Value
                                                = cost
                                        },
                                    new MySqlParameter(
                                        "@min_players",
                                        MySqlDbType.Int64)
                                        {
                                            Value
                                                = minPlayers
                                        },
                                    new MySqlParameter(
                                        "@min_age",
                                        MySqlDbType.Int64)
                                        {
                                            Value
                                                = minAge
                                        },
                                    new MySqlParameter(
                                        "@location_id",
                                        MySqlDbType.Int64)
                                        {
                                            Value
                                                = maxAge
                                        },
                                    new MySqlParameter(
                                        "@location_id",
                                        MySqlDbType.Int64)
                                        {
                                            Value
                                                = locationId
                                        },
                                    new MySqlParameter(
                                        "@winner_id",
                                        MySqlDbType.Int64)
                                        {
                                            Value
                                                = winnerId
                                        }
                                }
                        };

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception e)
            {
                trans?.Rollback();
                MessageBox.Show("Toernooi toevoegen mislukt. ", e.Message);
            }
            finally
            {
                this.Connection.Close();
            }
        }

        /// <summary>
        /// Fetch City Name based on location id
        /// </summary>
        /// <param name="locationId">ID in event_location table</param>
        /// <returns>City Name</returns>
        public string GetCityName(int locationId)
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
