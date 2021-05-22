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
        private static Panel bulle;
        public Panel setPanel
        {
            set { bulle = value; }
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
            bulle.Visible = true;
            bulle.BringToFront();
            BulleAjEvenement bulleAjEvenement = new BulleAjEvenement();

            //Donne l'action au bouton annuler
            Stop annuler = DelegateMethodAnnuler;
            bulleAjEvenement.Annuler = annuler;
            bulle.Controls.Add(bulleAjEvenement);

        }

        private delegate void Stop();

        public static void DelegateMethodAnnuler()
        {
            bulle.Controls.Clear();
            bulle.Visible = false;
        }


        private void LblAdd_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblAdd.ForeColor = ColorTranslator.FromHtml("#2693f8");
        }

        private void LblAdd_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblAdd.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void AjoutEvenement_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
