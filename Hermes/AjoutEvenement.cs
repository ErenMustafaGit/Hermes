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

            lblAdd.Location = new Point(
                (this.Width - lblAdd.Width) / 2,
                (this.Height - lblAdd.Height) / 2);
        }

        private void AjoutEvenement_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
            this.MouseClick += new MouseEventHandler(LblAdd_MouseClick);
            

            foreach(Control control in this.Controls)
            {
                control.MouseEnter += new System.EventHandler(AjoutEvenement_MouseEnter);
                control.MouseLeave += new System.EventHandler(AjoutEvenement_MouseLeave);
                control.MouseClick += new MouseEventHandler(LblAdd_MouseClick);
            }
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

        }

        private void LblAdd_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void AjoutEvenement_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void appFontLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblAdd_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void AjoutEvenement_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblAdd.ForeColor = ColorTranslator.FromHtml("#2693f8");
        }

        private void AjoutEvenement_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblAdd.ForeColor = Color.FromArgb(12, 12, 12);
        }
    }
}
