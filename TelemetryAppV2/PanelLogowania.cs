using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelemetryAppV2
{
    public partial class PanelLogowania : UserControl
    {
        public delegate void ZalogujButtonClickEventHandler(object sender, EventArgs e);

        public event EventHandler ZalogujButtonClick;

        private DBConnect _dbConnect;
        private MySqlCommand _mySqlCommand;

        public PanelLogowania()
        {
            InitializeComponent();
        }

        private void zalogujButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
            {
                loginBox.BackColor = Color.Red;
                infoLabel.ForeColor = Color.Red;
                infoLabel.Text = "Uzupełnij wymagane pola";
            }
            if (hasloBox.Text == "")
            {
                hasloBox.BackColor = Color.Red;
                infoLabel.ForeColor = Color.Red;
                infoLabel.Text = "Uzupełnij wymagane pola";
            }
            if (loginBox.Text != "" && hasloBox.Text != "")
            {
                string login = loginBox.Text;
                string haslo = hasloBox.Text;
                if (sprawdzLogin(login) == 1 && sprawdzHaslo(haslo) == 1)
                {
                    if (ZalogujButtonClick != null)
                    {
                        ZalogujButtonClick(this, e);
                    }
                }
                else
                {
                    infoLabel.Text = "Wpisano zły login lub hasło";
                }
            }
        }

        public class User
        {
            public string loginUser { get; set; }
        }

        private void PanelLogowania_Load(object sender, EventArgs e)
        {
            _dbConnect = new DBConnect();
            _dbConnect.Open();
        }

        private bool CzyTextBoxPusty(TextBox nazwaTextBox)
        {
            bool wynik;
            if (nazwaTextBox.Text.Length < 1)
            {
                nazwaTextBox.BackColor = Color.Red;
                infoLabel.ForeColor = Color.Red;
                infoLabel.Text = "Uzupełnij wymagane pola";
                wynik = false;
            }
            else
            {
                nazwaTextBox.BackColor = Color.White;
                infoLabel.Text = "";
                wynik = true;
            }
            return wynik;
        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            zalogujButton.Enabled = CzyTextBoxPusty(loginBox);
        }

        private void loginBox_DoubleClick(object sender, EventArgs e)
        {
            zalogujButton.Enabled = CzyTextBoxPusty(loginBox);
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            zalogujButton.Enabled = CzyTextBoxPusty(loginBox);
        }

        private void hasloBox_Click(object sender, EventArgs e)
        {
            zalogujButton.Enabled = CzyTextBoxPusty(hasloBox);
        }

        private void hasloBox_DoubleClick(object sender, EventArgs e)
        {
            zalogujButton.Enabled = CzyTextBoxPusty(hasloBox);
        }

        private void hasloBox_TextChanged(object sender, EventArgs e)
        {
            zalogujButton.Enabled = CzyTextBoxPusty(hasloBox);
        }

        private int sprawdzLogin(string login)
        {
            string stm = "SELECT COUNT(login) FROM aso_users WHERE login = @login";
            _mySqlCommand = new MySqlCommand(stm, _dbConnect.connection);
            _mySqlCommand.Parameters.AddWithValue("@login", login);
            return Convert.ToInt32(_mySqlCommand.ExecuteScalar());
        }

        private int sprawdzHaslo(string haslo)
        {
            string stm = "SELECT COUNT(password) FROM aso_users WHERE password = @password";
            _mySqlCommand = new MySqlCommand(stm, _dbConnect.connection);
            _mySqlCommand.Parameters.AddWithValue("@password", haslo);
            return Convert.ToInt32(_mySqlCommand.ExecuteScalar());
        }
    }
}