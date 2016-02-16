using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TelemetryAppV2
{
    public class DBConnect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;

        public DBConnect()
        {
            server = "goldenteam.home.pl";
            database = "09388446_0000001";
            uid = "09388446_0000001";
            password = "jNvz^*^Mf.xe";
            connectionString = "SERVER = " + server + ";" + "DATABASE = " + database + ";" + "UID = " + uid + ";" + "PASSWORD = " + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public void Open()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Close()
        {
            connection.Close();
        }
    }
}