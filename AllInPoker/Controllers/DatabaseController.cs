namespace AllInPoker.Controllers
{
    using MySql.Data.MySqlClient;
    using System.Configuration;

    public class DatabaseController
    {
        protected MySqlConnection Connection { get; set; }

        /// <summary>
        /// Create DatabaseController
        /// </summary>
        public DatabaseController()
        {
            string server = ConfigurationManager.AppSettings["server"];
            string database = ConfigurationManager.AppSettings["database"];
            string uid = ConfigurationManager.AppSettings["uid"];
            string password = ConfigurationManager.AppSettings["password"];
            this.Connection = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={password}");
        }
    }
}