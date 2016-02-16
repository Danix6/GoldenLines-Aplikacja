using System.Windows.Forms;

namespace TelemetryAppV2
{
    public partial class PanelUzytkownika : UserControl
    {
        public Okno Okno { private set; get; }

        public PanelUzytkownika()
        {
            InitializeComponent();
        }

        public void SetForm(Okno nazwa)
        {
            Okno = nazwa;
        }
    }
}