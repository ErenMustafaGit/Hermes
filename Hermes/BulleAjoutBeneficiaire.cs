using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes
{
    public partial class BulleAjoutBeneficiaire : UserControl
    {
        private static Panel pnlBulleEmplacement;
        private static Panel pnlPrincipal;
        public Panel setPanel
        {
            set { pnlBulleEmplacement = value; }
        }

        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }

        public BulleAjoutBeneficiaire()
        {
            InitializeComponent();
        }

        private void BulleAjoutBeneficiaire_Load(object sender, EventArgs e)
        {

        }

        private void lblBeneficiaire_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlBulleEmplacement.Controls.Clear();
            pnlBulleEmplacement.Visible = false;
        }
    }
}
