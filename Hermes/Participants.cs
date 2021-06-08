using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hermes.DataModel;

namespace Hermes
{
    public partial class Participants : UserControl
    {
        public Panel ecran;
        public List<PartyEvent> evenementsListe;
        public List<Participant> participantsListe;
        public Participants()
        {
            InitializeComponent();
            pnlParticipants.AutoScroll = false;
            pnlParticipants.HorizontalScroll.Enabled = false;
            pnlParticipants.HorizontalScroll.Visible = false;
            pnlParticipants.HorizontalScroll.Maximum = 0;
            pnlParticipants.AutoScroll = true;
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }
        private void Participants_Load(object sender, EventArgs e)
        {
            this.participantsListe = Database.FetchParticipant();
            this.evenementsListe = Database.FetchEvents();

            DataTable evenementTable = this.evenementsListe.ToDataTable();
            DataRow rowTous;
            rowTous = evenementTable.NewRow();
            rowTous["Name"] = "Tous";
            evenementTable.Rows.Add(rowTous);

            cboEvenements.DataSource = evenementTable;
            cboEvenements.DisplayMember = "Name";
            cboEvenements.ValueMember = "AuthorId";

            BulleAjout();



            int modulo = 2;
            for (int i = 0; i < participantsListe.Count; i++)
            {
                Participant participant = participantsListe[i];
                UserParticipants userParticipants = new UserParticipants();
                userParticipants.SetParticipant = participant;

                userParticipants.Top = 30 + 200 * ((i+1) / modulo);
                userParticipants.Left = 0 + 400 * ((i+1) % modulo);
                pnlParticipants.Controls.Add(userParticipants);

            }

            cboEvenements.SelectedIndexChanged += new EventHandler(CboEvenements_SelectedIndexChanged);
            cboEvenements.SelectedIndex = evenementTable.Rows.Count- 1;
        }
        public void CboEvenements_SelectedIndexChanged(object sender, EventArgs e)
        {
            Remplissage(this.cboEvenements.SelectedIndex);
            
        }

        public void Remplissage(int index)
        {
            string value = cboEvenements.Text;
            if (value == "Tous")
            {
                pnlParticipants.Controls.Clear();


                BulleAjout();

                int modulo = 2;
                for (int i = 0; i < participantsListe.Count; i++)
                {
                    Participant participant = participantsListe[i];
                    UserParticipants userParticipants = new UserParticipants();
                    userParticipants.SetParticipant = participant;

                    userParticipants.Top = 30 + 200 * ((i+1) / modulo);
                    userParticipants.Left = 0 + 400 * ((i+1) % modulo);
                    pnlParticipants.Controls.Add(userParticipants);

                }
            }

            else if (index != -1)
            {
                PartyEvent partyEvent = evenementsListe[cboEvenements.SelectedIndex];
                List<Participant> participantsConcerné = partyEvent.GetGuests();

                pnlParticipants.Controls.Clear();

                BulleAjout();

                int modulo = 2;

                for (int i = 0; i < participantsConcerné.Count; i++)
                {
                    Participant participant = participantsConcerné[i];
                    UserParticipants userParticipants = new UserParticipants();
                    userParticipants.SetParticipant = participant;
                    userParticipants.Top = 30 + 200 * ((i+1) / modulo);
                    userParticipants.Left = 0 + 400 * ((i+1) % modulo);

                    pnlParticipants.Controls.Add(userParticipants);

                }


            }

        }

        public void BulleAjout()
        {
            Panel pnlAddParticipantBulle = new Panel();
            pnlAddParticipantBulle.Size = new Size(705, 405);
            Point coordonneePanel = new Point(127, 115);
            pnlAddParticipantBulle.Location = coordonneePanel;
            this.Controls.Add(pnlAddParticipantBulle);
            pnlAddParticipantBulle.Visible = false;

            AjoutParticipant ajoutParticipant = new AjoutParticipant();
            ajoutParticipant.setPanelPrincipal = this.ecran;
            ajoutParticipant.setPanelBulle = pnlAddParticipantBulle;
            ajoutParticipant.Top = 30;
            ajoutParticipant.Left = 0;
            pnlParticipants.Controls.Add(ajoutParticipant);
        }

        private void btnInviter_Click(object sender, EventArgs e)
        {
            Panel pnlInvitationsBulle = new Panel();
            pnlInvitationsBulle.Size = new Size(705, 405);
            Point coordonneePanel = new Point(127, 115);
            pnlInvitationsBulle.Location = coordonneePanel;
            this.Controls.Add(pnlInvitationsBulle);
            pnlInvitationsBulle.BringToFront();
            pnlInvitationsBulle.Visible = true;

            BulleInvitations bulleInvitations = new BulleInvitations();
            bulleInvitations.setPanelPrincipal = this.ecran;
            bulleInvitations.setPanelBulle = pnlInvitationsBulle;
            pnlInvitationsBulle.Controls.Add(bulleInvitations);

        }

        private void CboEvenements_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
