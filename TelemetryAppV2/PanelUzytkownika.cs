using System.Windows.Forms;

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
        }
    }
}