using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TelemetryAppV2
{
    public class DBConnect
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;
        private MySqlConnection connection;
        private MySqlCommand _mySqlCommand;
        private FunkcjeGlobalne _funkcjeGlobalne = new FunkcjeGlobalne();

        public DBConnect()
        {
            server = "goldenteam.home.pl";
            database = "09388446_0000001";
            uid = "09388446_0000001";
            password = "jNvz^*^Mf.xe";
            connectionString = "SERVER = " + server + ";" + "DATABASE = " + database + ";" + "UID = " + uid + ";" + "PASSWORD = " + password + ";";
            connection = new MySqlConnection(connectionString);
            Open();
        }

        public void Open()
        {
            if (_funkcjeGlobalne.sprawdzPolaczenieInternetowe() == true)
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
        }

        public void Close()
        {
            connection.Close();
        }

        public int sprawdzLogin(string login)
        {
            string stm = "SELECT COUNT(login) FROM aso_users WHERE login = @login";
            _mySqlCommand = new MySqlCommand(stm, connection);
            _mySqlCommand.Parameters.AddWithValue("@login", login);
            return Convert.ToInt32(_mySqlCommand.ExecuteScalar());
        }

        public int sprawdzHaslo(string haslo)
        {
            string stm = "SELECT COUNT(password) FROM aso_users WHERE password = @password";
            _mySqlCommand = new MySqlCommand(stm, connection);
            _mySqlCommand.Parameters.AddWithValue("@password", haslo);
            return Convert.ToInt32(_mySqlCommand.ExecuteScalar());
        }
    }
}