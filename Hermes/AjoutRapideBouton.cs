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
            AjNouvelleDepense aj = new AjNouvelleDepense();
            aj.setPanel = this.ecran;
            if(cbbEvenements.SelectedIndex != -1)
            {
                this.ecran.Controls.Clear();
                this.ecran.Controls.Add(aj);
            }
            else
            {
                MessageBox.Show("Veuillez selectionener");
            }
            
           
        }
    }
}
