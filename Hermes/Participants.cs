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
    public partial class Participants : UserControl
    {
        public Panel ecran;
        public Database database = new Database();
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
           

            this.participantsListe = database.FetchParticipant();
            this.evenementsListe = database.FetchEvents();
            DataTable evenementTable = PartyEvent.toDataTable(evenementsListe);
            cboEvenements.DataSource = evenementTable;
            cboEvenements.DisplayMember = "Title";
            cboEvenements.ValueMember = "CodeCreator";
            

            int modulo = 2;
            for (int i = 0; i < participantsListe.Count; i++)
            {
                Participant p = participantsListe[i];
                UserParticipants userParticipants = new UserParticipants();
                userParticipants.SetEmail = p.Mail;
                userParticipants.SetPrenomNom = p.LastName + " " + p.FirstName;
                userParticipants.SetNumero = p.PhoneNumber;

                userParticipants.Top = 30 + 200 * (i / modulo);
                userParticipants.Left = 118 + 400 * (i % modulo);
                pnlParticipants.Controls.Add(userParticipants);

            }
            cboEvenements.SelectedIndex = -1;
            cboEvenements.SelectedIndexChanged += new EventHandler(CboEvenements_SelectedIndexChanged);
        }
        public void CboEvenements_SelectedIndexChanged(object sender, EventArgs e)
        {
            Remplissage(this.cboEvenements.SelectedIndex);
            
        }

        public void Remplissage(int index)
        {
            if (index != -1)
            {
                PartyEvent partyEvent = evenementsListe[cboEvenements.SelectedIndex];
                List<Participant> participantsConcerné = partyEvent.GetGuests();

                pnlParticipants.Controls.Clear();
                int modulo = 2;
                for (int i = 0; i < participantsConcerné.Count; i++)
                {
                    Participant p = participantsConcerné[i];
                    UserParticipants userParticipants = new UserParticipants();
                    userParticipants.SetEmail = p.Mail;
                    userParticipants.SetPrenomNom = p.LastName + " " + p.FirstName;
                    userParticipants.SetNumero = p.PhoneNumber;

                    userParticipants.Top = 30 + 200 * (i / modulo);
                    userParticipants.Left = 118 + 400 * (i % modulo);
                    pnlParticipants.Controls.Add(userParticipants);

                }
            }

        }
    }
}
