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
            FontFamily helvetica = FontManager.GetFontFamily(AppFont.HelveticaNeue);
            btnInviter.Font = new Font(helvetica, btnInviter.Font.Size);
            cboEvenements.Font = new Font(helvetica, cboEvenements.Font.Size);

            this.participantsListe = Database.FetchParticipant();
            this.evenementsListe = Database.FetchEvents();

            DataTable evenementTable = this.evenementsListe.ToDataTable();
            DataRow rowTous = evenementTable.NewRow();
            rowTous["Name"] = "Tous";
            rowTous["Id"] = 0;
            evenementTable.Rows.InsertAt(rowTous, 0);

            cboEvenements.DataSource = evenementTable;
            cboEvenements.DisplayMember = "Name";
            cboEvenements.ValueMember = "Id";

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
            cboEvenements.SelectedIndex = 0;
        }
        public void CboEvenements_SelectedIndexChanged(object sender, EventArgs e)
        {
            Remplissage((int)this.cboEvenements.SelectedValue);
            EvenementFiniOuPas();
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
                PartyEvent partyEvent = PartyEvent.GetFromId(index);
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

        public void EvenementFiniOuPas()
        {
            foreach (PartyEvent partyEvent in evenementsListe)
            {
                if (partyEvent.Id == (int)this.cboEvenements.SelectedValue)
                {
                    if (partyEvent.Completed)
                    {
                        btnInviter.Visible = false;
                    }
                    else
                    {
                        btnInviter.Visible = true;
                    }
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

            if (cboEvenements.Text != "Tous")
                bulleInvitations.setBasicEvent = PartyEvent.GetFromId((int)cboEvenements.SelectedValue);

            pnlInvitationsBulle.Controls.Add(bulleInvitations);

        }

        private void CboEvenements_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
