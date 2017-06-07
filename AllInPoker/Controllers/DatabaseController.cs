namespace AllInPoker.Controllers
{
    using MySql.Data.MySqlClient;

    public class DatabaseController
    {
        protected MySqlConnection Connection { get; set; }

        /// <summary>
        /// Create DatabaseController
        /// </summary>
        /// <param name="server">Server IP or URL</param>
        /// <param name="database">Database Name</param>
        /// <param name="uid">Login UID</param>
        /// <param name="password">Login Password</param>
        public DatabaseController(string server, string database, string uid, string password)
        {
            this.Connection = new MySqlConnection($"Server={server};Database={database};Uid={uid}; Pwd={password}");
        }
    }
}
