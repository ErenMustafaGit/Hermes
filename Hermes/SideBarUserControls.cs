﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hermes.DataModel;
using Hermes.UI;

namespace Hermes
{
    public partial class SideBarUserControls : UserControl
    {
        private Panel ecrans;
        private static Color BLUE = ColorTranslator.FromHtml("#2693f8");
        private static Color WHITE = Color.FromArgb(249, 249, 249);

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

        public SideBarUserControls getSideBar
        {
            get => this;
        }



        private void LblIconeAccueil_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

            this.ecrans.Controls.Clear();
            //Partie concerné par le changement de couleur en bleue
            lblIconeAccueil.ForeColor = BLUE;
            lblAccueil.ForeColor = BLUE;

            //Le reste en blanc
            lblIconeDepense.ForeColor = WHITE;
            lblDepenses.ForeColor = WHITE;
            lblIconeEvenement.ForeColor = WHITE;
            lblEvenements.ForeColor = WHITE;
            lblIconeParticipant.ForeColor = WHITE;
            lblParticipants.ForeColor = WHITE;
            lblIconeBilan.ForeColor = WHITE;
            lblBilan.ForeColor = WHITE;

            //Apparaition du US concerné

            Accueil a = new Accueil();
            a.setPanel = this.ecrans;
            this.ecrans.Controls.Add(a);
        }

        private void LblIconeEvenement_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

            this.ecrans.Controls.Clear();
            //Partie concerné par le changement de couleur en bleu
            lblIconeEvenement.ForeColor = BLUE;
            lblEvenements.ForeColor = BLUE;

            //Le reste en blanc
            lblIconeAccueil.ForeColor = WHITE;
            lblAccueil.ForeColor = WHITE;
            lblIconeDepense.ForeColor = WHITE;
            lblDepenses.ForeColor = WHITE;
            lblIconeParticipant.ForeColor = WHITE;
            lblParticipants.ForeColor = WHITE;
            lblIconeBilan.ForeColor = WHITE;
            lblBilan.ForeColor = WHITE;

            //Aparaition du US concerné
            Evenements ee = new Evenements();
            ee.setPanel = this.ecrans;
            this.ecrans.Controls.Add(ee);
        }

        private void SideBarUserControls_Load(object sender, EventArgs e)
        {
            lblIconeAccueil.ForeColor = BLUE;
            lblAccueil.ForeColor = BLUE;

            foreach (Control lbl in this.Controls)
            {
                if(lbl is Hermes.UI.AppFontLabel)
                {
                    lbl.MouseEnter += new EventHandler(Control_MouseEnter);
                    lbl.MouseLeave += new EventHandler(Control_MouseLeave);
                }
            }
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            AppFontLabel lbl = (AppFontLabel)sender;
            if (lbl.ForeColor != BLUE)
            {
                this.Cursor = Cursors.Hand;
            }
            this.Size = new Size(424, this.Size.Height);

        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }



        private void LblIconeDepense_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

            this.ecrans.Controls.Clear();
            //Partie concerné par le changement de couleur en bleu
            lblIconeDepense.ForeColor = BLUE;
            lblDepenses.ForeColor = BLUE;

            //Le reste en blanc
            lblIconeAccueil.ForeColor = WHITE;
            lblAccueil.ForeColor = WHITE;
            lblEvenements.ForeColor = WHITE;
            lblIconeEvenement.ForeColor = WHITE;
            lblIconeParticipant.ForeColor = WHITE;
            lblParticipants.ForeColor = WHITE;
            lblIconeBilan.ForeColor = WHITE;
            lblBilan.ForeColor = WHITE;

            //Aparaition du US concerné
            ViewExpenditures expendituresView = new ViewExpenditures();
            expendituresView.setPanel = this.ecrans;
            this.ecrans.Controls.Add(expendituresView);
        }

        private void LblIconeParticipant_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

            this.ecrans.Controls.Clear();
            //Partie concerné par le changement de couleur en bleu
            lblIconeParticipant.ForeColor = BLUE;
            lblParticipants.ForeColor = BLUE;

            //Le reste en blanc
            lblIconeAccueil.ForeColor = WHITE;
            lblAccueil.ForeColor = WHITE;
            lblIconeDepense.ForeColor = WHITE;
            lblDepenses.ForeColor = WHITE;
            lblIconeEvenement.ForeColor = WHITE;
            lblEvenements.ForeColor = WHITE;
            lblIconeBilan.ForeColor = WHITE;
            lblBilan.ForeColor = WHITE;

            //Aparaition du US concerné
            Participants participants = new Participants();
            participants.setPanel = this.ecrans;
            this.ecrans.Controls.Add(participants);
        }

        private void lblIconeBilan_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

            this.ecrans.Controls.Clear();
            //Partie concerné par le changement de couleur en bleu
            lblIconeBilan.ForeColor = BLUE;
            lblBilan.ForeColor = BLUE;

            //Le reste en blanc
            lblIconeAccueil.ForeColor = WHITE;
            lblAccueil.ForeColor = WHITE;
            lblIconeDepense.ForeColor = WHITE;
            lblDepenses.ForeColor = WHITE;
            lblIconeParticipant.ForeColor = WHITE;
            lblParticipants.ForeColor = WHITE;
            lblIconeEvenement.ForeColor = WHITE;
            lblEvenements.ForeColor = WHITE;
            Bilan bilan = new Bilan();
            bilan.setPanel = this.ecrans;
            this.ecrans.Controls.Add(bilan);
        }

        private void sideBarUserControls1_Enter(object sender, EventArgs e)
        {
            this.Size = new Size(424, this.Size.Height);
        }

        private void sideBarUserControls1_Leave(object sender, EventArgs e)
        {
            this.Size = new Size(116, this.Size.Height);
        }
    }
}
