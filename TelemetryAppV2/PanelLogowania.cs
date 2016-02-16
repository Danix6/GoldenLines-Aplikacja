using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace TelemetryAppV2
{
    public partial class PanelLogowania : UserControl
    {
        public delegate void ZalogujButtonClickEventHandler(object sender, EventArgs e);

        public event EventHandler ZalogujButtonClick;

        private DBConnect _dbConnect = new DBConnect();
        private FunkcjeGlobalne _funkcjeGlobalne = new FunkcjeGlobalne();

        public PanelLogowania()
        {
            InitializeComponent();
        }

        private void PanelLogowania_Load(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.sprawdzPolaczenieInternetowe() == true)
            {
                _funkcjeGlobalne.LabelForeColor(statusLabel_Info, Color.Green);
                _funkcjeGlobalne.LabelText(statusLabel_Info, "Online");
            }
            else
            {
                _funkcjeGlobalne.LabelForeColor(statusLabel, Color.Red);
                _funkcjeGlobalne.LabelText(statusLabel, "Offline");
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Brak połączenia internetowego");
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
            }
        }

        private void zalogujButton_Click(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.CzyTextBoxPusty(loginBox) == false)
            {
                _funkcjeGlobalne.TextBoxBackColor(loginBox, Color.Red);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
            }
            if (_funkcjeGlobalne.CzyTextBoxPusty(hasloBox) == false)
            {
                _funkcjeGlobalne.TextBoxBackColor(loginBox, Color.Red);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
            }
            if (_funkcjeGlobalne.CzyTextBoxPusty(loginBox) == true && _funkcjeGlobalne.CzyTextBoxPusty(hasloBox) == true)
            {
                string login = loginBox.Text;
                string haslo = hasloBox.Text;
                if (_dbConnect.sprawdzLogin(login) == 1 && _dbConnect.sprawdzHaslo(haslo) == 1)
                {
                    if (ZalogujButtonClick != null)
                    {
                        if (_funkcjeGlobalne.CzyWlaczonySerwerTelemetrii() == true)
                        {
                            Timer JSONTimer = new Timer();
                            JSONTimer.Elapsed += new ElapsedEventHandler(_funkcjeGlobalne.PrzypiszDaneTelemetrii);
                            JSONTimer.Interval = 1000;
                            JSONTimer.Enabled = true;
                            ZmienneGlobalne.User.login = loginBox.Text;
                            ZalogujButtonClick(this, EventArgs.Empty);
                        }
                        else
                        {
                            _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                            _funkcjeGlobalne.LabelText(infoLabel, "Brak włączonego serwera telemetrii");
                        }
                    }
                }
                else
                {
                    _funkcjeGlobalne.LabelText(infoLabel, "Wpisano zły login lub hasło");
                }
            }
        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.CzyTextBoxPusty(loginBox) == true)
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, true);
                _funkcjeGlobalne.LabelText(infoLabel, "");
            }
            else
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
            }
        }

        private void loginBox_DoubleClick(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.CzyTextBoxPusty(loginBox) == true)
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, true);
                _funkcjeGlobalne.LabelText(infoLabel, "");
            }
            else
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
            }
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.CzyTextBoxPusty(loginBox) == true)
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, true);
                _funkcjeGlobalne.LabelText(infoLabel, "");
            }
            else
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
            }
        }

        private void loginBox_Enter(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.CzyTextBoxPusty(loginBox) == true)
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, true);
                _funkcjeGlobalne.LabelText(infoLabel, "");
            }
            else
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
            }
        }

        private void loginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                zalogujButton.PerformClick();
            }
        }

        private void hasloBox_Click(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.CzyTextBoxPusty(hasloBox) == true)
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, true);
                _funkcjeGlobalne.LabelText(infoLabel, "");
            }
            else
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
            }
        }

        private void hasloBox_DoubleClick(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.CzyTextBoxPusty(hasloBox) == true)
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, true);
                _funkcjeGlobalne.LabelText(infoLabel, "");
            }
            else
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
            }
        }

        private void hasloBox_TextChanged(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.CzyTextBoxPusty(hasloBox) == true)
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, true);
                _funkcjeGlobalne.LabelText(infoLabel, "");
            }
            else
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
            }
        }

        private void hasloBox_Enter(object sender, EventArgs e)
        {
            if (_funkcjeGlobalne.CzyTextBoxPusty(hasloBox) == true)
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, true);
                _funkcjeGlobalne.LabelText(infoLabel, "");
            }
            else
            {
                _funkcjeGlobalne.ButtonEnabled(zalogujButton, false);
                _funkcjeGlobalne.LabelForeColor(infoLabel, Color.Red);
                _funkcjeGlobalne.LabelText(infoLabel, "Uzupełnij wymagane pola");
            }
        }

        private void hasloBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                zalogujButton.PerformClick();
            }
        }
    }
}