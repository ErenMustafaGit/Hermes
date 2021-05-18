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
    public partial class AjNouvelleDepense : UserControl
    {
        Panel ecran;
        int indice;
        public AjNouvelleDepense(int indice)
        {
            InitializeComponent();
            this.indice = indice;
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void AjNouvelleDepense_Load(object sender, EventArgs e)
        {
            Database base_de_donnee = new Database();
            List<PartyEvent> evenement = base_de_donnee.FetchEvents();
            foreach (PartyEvent ee in evenement)
            {
                cbbEvenement.Items.Add(ee.TitleEvent.ToString());
            }
            cbbEvenement.SelectedIndex = this.indice;
        }

        private void cbbEvenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Database base_de_donnee = new Database();
            List<PartyEvent> evenement = base_de_donnee.FetchEvents();
            foreach (PartyEvent ee in evenement)
            {
                cbbPayéPar.Items.Add(ee.TitleEvent.ToString());
            }
            cbbEvenement.SelectedIndex = this.indice;
            */
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {
            dtpFin.MinDate = dtpDebut.Value;
        }

        private void appFontLabel7_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string message = "Voulez vous vraiment annuler l'ajout ?";
            string caption = "";
            result = result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                this.ecran.Controls.Clear();
                Accueil a = new Accueil();
                a.setPanel = this.ecran;
                this.ecran.Controls.Add(a);
            }
            
        }

        private void appFontLabel7_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblAnnuler_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
