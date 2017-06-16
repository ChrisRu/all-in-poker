namespace AllInPoker.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using AllInPoker.Models;

    using MySql.Data.MySqlClient;

    public class EventLocationController : DatabaseController
    {
        public List<EventLocationModel> GetEventLocations()
        {
            List<EventLocationModel> locations = new List<EventLocationModel>();

            try
            {
                this.Connection.Open();

                string query = @"SELECT * FROM tournament ORDER BY date DESC";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    locations.Add(new EventLocationModel
                    {
                        Id = reader.GetInt32("id"),
                        MaxPlayers = reader.GetInt32("max_players"),
                        PostalCode = reader.GetString("postal_code"),
                        City = reader.GetString("city"),
                        Street = reader.GetString("street"),
                        HouseNumber = reader.GetString("house_number")
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

            return locations;
        }

        public EventLocationModel GetEventLocation(int locationId)
        {
            EventLocationModel eventLocation = null;

            try
            {
                this.Connection.Open();

                string query = $@"SELECT * FROM event_location WHERE id = {locationId}";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    eventLocation = new EventLocationModel
                    {
                        Id = reader.GetInt32("id"),
                        MaxPlayers = reader.GetInt32("max_players"),
                        PostalCode = reader.GetString("postal_code"),
                        City = reader.GetString("city"),
                        Street = reader.GetString("street"),
                        HouseNumber = reader.GetString("house_number")
                    };
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

            return eventLocation;
        }

        public bool CreateEventLocation(EventLocationModel location)
        {
            MySqlTransaction trans = null;
            bool success;

            try
            {
                this.Connection.Open();
                trans = this.Connection.BeginTransaction();

                const string InsertString =
                    @"insert into event_location (max_players, postal_code, city, street, house_number) values (@max_players, @postal_code, @city, @street, @house_number);";
                MySqlCommand command =
                    new MySqlCommand(InsertString, this.Connection)
                        {
                            Parameters =
                                {
                                    new MySqlParameter(
                                        "@max_players",
                                        MySqlDbType.Int32)
                                        {
                                            Value
                                                = location
                                                    .MaxPlayers
                                        },
                                    new MySqlParameter(
                                        "@postal_code",
                                        MySqlDbType.VarChar)
                                        {
                                            Value
                                                = location
                                                    .PostalCode
                                        },
                                    new MySqlParameter(
                                        "@city",
                                        MySqlDbType.VarChar)
                                        {
                                            Value
                                                = location
                                                    .City
                                        },
                                    new MySqlParameter(
                                        "@street",
                                        MySqlDbType.VarChar)
                                        {
                                            Value
                                                = location
                                                    .Street
                                        },
                                    new MySqlParameter(
                                        "@house_number",
                                        MySqlDbType.VarChar)
                                        {
                                            Value
                                                = location
                                                    .HouseNumber
                                        }
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
                Console.WriteLine("Adding location failed. " + e.Message);
                MessageBox.Show("Locatie toevoegen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            return success;
        }
    }
}