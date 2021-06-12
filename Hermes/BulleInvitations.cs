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
    public partial class BulleInvitations : UserControl
    {
        private static Panel ecran;
        private static Panel pnlBulle;

        //Event choisi avant de cliquer dans inviter
        private PartyEvent basicEvent;

        public Panel setPanelPrincipal
        {
            set { ecran = value; }
        }

        public Panel setPanelBulle
        {
            set { pnlBulle = value; }
        }

        public PartyEvent setBasicEvent
        {
            set { basicEvent = value; }
        }

        public BulleInvitations()
        {
            InitializeComponent();
        }

        private void BulleInvitations_Load(object sender, EventArgs e)
        {
            //ScrollBar sur pnlParticipant si il y a trop de participant
            pnlParticipant.AutoScroll = false;
            pnlParticipant.HorizontalScroll.Enabled = false;
            pnlParticipant.HorizontalScroll.Visible = false;
            pnlParticipant.HorizontalScroll.Maximum = 0;
            pnlParticipant.AutoScroll = true;

            //Remplissage de la combobox
            List<PartyEvent> events = Database.FetchUncompletedEvents();
            cboEvenements.DataSource = events.ToDataTable();
            cboEvenements.DisplayMember = "Name";
            cboEvenements.ValueMember = "Id";

            if (basicEvent != null)
            {
                cboEvenements.SelectedValue = basicEvent.Id;
            }
            RefreshParticipants();
           
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pnlBulle.Controls.Clear();
            pnlBulle.Visible = false;
        }

        public void RefreshParticipants()
        {
            pnlParticipant.Controls.Clear();

            //Evenement choisi dans la comboBox
            PartyEvent currentEvent = PartyEvent.GetFromId((int)cboEvenements.SelectedValue);

            //Récupération des personnes non invités à l'evenement choisi
            List<Participant> uninvitedParticipants = currentEvent.GetUninvitedPeople();

            //Si il y a au moins un personne qui n'a pas été invité
            if (uninvitedParticipants.Count != 0)
            {

                //CheckBox "Tout le monde"
                CheckBox chkEveryOne = new CheckBox();
                chkEveryOne.Text = "Tout le monde";
                chkEveryOne.AutoSize = true;
                chkEveryOne.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
                chkEveryOne.Top = 20;
                chkEveryOne.Left = 0;
                chkEveryOne.CheckedChanged += new EventHandler(chkEveryOne_CheckedChanged);
                pnlParticipant.Controls.Add(chkEveryOne);


                int modulo = 2;

                //Une checkBox pour chaque participant non encore invité
                for (int i = 0; i < uninvitedParticipants.Count; i++)
                {
                    CheckBox chk = new CheckBox();

                    string fullname = uninvitedParticipants[i].LastName + " " + uninvitedParticipants[i].FirstName;

                    if (fullname.Length > 30)
                        fullname = fullname.Substring(0, 30) + "...";

                    chk.Text = fullname;
                    chk.Tag = uninvitedParticipants[i].CodeParticipant;
                    chk.AutoSize = true;
                    chk.Font = new Font("Microsoft Sans Serif", 11.25F);
                    chk.Top = 40 + 20 * (i / modulo);
                    chk.Left = 0 + 300 * (i % modulo);
                    pnlParticipant.Controls.Add(chk);
                }
            }
            else
            {
                //Affichage pour indiquer que tout le monde est déjà invité
            }

        }


        private void chkEveryOne_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkEveryOne = (CheckBox)sender;
            if (chkEveryOne.Checked)
            {
                changeAllChk(true);
            }
            else
            {
                changeAllChk(false);
            }

        }
        public void changeAllChk(bool state)
        {
            foreach (CheckBox chkGuest in pnlParticipant.Controls)
            {
                chkGuest.Checked = state;
            }

        }


        private void CboEvenements_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshParticipants();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            //Evenement choisi dans la comboBox
            PartyEvent currentEvent = PartyEvent.GetFromId((int)cboEvenements.SelectedValue);

            //Liste de toutes les personnes coché donc invité
            List<Participant> invitedParticipant = new List<Participant>();

            //Récupération de toutes les checkbox
            foreach(CheckBox chk in pnlParticipant.Controls)
            {
                //Ajout du participant si sa checkBox est cochée
                if(chk.Text != "Tout le monde" && chk.Checked)
                {
                    Participant participant = Participant.GetParticipant((int)chk.Tag);
                    invitedParticipant.Add(participant);
                }
            }

            //Invitation à l'evenement des participants coché
            Database.InsertGuestsForEvent(currentEvent, invitedParticipant);

            pnlBulle.Controls.Clear();
            //Ajout d'une pop up pour confirmer l'invitation 
            pnlBulle.Visible = false;
        }
    }
}
