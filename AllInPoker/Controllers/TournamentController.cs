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
        public List<TournamentModel> GetTournaments()
        {
            List<TournamentModel> tournaments = new List<TournamentModel>();

            try
            {
                this.Connection.Open();

                string query = @"SELECT * FROM tournament ORDER BY date DESC";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tournaments.Add(new TournamentModel
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
                Console.WriteLine("Fetching tournaments failed. " + e.Message);
                MessageBox.Show("Toernooien ophalen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

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
                            new MySqlParameter("@date", MySqlDbType.DateTime) {Value = date},
                            new MySqlParameter("@time", MySqlDbType.Time) {Value = date.ToLocalTime()},
                            new MySqlParameter("@cost", MySqlDbType.Decimal) {Value = cost},
                            new MySqlParameter("@min_players", MySqlDbType.Int32) {Value = minPlayers},
                            new MySqlParameter("@min_age", MySqlDbType.Int32) {Value = minAge},
                            new MySqlParameter("@location_id", MySqlDbType.Int32) {Value = maxAge},
                            new MySqlParameter("@location_id", MySqlDbType.Int32) {Value = locationId},
                            new MySqlParameter("@winner_id", MySqlDbType.Int32) {Value = winnerId}
                        }
                    };

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception e)
            {
                trans?.Rollback();
                Console.WriteLine("Adding tournament failed. " + e.Message);
                MessageBox.Show("Toernooi toevoegen mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }
        }

        /// <summary>
        /// Get all TournamentTables that are in a tournament
        /// </summary>
        /// <param name="tournamentId">ID of the tournament</param>
        /// <returns>List of tournament tables</returns>
        public List<TournamentTableModel> GetTournamentTables(int tournamentId)
        {
            List<TournamentTableModel> tables = new List<TournamentTableModel>();

            try
            {
                this.Connection.Open();

                string query = $@"SELECT * FROM tournament_table WHERE tournament_table.id = {tournamentId}";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tables.Add(new TournamentTableModel
                    {
                        Id = reader.GetInt32("id"),
                        TournamentId = reader.GetInt32("tournament_id"),
                        Round = reader.GetInt32("round")
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching tournament tables failed. " + e.Message);
                MessageBox.Show("Ophalen toernooi tafels is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            return tables;
        }

        /// <summary>
        /// Get all TournamentTablePlayers that are sitting on a table
        /// </summary>
        /// <param name="tableId">ID of the TournamentTableModel</param>
        /// <returns>List of players on a tournament table</returns>
        public List<TournamentTablePlayerModel> GetTournamentTablePlayers(int tableId)
        {
            List<TournamentTablePlayerModel> players = new List<TournamentTablePlayerModel>();

            try
            {
                this.Connection.Open();

                string query = $@"SELECT * FROM tournament_table_player WHERE table_id = {tableId}";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    players.Add(new TournamentTablePlayerModel
                    {
                        TableId = reader.GetInt32("table_id"),
                        PlayerId = reader.GetInt32("player_id"),
                        Position = reader.GetInt32("position")
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching tournament table players failed. " + e.Message);
                MessageBox.Show("Ophalen spelers van toernooi tafel is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            return players;
        }
    }
}