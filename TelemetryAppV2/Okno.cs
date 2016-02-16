using Newtonsoft.Json.Linq;
using System;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace TelemetryAppV2
{
    public partial class Okno : Form
    {
        private PanelLogowania panelLogowania = new PanelLogowania();

        public Okno()
        {
            InitializeComponent();
        }

        private void Okno_Load(object sender, EventArgs e)
        {
            panelLogowania.ZalogujButtonClick += new EventHandler(PanelLogowania_ZalogujButtonClick);
            Controls.Add(panelLogowania);
            Timer JSONTimer = new Timer();
            JSONTimer.Elapsed += new ElapsedEventHandler(JSON);
            JSONTimer.Interval = 1000;
            JSONTimer.Enabled = true;
        }

        private void PanelLogowania_ZalogujButtonClick(object sender, EventArgs e)
        {
            panelLogowania.Visible = false;
            PanelUzytkownika panelUzytkownika = new PanelUzytkownika();
            Controls.Add(panelUzytkownika);
        }

        public void JSON(object source, ElapsedEventArgs e)
        {
            JSON js = new JSON();
            string json = js.DownloadJSON();
            JObject dane = new JObject();
            //dane = JObject.Parse(json);
            /*textBox1.Invoke((MethodInvoker)(() => textBox1.Clear()));
            textBox1.Invoke((MethodInvoker)(() => textBox1.AppendText(dane.ToString())));*/
        }
    }
}