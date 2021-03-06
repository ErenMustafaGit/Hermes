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
using Hermes.DataModel;
using Hermes.UI;

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
            FontFamily helvetica = FontManager.GetFontFamily(AppFont.HelveticaNeue);
            btnAjouter.Font = new Font(helvetica, 12);
            cboEvenements.Font = new Font(helvetica, cboEvenements.Font.Height);

            DataTable table = Database.FetchUncompletedEvents().ToDataTable();
            cboEvenements.DataSource = table;
            cboEvenements.DisplayMember = "Name";
            cboEvenements.ValueMember = "Id";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            if(cboEvenements.SelectedIndex != -1)
            {
                this.ecran.Controls.Clear();
                AjNouvelleDepense aj = new AjNouvelleDepense(int.Parse(cboEvenements.SelectedValue.ToString()));
                aj.setPanel = this.ecran;
                this.ecran.Controls.Add(aj);
            }
            else
            {
                AppToast.CreateErrorToast("Veuillez sélectionner un évènement !")
                    .SetDurationInSeconds(10)
                    .ShowToast();
            }
            
           
        }

        private void appFontLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
