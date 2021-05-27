using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Hermes.DataModel;

namespace Hermes
{
    public partial class CompleteInfoEvenement : UserControl
    {
        public int index;
        public Panel ecran;
        public BindingSource bindingSource;
        public CompleteInfoEvenement()
        {
            InitializeComponent();
            lblIconeDate.Text = Hermes.UI.Icons.CALENDAR_1;
            lblIconeDroite.Text = Hermes.UI.Icons.RIGHT;
            lblGaucheGauche.Text = Hermes.UI.Icons.DOUBLE_LEFT;
            lblGauche.Text = Hermes.UI.Icons.LEFT;
            lblIconeDroiteDroite.Text = Hermes.UI.Icons.DOUBLE_RIGHT;
        }

        public int setIndex
        {
            set { this.index = value; }
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void CompleteInfoEvenement_Load(object sender, EventArgs e)
        {
            //Scrollbar sur le pnlParticipant
            pnlParticipant.AutoScroll = false;
            pnlParticipant.HorizontalScroll.Enabled = false;
            pnlParticipant.HorizontalScroll.Visible = false;
            pnlParticipant.HorizontalScroll.Maximum = 0;
            pnlParticipant.AutoScroll = true;

            //BindingSource
            this.bindingSource = Database.GetBindingSource("Evenements");
           
            //Met place les évènements max au label lblMax
            lblMax.Text = bindingSource.Count.ToString();
            bindingSource.Position = this.index;
            lblCurrentPosition.Text = (bindingSource.Position + 1).ToString();

            //Mise en place pour récuperer les informations
            DataRowView dataRowView = (DataRowView)bindingSource.Current;

            //Nom de l'évènement
            lblNomEvenement.Text = dataRowView[1].ToString();

            //Date début
            DateTime dateDebut = (DateTime)dataRowView[2];
            lblDateStart.Text = dateDebut.ToLongDateString();

            //Date fin
            DateTime dateFin = (DateTime)dataRowView[3];
            lblDateEnd.Text = dateFin.ToLongDateString();

            //Description
            lblDescEvenement.Text = dataRowView[4].ToString();

            //Participant à l'évènement
            List<PartyEvent> evenement = Database.FetchEvents();
            PartyEvent currentEvent = evenement[index];


            //Soldé ou non
            bool solde_y_n = (bool)dataRowView[5];
            if (solde_y_n)
                lblTrueFalse.Text = Hermes.UI.Icons.TICK_OPEN_CIRCLE;
            else
                lblTrueFalse.Text = Hermes.UI.Icons.CLOCK;

            
            List<Participant> participant = currentEvent.GetGuests();

            int codeCreateur = (int)dataRowView[6];


            Participant eventCreator = Participant.GetParticipant(codeCreateur);
            //Ajout du createur de l'evenement en 1er
            UserEvenement creator = new UserEvenement();
            creator.setCodeCreateur = codeCreateur;
            creator.recupParticipant = eventCreator;
            creator.Top = 20 + 80 * 0;
            pnlParticipant.Controls.Add(creator);

            //Suppression du créateur de la liste des invités
            //participant.Remove(eventCreator);
            for (int i = 0; i < participant.Count; i++)
            {
                if (participant[i].CodeParticipant == codeCreateur)
                {
                    participant.RemoveAt(i);
                }
            }

            //Ajout des invités
            for (int i = 0; i < participant.Count; i++)
            {
                UserEvenement user = new UserEvenement();
                user.setCodeCreateur = codeCreateur;
                user.recupParticipant = participant[i];
                user.Top = 20 + 80 * (i + 1);
                pnlParticipant.Controls.Add(user);
            }

        }

        private void appFontLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LblSoldé_Click(object sender, EventArgs e)
        {

        }

        private void LblTrueFalse_Click(object sender, EventArgs e)
        {

        }

        private void LblDateEnd_Click(object sender, EventArgs e)
        {

        }

        private void LblDateEvenementAu_Click(object sender, EventArgs e)
        {

        }

        private void LblDateStart_Click(object sender, EventArgs e)
        {

        }

        private void LblIconeDate_Click(object sender, EventArgs e)
        {

        }

        private void LblIconeDroite_Click(object sender, EventArgs e)
        {
            Pagination("Droite");
            lblCurrentPosition.Text = (bindingSource.Position + 1).ToString();
        }

        private void LblGauche_Click(object sender, EventArgs e)
        {
            Pagination("Gauche");
            lblCurrentPosition.Text = (bindingSource.Position + 1).ToString();
        }

        private void LblIconeDroiteDroite_Click(object sender, EventArgs e)
        {
            Pagination("DroiteDroite");
            lblCurrentPosition.Text = (bindingSource.Position + 1).ToString();
        }

        private void LblGaucheGauche_Click(object sender, EventArgs e)
        {
            Pagination("GaucheGauche");
            lblCurrentPosition.Text = (bindingSource.Position + 1).ToString();
        }

        public void Pagination(string indication)
        {
            this.bindingSource.Position = this.index;
            if (indication == "Droite")
                this.bindingSource.MoveNext();

            else if (indication == "DroiteDroite")
                this.bindingSource.MoveLast();

            else if (indication == "Gauche")
                this.bindingSource.MovePrevious();

            else if (indication == "GaucheGauche")
                this.bindingSource.MoveFirst();

            this.index = bindingSource.Position;

            //condition pour eviter de recharger le pnlParticipant après être arrivé au bout, mais marche pas :(
             if(this.index != bindingSource.Count  || this.index != 1)
            {
                //Mise en place pour récuperer les informations nécessaire
                DataRowView dataRowView = (DataRowView)bindingSource.Current;
                //Nom de l'évènement
                lblNomEvenement.Text = dataRowView[1].ToString();
                //Date début
                DateTime dateDebut = (DateTime)dataRowView[2];
                lblDateStart.Text = dateDebut.ToLongDateString();
                //Date fin
                DateTime dateFin = (DateTime)dataRowView[3];
                lblDateEnd.Text = dateFin.ToLongDateString();
                //Description de l'évènement
                lblDescEvenement.Text = dataRowView[4].ToString();
                //Soldé ou non
                bool solde_y_n = (bool)dataRowView[5];
                if (solde_y_n)
                    lblTrueFalse.Text = Hermes.UI.Icons.TICK_OPEN_CIRCLE;
                else
                    lblTrueFalse.Text = Hermes.UI.Icons.CLOCK;
                //Code créateur
                int codeCreateur = (int)dataRowView[6];

                //Pour remplir le panel contenant les participants à l'évènement
                List<PartyEvent> evenement = Database.FetchEvents();
                PartyEvent evenement_concerné = evenement[index];
                List<Participant> participant = evenement_concerné.GetGuests();
                pnlParticipant.Controls.Clear();



                Participant eventCreator = Participant.GetParticipant(codeCreateur);
                //Ajout du createur de l'evenement en 1er
                UserEvenement creator = new UserEvenement();
                creator.setCodeCreateur = codeCreateur;
                creator.recupParticipant = eventCreator;
                creator.Top = 20 + 80 * 0;
                pnlParticipant.Controls.Add(creator);

                //Suppression du créateur de la liste des invités
                //participant.Remove(eventCreator);
                for (int i = 0; i < participant.Count; i++)
                {
                    if (participant[i].CodeParticipant == codeCreateur)
                    {
                        participant.RemoveAt(i);
                    }
                }

                //Ajout des invités
                for (int i = 0; i < participant.Count; i++)
                {
                    UserEvenement user = new UserEvenement();
                    user.setCodeCreateur = codeCreateur;
                    user.recupParticipant = participant[i];
                    user.Top = 20 + 80 * (i + 1);
                    pnlParticipant.Controls.Add(user);
                }
            }

            //Mise à jour de la position actuel au niveau des évènements
            lblCurrentPosition.Text = (bindingSource.Position + 1).ToString();
        }

        private void LblIconeDroite_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LblIconeDroite_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void LblIconeDroiteDroite_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LblIconeDroiteDroite_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void LblGauche_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LblGauche_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void LblGaucheGauche_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LblGaucheGauche_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}