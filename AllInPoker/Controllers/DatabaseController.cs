namespace AllInPoker.Controllers
{
    using MySql.Data.MySqlClient;

    public class DatabaseController
    {
        protected MySqlConnection Connection { get; set; }

        /// <summary>
        /// Create DatabaseController
        /// </summary>
        public DatabaseController()
        {
            const string Server = "localhost";
            const string Database = "allin_poker";
            const string Uid = "root";
            const string Password = "root";
            this.Connection = new MySqlConnection($"Server={Server};Database={Database};Uid={Uid};Pwd={Password}");
        }
    }
}