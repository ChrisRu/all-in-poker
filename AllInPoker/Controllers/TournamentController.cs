﻿namespace AllInPoker.Controllers
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

        public List<TournamentItem> GetTournaments()
        {
            List<TournamentItem> tournaments = new List<TournamentItem>();

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
                    short minAge = reader.IsDBNull(reader.GetOrdinal("min_age")) ? (short)0 : reader.GetInt16("min_age");
                    short maxAge = reader.IsDBNull(reader.GetOrdinal("max_age")) ? (short)0 : reader.GetInt16("max_age");
                    int locationId = reader.IsDBNull(reader.GetOrdinal("location_id")) ? 0 : reader.GetInt32("location_id");
                    int employeeId = reader.IsDBNull(reader.GetOrdinal("employee_id")) ? 0 : reader.GetInt32("employee_id");
                    int winner = reader.IsDBNull(reader.GetOrdinal("winner")) ? 0 : reader.GetInt32("winner");
                    short round = reader.IsDBNull(reader.GetOrdinal("round")) ? (short)0 : reader.GetInt16("round");

                    TournamentItem tournament =
                        new TournamentItem
                            {
                                Id = id,
                                Date = date,
                                Cost = cost,
                                MinPlayers = minPlayers,
                                MinAge = minAge,
                                MaxAge = maxAge,
                                LocationId = locationId,
                                EmployeeId = employeeId,
                                WinnerId = winner,
                                Round = round
                            };
                    tournaments.Add(tournament);
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

            return tournaments;
        }
    }
}