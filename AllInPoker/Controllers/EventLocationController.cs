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
    }
}