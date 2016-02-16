using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Timers;
using System.Windows.Forms;

namespace TelemetryAppV2
{
    public class FunkcjeGlobalne
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        private string _json;
        private string _jsonString;
        private WebClient wc = new WebClient();
        private SpeechSynthesizer lektor = new SpeechSynthesizer();

        public bool sprawdzPolaczenieInternetowe()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        public bool CzyWlaczonySerwerTelemetrii()
        {
            try
            {
                _json = wc.DownloadString(new Uri("http://localhost:25555/api/ets2/telemetry"));
                return true;
            }
            catch (Exception e)
            {
                _json = e.Message;
                return false;
            }
        }

        public string PobierzDaneTelemetrii()
        {
            try
            {
                _jsonString = wc.DownloadString(new Uri("http://localhost:25555/api/ets2/telemetry"));
            }
            catch (Exception e)
            {
                _jsonString = e.Message;
            }
            return _jsonString;
        }

        public void PrzypiszDaneTelemetrii(object source, ElapsedEventArgs e)
        {
            string json = PobierzDaneTelemetrii();
            JObject dane = new JObject();
            dane = JObject.Parse(json);
            ZmienneGlobalne.Truck.speed = Convert.ToInt32(dane["truck"]["engineRpm"]);
        }

        public bool CzyTextBoxPusty(TextBox nazwaTextBox)
        {
            bool wynik;
            if (nazwaTextBox.Text.Length < 1)
            {
                nazwaTextBox.BackColor = Color.Red;
                wynik = false;
            }
            else
            {
                nazwaTextBox.BackColor = Color.White;
                wynik = true;
            }
            return wynik;
        }

        public void CzytajText(string tekst)
        {
            lektor.SpeakAsync(tekst);
        }

        public void ButtonEnabled(Button przycisk, bool stan)
        {
            przycisk.Enabled = stan;
        }

        public void LabelForeColor(Label label, Color kolor)
        {
            label.ForeColor = kolor;
        }

        public void TextBoxBackColor(TextBox textbox, Color kolor)
        {
            textbox.BackColor = kolor;
        }

        public void LabelText(Label label, string tekst)
        {
            label.Text = tekst;
        }
    }
}