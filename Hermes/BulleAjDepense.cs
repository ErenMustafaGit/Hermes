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
    public partial class BulleAjDepense : UserControl
    {

        //Panel où la bulle va être placer
        private static Panel pnlBulleEmplacement;
        
        //Panel où le form de fond va rester visible
        private static Panel pnlPrincipal;


        public Panel setPanel
        {
            set { pnlBulleEmplacement = value; }
        }


        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }


        public BulleAjDepense()
        {
            InitializeComponent();
        }


        private void BulleAjDepense_Load(object sender, EventArgs e)
        {

        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            //Suppression de la bulle
            pnlBulleEmplacement.Controls.Clear();
            pnlBulleEmplacement.Visible = false;

        }


        private void btnContinuer_Click(object sender, EventArgs e)
        {
            //Suppression de l'étape 1
            pnlBulleEmplacement.Controls.Clear();

            //Appartition de l'étape 2
            BulleAjDepense2 bulleAjDepense2 = new BulleAjDepense2();
            pnlBulleEmplacement.Controls.Add(bulleAjDepense2);
        }
    }
}
