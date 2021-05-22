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
    public partial class SideBarUserControls : UserControl
    {
        private Panel ecrans;

        public SideBarUserControls()
        {
            InitializeComponent();
            lblIconeAccueil.Text = Hermes.UI.Icons.HOME;
            lblIconeEvenement.Text = Hermes.UI.Icons.CALENDAR_1;
            lblIconeParticipant.Text = Hermes.UI.Icons.USER_GROUP;
            lblIconeDepense.Text = Hermes.UI.Icons.MONEY_BAG;
            lblIconeBilan.Text = Hermes.UI.Icons.CLIPBOARD;
        }

        public Panel setPanel
        {
            set { this.ecrans = value; }
        }

        public Panel getSideBar
        {
            get => this.sideBar;
        }

     

        private void LblIconeAccueil_Click(object sender, EventArgs e)
        {
            this.ecrans.Controls.Clear();
            //Partie concerné par le changement de couleur en bleue
            lblIconeAccueil.ForeColor = ColorTranslator.FromHtml("#2693f8");
            lblAccueil.ForeColor = ColorTranslator.FromHtml("#2693f8"); 

            //Le reste en blanc
            lblIconeDepense.ForeColor = Color.FromArgb(249, 249, 249);
            lblDepenses.ForeColor = Color.FromArgb(249, 249, 249);
            lblIconeEvenement.ForeColor = Color.FromArgb(249, 249, 249);
            lblEvenements.ForeColor = Color.FromArgb(249, 249, 249);
            lblIconeParticipant.ForeColor = Color.FromArgb(249, 249, 249);
            lblParticipants.ForeColor = Color.FromArgb(249, 249, 249);

            //Apparaition du US concerné

            Accueil a = new Accueil();
            a.setPanel = this.ecrans;
            this.ecrans.Controls.Add(a);
        }

        private void LblIconeEvenement_Click(object sender, EventArgs e)
        {
            this.ecrans.Controls.Clear();
            //Partie concerné par le changement de couleur en bleu
            lblIconeEvenement.ForeColor = ColorTranslator.FromHtml("#2693f8");
            lblEvenements.ForeColor = ColorTranslator.FromHtml("#2693f8");

            //Le reste en blanc
            lblIconeAccueil.ForeColor = Color.FromArgb(249, 249, 249);
            lblAccueil.ForeColor = Color.FromArgb(249, 249, 249);
            lblIconeDepense.ForeColor = Color.FromArgb(249, 249, 249);
            lblDepenses.ForeColor = Color.FromArgb(249, 249, 249);
            lblIconeParticipant.ForeColor = Color.FromArgb(249, 249, 249);
            lblParticipants.ForeColor = Color.FromArgb(249, 249, 249);

            //Aparaition du US concerné
            Evenements ee = new Evenements();
            ee.setPanel = this.ecrans;
            this.ecrans.Controls.Add(ee);
        }

        private void SideBarUserControls_Load(object sender, EventArgs e)
        {
            lblIconeAccueil.ForeColor = ColorTranslator.FromHtml("#2693f8");
            lblAccueil.ForeColor = ColorTranslator.FromHtml("#2693f8");
        }

        private void AppFontLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LblBilan_Click(object sender, EventArgs e)
        {

        }

        private void LblAccueil_Click(object sender, EventArgs e)
        {

        }


        private void SideBarUserControls_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }

        private void LblIconeDepense_Click(object sender, EventArgs e)
        {
            this.ecrans.Controls.Clear();
            //Partie concerné par le changement de couleur en bleu
            lblIconeDepense.ForeColor = ColorTranslator.FromHtml("#2693f8");
            lblDepenses.ForeColor = ColorTranslator.FromHtml("#2693f8");

            //Le reste en blanc
            lblIconeAccueil.ForeColor = Color.FromArgb(249, 249, 249);
            lblAccueil.ForeColor = Color.FromArgb(249, 249, 249);
            lblEvenements.ForeColor = Color.FromArgb(249, 249, 249);
            lblIconeEvenement.ForeColor = Color.FromArgb(249, 249, 249);
            lblIconeParticipant.ForeColor = Color.FromArgb(249, 249, 249);
            lblParticipants.ForeColor = Color.FromArgb(249, 249, 249);

            //Aparaition du US concerné
            ViewExpenditures expendituresView = new ViewExpenditures();
            expendituresView.setPanel = this.ecrans;
            this.ecrans.Controls.Add(expendituresView);
        }
    }
}
