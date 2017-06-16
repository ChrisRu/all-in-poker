namespace AllInPoker.Controllers
{
    using AllInPoker.Models;
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class PlayerController : DatabaseController
    {
        /// <summary>
        /// Get all Masterclasss in a list
        /// </summary>
        /// <returns>List with Players</returns>
        public List<PlayerModel> GetPlayers()
        {
            List<PlayerModel> players = new List<PlayerModel>();

            try
            {
                this.Connection.Open();

                string query = @"SELECT * FROM player JOIN person ON player.id = person.id ORDER BY last_name DESC";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    players.Add(new PlayerModel
                    {
                        Id = reader.GetInt32("id"),
                        BirthDate = reader.GetDateTime("birth_date"),
                        City = reader.GetString("city"),
                        FirstName = reader.GetString("first_name"),
                        MiddleName = reader["middle_name"] == DBNull.Value ? string.Empty : reader.GetString("middle_name"),
                        LastName = reader.GetString("last_name"),
                        Gender = reader.GetChar("gender"),
                        HouseNumber = reader.GetString("house_number"),
                        IbanNumber = reader.GetString("iban_number"),
                        PostalCode = reader.GetString("postal_code"),
                        MoneyWon = reader.GetDecimal("money_won"),
                        Rating = reader["rating"] == DBNull.Value ? 0 : reader.GetInt32("rating")
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching Players failed. " + e.Message);
                MessageBox.Show("Spelers ophalen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            foreach (PlayerModel player in players)
            {
                player.Emails = this.GetEmails(player.Id);
                player.PhoneNumbers = this.GetPhoneNumbers(player.Id);
            }

            return players;
        }

        /// <summary>
        /// Get a PlayerModel by ID
        /// </summary>
        /// <returns>Player</returns>
        public PlayerModel GetPlayer(int playerId)
        {
            PlayerModel player = null;

            try
            {
                this.Connection.Open();

                string query = $@"SELECT * FROM player LEFT JOIN person ON player.id = person.id WHERE player.id = { playerId }";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    player = new PlayerModel
                    {
                        Id = reader.GetInt32("id"),
                        BirthDate = reader.GetDateTime("birth_date"),
                        City = reader.GetString("city"),
                        FirstName = reader.GetString("first_name"),
                        MiddleName = reader["middle_name"] == DBNull.Value ? string.Empty : reader.GetString("middle_name"),
                        LastName = reader.GetString("last_name"),
                        Gender = reader.GetChar("gender"),
                        HouseNumber = reader.GetString("house_number"),
                        IbanNumber = reader.GetString("iban_number"),
                        PostalCode = reader.GetString("postal_code"),
                        MoneyWon = reader.GetDecimal("money_won"),
                        Rating = reader.GetInt32("rating")
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching player failed. " + e.Message);
                MessageBox.Show("Speler ophalen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            if (player != null)
            {
                player.Emails = this.GetEmails(player.Id);
                player.PhoneNumbers = this.GetPhoneNumbers(player.Id);
            }

            return player;
        }

        public bool CreatePlayer(PlayerModel player)
        {
            MySqlTransaction trans = null;
            bool success;

            try
            {
                this.Connection.Open();
                trans = this.Connection.BeginTransaction();

                string middleName = player.MiddleName == "" ? null : player.MiddleName;

                const string InsertString =
                    @"insert into person (first_name, middle_name, last_name, gender, birth_date) values (@first_name, @middle_name, @last_name, @gender, @birth_date);";
                MySqlCommand command =
                    new MySqlCommand(InsertString, this.Connection)
                    {
                        Parameters =
                        {
                            new MySqlParameter("@first_name", MySqlDbType.VarChar) { Value = player.FirstName },
                            new MySqlParameter("@birth_date", MySqlDbType.DateTime) { Value = player.BirthDate },
                            new MySqlParameter("@last_name", MySqlDbType.VarChar) { Value = player.LastName},
                            new MySqlParameter("@middle_name", MySqlDbType.VarChar) { Value = middleName },
                            new MySqlParameter("@gender", MySqlDbType.VarChar) { Value = player.Gender }
                        }
                    };

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
                success = true;
            }
            catch (Exception e)
            {
                success = false;
                trans?.Rollback();
                Console.WriteLine("Adding Player failed. " + e.Message);
                MessageBox.Show("Speler toevoegen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            this.InsertPlayer(player);

            return success;
        }

        public void InsertPlayer(PlayerModel player)
        {
            MySqlTransaction trans = null;

            try
            {
                this.Connection.Open();
                trans = this.Connection.BeginTransaction();

                const string InsertString =
                    @"insert into player(id, postal_code, city, street, house_number, iban_number, rating) value (LAST_INSERT_ID(), @postal_code, @city, @street, @house_number, @iban_number, @rating)";
                MySqlCommand command =
                    new MySqlCommand(InsertString, this.Connection)
                    {
                        Parameters =
                                {
                                    new MySqlParameter("@postal_code", MySqlDbType.VarChar) { Value = player.PostalCode },
                                    new MySqlParameter("@city", MySqlDbType.VarChar) { Value = player.City },
                                    new MySqlParameter("@street", MySqlDbType.VarChar) { Value = player.Street },
                                    new MySqlParameter("@house_number", MySqlDbType.VarChar) { Value = player.HouseNumber },
                                    new MySqlParameter("@iban_number", MySqlDbType.VarChar) { Value = player.IbanNumber },
                                    new MySqlParameter("@rating", MySqlDbType.Int32) { Value = player.Rating }
                                }
                    };

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception e)
            {
                trans?.Rollback();
                Console.WriteLine("Adding Player failed. " + e.Message);
                MessageBox.Show("Speler toevoegen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }
        }

        /// <summary>
        /// Get all Players that are in a tournament
        /// </summary>
        /// <param name="playerId">ID of the player</param>
        /// <returns>List of player emails</returns>
        public List<string> GetEmails(int playerId)
        {
            List<string> emails = new List<string>();

            try
            {
                this.Connection.Open();

                string query = $@"SELECT * FROM person_email WHERE id = { playerId }";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    emails.Add(reader.GetString("email_address"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching email addresses failed. " + e.Message);
                MessageBox.Show("Ophalen email adressen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            return emails;
        }

        /// <summary>
        /// Get all Players that are in a tournament
        /// </summary>
        /// <param name="playerId">ID of the player</param>
        /// <returns>List of phone numbers</returns>
        public List<string> GetPhoneNumbers(int playerId)
        {
            List<string> phonenumbers = new List<string>();

            try
            {
                this.Connection.Open();

                string query = $@"SELECT * FROM person_phone WHERE id = { playerId }";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    phonenumbers.Add(reader.GetString("phone_number"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching phone numbers failed. " + e.Message);
                MessageBox.Show("Ophalen telefoon nummers is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            return phonenumbers;
        }
    }
}