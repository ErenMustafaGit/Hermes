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
    public partial class AjoutEvenement : UserControl
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

        public AjoutEvenement()
        {
            InitializeComponent();
            lblAdd.Text = Hermes.UI.Icons.PLUS;
        }

        private void AjoutEvenement_Load(object sender, EventArgs e)
        {

        }

        private void LblAdd_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBulleEmplacement.Visible = true;
            pnlBulleEmplacement.BringToFront();

            BulleAjEvenement bulleAjEvenement = new BulleAjEvenement();
            //Donne l'action au bouton annuler
            Stop annuler = DelegateMethodAnnuler;
            bulleAjEvenement.Annuler = annuler;
            bulleAjEvenement.setPanel = pnlBulleEmplacement;
            bulleAjEvenement.setPanelPrincipal = pnlPrincipal;
            pnlBulleEmplacement.Controls.Add(bulleAjEvenement);

        }

        private delegate void Stop();

        public static void DelegateMethodAnnuler()
        {
            pnlBulleEmplacement.Controls.Clear();
            pnlBulleEmplacement.Visible = false;
        }


        private void LblAdd_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LblAdd_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
