using System;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace TelemetryAppV2
{
    public partial class PanelUzytkownika : UserControl
    {
        public Okno _okno { private set; get; }
        private FunkcjeGlobalne _funkcjeGlobalne = new FunkcjeGlobalne();

        public PanelUzytkownika()
        {
            InitializeComponent();
        }

        public void SetForm(Okno nazwa)
        {
            _okno = nazwa;
        }

        private void PanelUzytkownika_Load(object sender, System.EventArgs e)
        {
            _funkcjeGlobalne.CzytajText("Witamy w Automatycznym Systemie Obsługi GoldenLines");
            Timer JSONTimer = new Timer();
            JSONTimer.Elapsed += new ElapsedEventHandler(Odczytaj);
            JSONTimer.Interval = 1000;
            JSONTimer.Enabled = true;
        }

        private void Odczytaj(object source, ElapsedEventArgs e)
        {
            //label1.Invoke((MethodInvoker)(() => label1.Text = ZmienneGlobalne.Game.time));
        }
    }
}