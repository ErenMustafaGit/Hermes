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
    public partial class AjoutParticipant : UserControl
    {
        private static Panel bulle;
        private static Panel pnlPrincipal;
        public Panel setPanelBulle
        {
            set { bulle = value; }
        }
        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }

        public AjoutParticipant()
        {
            InitializeComponent();
            lblIconeAjoutParticipant.Text = Hermes.UI.Icons.PLUS;
        }



        private void AjoutParticipant_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
            pictureBox1.MouseHover += new System.EventHandler(LblIconeAjoutParticipant_MouseHover);
            pictureBox1.MouseClick += new MouseEventHandler(LblIconeAjoutParticipant_MouseClick);
            pictureBox1.MouseLeave += new System.EventHandler(LblIconeAjoutParticipant_MouseLeave);
        }



        private delegate void Stop();

        public static void DelegateMethodAnnuler()
        {
            bulle.Controls.Clear();
            bulle.Visible = false;
        }


        private void LblIconeAjoutParticipant_MouseClick(object sender, MouseEventArgs e)
        {
            BulleAjParticipant bulleAjParticipant = new BulleAjParticipant();
            bulle.BringToFront();
            //Donne l'action au bouton annuler
            Stop annuler = DelegateMethodAnnuler;
            bulleAjParticipant.Annuler = annuler;

            //Donne le panel qui contiendra la bulle d'ajout rapide
            bulleAjParticipant.SetPanel = bulle;
            bulleAjParticipant.SetEcran = pnlPrincipal;

            bulle.Controls.Add(bulleAjParticipant);
            bulle.Visible = true;


        }

        private void LblIconeAjoutParticipant_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblIconeAjoutParticipant.ForeColor = ColorTranslator.FromHtml("#2693f8");
        }

        private void LblIconeAjoutParticipant_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblIconeAjoutParticipant.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void AjoutParticipant_MouseHover(object sender, EventArgs e)
        {
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
