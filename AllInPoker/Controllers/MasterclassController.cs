namespace AllInPoker.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using AllInPoker.Models;

    using MySql.Data.MySqlClient;

    public class MasterclassController : DatabaseController
    {
        /// <summary>
        /// Get all Masterclasss in a list
        /// </summary>
        /// <returns>List with MasterclassItems</returns>
        public List<MasterclassModel> GetMasterclasses()
        {
            List<MasterclassModel> masterclasses = new List<MasterclassModel>();
            EventLocationController eventLocationController = new EventLocationController();
            ProfessionalController professionalController = new ProfessionalController();

            try
            {
                this.Connection.Open();

                string query = @"SELECT * FROM masterclass ORDER BY date DESC";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    masterclasses.Add(new MasterclassModel
                    {
                        Id = reader.GetInt32("id"),
                        Date = reader.GetDateTime("date").ToLocalTime(),
                        MinPlayers = reader.GetInt32("min_players"),
                        MinRating = reader.GetInt32("min_rating"),
                        LocationId = reader.GetInt32("location_id"),
                        ProfessionalId = reader.GetInt32("professional_id")
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching Masterclasss failed. " + e.Message);
                MessageBox.Show("Masterclassen ophalen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            foreach (MasterclassModel masterclass in masterclasses)
            {
                masterclass.Location = eventLocationController.GetEventLocation(masterclass.Id);
                masterclass.Professional = professionalController.GetProfessional(masterclass.ProfessionalId);
                masterclass.Entries = this.GetMasterclassEntries(masterclass.Id);
            }

            return masterclasses;
        }

        public void CreateMasterclass(
            DateTime date,
            decimal cost,
            int minPlayers,
            int minAge,
            int maxAge,
            int locationId,
            int winnerId)
        {
            /*
            MySqlTransaction trans = null;

            try
            {
                this.Connection.Open();
                trans = this.Connection.BeginTransaction();

                const string InsertString = @"INSERT INTO masterclass (date, time, cost, min_players, min_age, max_age, location_id, winner_id) VALUES (@date, @time, @cost, @min_players, @min_age, @location_id, @winner_id)";

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
                Console.WriteLine("Adding Masterclass failed. " + e.Message);
                MessageBox.Show("Masterclass toevoegen mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }*/
        }

        public List<MasterclassEntryModel> GetMasterclassEntries(int masterclassId)
        {
            List<MasterclassEntryModel> entries = new List<MasterclassEntryModel>();

            try
            {
                this.Connection.Open();

                string query = $@"SELECT * FROM masterclass_entry WHERE masterclass_id = { masterclassId }";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    entries.Add(new MasterclassEntryModel
                                   {
                                        PlayerId = reader.GetInt32("player_id"),
                                        MasterclassId = reader.GetInt32("masterclass_id"),
                                        Date = reader.GetDateTime("date"),
                                        HasPaid = reader.GetBoolean("has_paid")
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

            return entries;
        }
    }
}