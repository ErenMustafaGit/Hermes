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

            lblIconeAjoutParticipant.Location = new Point(
                (this.Width - lblIconeAjoutParticipant.Width) / 2,
                (this.Height - lblIconeAjoutParticipant.Height) / 2);
        }



        private void AjoutParticipant_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();

            foreach (Control control in this.Controls)
            {
                control.MouseEnter += new EventHandler(AjoutParticipant_MouseEnter);
                control.MouseLeave += new EventHandler(AjoutParticipant_MouseLeave);
                control.MouseClick += new MouseEventHandler(LblIconeAjoutParticipant_MouseClick);
            }
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

        private void AjoutParticipant_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblIconeAjoutParticipant.ForeColor = ColorTranslator.FromHtml("#2693f8");
        }

        private void AjoutParticipant_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblIconeAjoutParticipant.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
