using Hermes.DataModel;
using Hermes.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes.UI.Activities
{
    public partial class EventViewingActivity : UserControl
    {
        public int index;
        public Panel ecran;
        public BindingSource bindingSource;

        public EventViewingActivity()
        {
            InitializeComponent();
            calendarIconLabel.Text = Hermes.UI.Icons.CALENDAR_1;
            nextItemLabel.Text = Hermes.UI.Icons.RIGHT;
            firstItemLabel.Text = Hermes.UI.Icons.DOUBLE_LEFT;
            previousItemLabel.Text = Hermes.UI.Icons.LEFT;
            lastItemLabel.Text = Hermes.UI.Icons.DOUBLE_RIGHT;
            backArrowLabel.Text = Hermes.UI.Icons.LEFT;
        }

        public int setIndex
        {
            set { this.index = value; }
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void EventViewingActivity_Load(object sender, EventArgs e)
        {
            //Scrollbar sur le pnlParticipant
            invitedPanel.AutoScroll = false;
            invitedPanel.HorizontalScroll.Enabled = false;
            invitedPanel.HorizontalScroll.Visible = false;
            invitedPanel.HorizontalScroll.Maximum = 0;
            invitedPanel.AutoScroll = true;

            //BindingSource
            this.bindingSource = Database.GetBindingSource("Evenements");

            //Met place les évènements max au label lblMax
            lblMax.Text = bindingSource.Count.ToString();
            bindingSource.Position = this.index;
            lblCurrentPosition.Text = (bindingSource.Position + 1).ToString();

            //Mise en place pour récuperer les informations
            DataRowView dataRowView = (DataRowView)bindingSource.Current;

            //Nom de l'évènement
            eventNameLabel.Text = dataRowView[1].ToString();

            //Date début
            DateTime dateDebut = (DateTime)dataRowView[2];
            dateBeginLabel.Text = dateDebut.ToFrenchLongDateString();

            //Date fin
            DateTime dateFin = (DateTime)dataRowView[3];
            dateEndLabel.Text = dateFin.ToFrenchLongDateString();

            //Description
            descriptionLabel.Text = dataRowView[4].ToString();

            //Participant à l'évènement
            List<PartyEvent> evenement = Database.FetchEvents();
            PartyEvent currentEvent = evenement[index];


            //Soldé ou non
            bool solde_y_n = (bool)dataRowView[5];
            if (solde_y_n)
            {
                completedIconLabel.Text = Hermes.UI.Icons.TICK_OPEN_CIRCLE;
                completedTextLabel.Text = "Soldé";
            }
            else
            {
                completedIconLabel.Text = Hermes.UI.Icons.CLOCK;
                completedTextLabel.Text = "Non soldé";
            }


            List<Participant> participant = currentEvent.GetGuests();

            int codeCreateur = (int)dataRowView[6];


            Participant eventCreator = Participant.GetParticipant(codeCreateur);
            //Ajout du createur de l'evenement en 1er
            UserEvenement creator = new UserEvenement();
            creator.setCodeCreateur = codeCreateur;
            creator.recupParticipant = eventCreator;
            creator.Top = 20 + 80 * 0;
            invitedPanel.Controls.Add(creator);

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
                invitedPanel.Controls.Add(user);
            }

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
            if (this.index != bindingSource.Count || this.index != 1)
            {
                //Mise en place pour récuperer les informations nécessaire
                DataRowView dataRowView = (DataRowView)bindingSource.Current;
                //Nom de l'évènement
                eventNameLabel.Text = dataRowView[1].ToString();
                //Date début
                DateTime dateDebut = (DateTime)dataRowView[2];
                dateBeginLabel.Text = dateDebut.ToFrenchLongDateString();
                //Date fin
                DateTime dateFin = (DateTime)dataRowView[3];
                dateEndLabel.Text = dateFin.ToFrenchLongDateString();
                //Description de l'évènement
                descriptionLabel.Text = dataRowView[4].ToString();
                //Soldé ou non
                bool solde_y_n = (bool)dataRowView[5];
                if (solde_y_n)
                {
                    completedIconLabel.Text = Hermes.UI.Icons.TICK_OPEN_CIRCLE;
                    completedTextLabel.Text = "Soldé";
                }
                else
                {
                    completedIconLabel.Text = Hermes.UI.Icons.CLOCK;
                    completedTextLabel.Text = "Non soldé";
                }
                //Code créateur
                int codeCreateur = (int)dataRowView[6];

                //Pour remplir le panel contenant les participants à l'évènement
                List<PartyEvent> evenement = Database.FetchEvents();
                PartyEvent evenement_concerné = evenement[index];
                List<Participant> participant = evenement_concerné.GetGuests();
                invitedPanel.Controls.Clear();



                Participant eventCreator = Participant.GetParticipant(codeCreateur);
                //Ajout du createur de l'evenement en 1er
                UserEvenement creator = new UserEvenement();
                creator.setCodeCreateur = codeCreateur;
                creator.recupParticipant = eventCreator;
                creator.Top = 20 + 80 * 0;
                invitedPanel.Controls.Add(creator);

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
                    invitedPanel.Controls.Add(user);
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

        private void lblGoBaaack_Click(object sender, EventArgs e)
        {
            Evenements evenements = new Evenements();
            evenements.setPanel = this.ecran;
            this.ecran.Controls.Clear();
            this.ecran.Controls.Add(evenements);
        }

        private void lblGoBaaack_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblGoBaaack_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
