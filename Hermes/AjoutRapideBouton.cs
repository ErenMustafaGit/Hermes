using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hermes
{
    public partial class AjoutRapideBouton : UserControl
    {
        Panel ecran;

        public AjoutRapideBouton()
        {
            InitializeComponent();
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        //public string setEvenement

        private void AjoutRapideBouton_Load(object sender, EventArgs e)
        {
            Database base_de_donnee = new Database();
            
            List<PartyEvent> evenement = base_de_donnee.FetchEvents();
            foreach(PartyEvent ee in evenement)
            {
                cbbEvenements.Items.Add(ee.TitleEvent.ToString());
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            if(cbbEvenements.SelectedIndex != -1)
            {
                this.ecran.Controls.Clear();
                AjNouvelleDepense aj = new AjNouvelleDepense(cbbEvenements.SelectedIndex);
                aj.setPanel = this.ecran;
                this.ecran.Controls.Add(aj);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un évènement !");
            }
            
           
        }

        private void appFontLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
