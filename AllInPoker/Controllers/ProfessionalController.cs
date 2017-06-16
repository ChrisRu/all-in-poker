namespace AllInPoker.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using AllInPoker.Models;

    using MySql.Data.MySqlClient;

    public class ProfessionalController : DatabaseController
    {
        /// <summary>
        /// Get all Masterclasss in a list
        /// </summary>
        /// <returns>List with Players</returns>
        public List<ProfessionalModel> GetProfessionals()
        {
            List<ProfessionalModel> professionals = new List<ProfessionalModel>();

            try
            {
                this.Connection.Open();

                string query = @"SELECT * FROM professional ORDER BY last_name DESC";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    professionals.Add(new ProfessionalModel
                                    {
                                        Id = reader.GetInt32("id"),
                                        BirthDate = reader.GetDateTime("birth_date"),
                                        FirstName = reader.GetString("first_name"),
                                        MiddleName = reader.GetString("middle_name"),
                                        LastName = reader.GetString("last_name"),
                                        Gender = reader.GetChar("gender"),
                                        Nationality = reader.GetString("nationality")
                                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching professionals failed. " + e.Message);
                MessageBox.Show("Professionals ophalen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            foreach (ProfessionalModel professional in professionals)
            {
                professional.Emails = this.GetEmails(professional.Id);
                professional.PhoneNumbers = this.GetPhoneNumbers(professional.Id);
            }

            return professionals;
        }

        /// <summary>
        /// Get all Masterclasss in a list
        /// </summary>
        /// <returns>List with Players</returns>
        public ProfessionalModel GetProfessional(int professionalId)
        {
            ProfessionalModel professional = null;

            try
            {
                this.Connection.Open();

                string query = $@"SELECT * FROM professional LEFT JOIN person ON professional.id = person.id WHERE professional.id = { professionalId }";
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    professional = new ProfessionalModel
                                          {
                                              Id = reader.GetInt32("id"),
                                              BirthDate = reader.GetDateTime("birth_date"),
                                              FirstName = reader.GetString("first_name"),
                                              MiddleName = reader["middle_name"] == DBNull.Value ? string.Empty : reader.GetString("middle_name"),
                                              LastName = reader.GetString("last_name"),
                                              Gender = reader.GetChar("gender"),
                                              Nationality = reader.GetString("nationality")
                                          };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fetching professionals failed. " + e.Message);
                MessageBox.Show("Professionals ophalen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            if (professional != null)
            {
                professional.Emails = this.GetEmails(professional.Id);
                professional.PhoneNumbers = this.GetPhoneNumbers(professional.Id);
            }

            return professional;
        }

        /// <summary>
        /// Get all Players that are in a tournament
        /// </summary>
        /// <param name="playerId">ID of the professional</param>
        /// <returns>List of professional emails</returns>
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
        /// <param name="playerId">ID of the professional</param>
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

        public bool CreateProfessional(ProfessionalModel professional)
        {
            MySqlTransaction trans = null;
            bool success;

            try
            {
                this.Connection.Open();
                trans = this.Connection.BeginTransaction();

                string middleName = professional.MiddleName == "" ? null : professional.MiddleName;

                const string InsertString =
                    @"insert into person (first_name, middle_name, last_name, gender, birth_date) values (@first_name, @middle_name, @last_name, @gender, @birth_date);";
                MySqlCommand command =
                    new MySqlCommand(InsertString, this.Connection)
                        {
                            Parameters =
                                {
                                    new MySqlParameter("@first_name", MySqlDbType.VarChar) { Value = professional.FirstName },
                                    new MySqlParameter("@birth_date", MySqlDbType.DateTime) { Value = professional.BirthDate },
                                    new MySqlParameter("@last_name", MySqlDbType.VarChar) { Value = professional.LastName},
                                    new MySqlParameter("@middle_name", MySqlDbType.VarChar) { Value = middleName },
                                    new MySqlParameter("@gender", MySqlDbType.VarChar) { Value = professional.Gender }
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
                Console.WriteLine("Adding person failed. " + e.Message);
                MessageBox.Show("Persoon toevoegen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }

            this.InsertProfessional(professional);

            return success;
        }

        public void InsertProfessional(ProfessionalModel professional)
        {
            MySqlTransaction trans = null;

            try
            {
                this.Connection.Open();
                trans = this.Connection.BeginTransaction();

                const string InsertString =
                    @"insert into professional(id, nationality) value (LAST_INSERT_ID(), @nationality)";
                MySqlCommand command =
                    new MySqlCommand(InsertString, this.Connection)
                        {
                            Parameters =
                                {
                                    new MySqlParameter("@nationality", MySqlDbType.VarChar) { Value = professional.Nationality }
                                }
                        };

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception e)
            {
                trans?.Rollback();
                Console.WriteLine("Adding professional failed. " + e.Message);
                MessageBox.Show("Professional toevoegen is mislukt.");
            }
            finally
            {
                this.Connection.Close();
            }
        }
    }
}
