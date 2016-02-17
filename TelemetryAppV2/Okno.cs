using System;
using System.Windows.Forms;

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
            mainPanel.Controls.Add(panelLogowania);
        }

        private void PanelLogowania_ZalogujButtonClick(object sender, EventArgs e)
        {
            panelLogowania.Visible = false;
            PanelUzytkownika panelUzytkownika = new PanelUzytkownika();
            mainPanel.Controls.Add(panelUzytkownika);
        }

        private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void twórcyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Danix6");
        }
    }
}