using MySql.Data.MySqlClient;

namespace pfr
{
    class connector
    {

        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;userid=root;password=tomriddle1337;database=pfr_cases;port=3306");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection() => connection;
    }
}