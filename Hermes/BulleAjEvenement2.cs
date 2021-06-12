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
    public partial class BulleAjEvenement2 : UserControl
    {
        private PartyEvent newEvent;
        private Panel ecran;
        private Delegate annuler;
        private static Panel pnlPrincipal;
        /*
        public BulleAjEvenement2()
        {
            InitializeComponent();
        }*/

        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }

        public Delegate Annuler
        {
            set { this.annuler = value; }
        }


        public BulleAjEvenement2(PartyEvent newEvent)
        {
            InitializeComponent();
            this.newEvent = newEvent;
        }
        public Panel setPanel
        {
            set{ this.ecran = value; }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if(rtxtDescription.Text.Length > 0 && rtxtDescription.Text.Length < 200)
            {
                newEvent.Description = this.rtxtDescription.Text;
                Database.InsertEvent(newEvent, getInvitedParticipant());

                this.ecran.Controls.Clear();
                this.ecran.Visible = false;
                pnlPrincipal.Controls.Clear();
                Evenements evenements = new Evenements();
                evenements.setPanel = pnlPrincipal;
                pnlPrincipal.Controls.Add(evenements);
            }
            else
            {
                rtxtDescription.BackColor = Color.LightPink;
                rtxtDescription.Focus();
            }
            
        }

        public List<Participant> getInvitedParticipant()
        {
            List<Participant> invitedParticipant = new List<Participant>();
            invitedParticipant.Add(Participant.GetParticipant(newEvent.AuthorId));
            foreach (CheckBox chk in pnlParticipants.Controls)
            {
                if(chk != chkEveryOne)
                {

                    if (chk.Checked)
                        invitedParticipant.Add(Participant.GetParticipant((int)chk.Tag));

                }
                
            }

            return invitedParticipant;
        }

        private void BulleAjEvenement2_Load(object sender, EventArgs e)
        {
            pnlParticipants.HorizontalScroll.Enabled = false;
            pnlParticipants.HorizontalScroll.Visible = false;
            pnlParticipants.HorizontalScroll.Maximum = 0;
            pnlParticipants.AutoScroll = true;
            List<Participant> participants = Database.FetchParticipant();

            int compteur = 0;
            for(int i = 0; i < participants.Count; i++)
            {
                if(participants[i].CodeParticipant != newEvent.AuthorId)
                {
                    CheckBox chkParticipant = new CheckBox();
                    chkParticipant.Left = chkEveryOne.Left;
                    chkParticipant.Top = 40 + 30 * compteur;
                    chkParticipant.Tag = participants[i].CodeParticipant;
                    chkParticipant.Text = participants[i].FirstName + " " + participants[i].LastName.ToUpper();
                    chkParticipant.AutoSize = false;
                    chkParticipant.Width = 300;
                    chkParticipant.Height = 20;
                    compteur++;
                    pnlParticipants.Controls.Add(chkParticipant);
                }
                else
                {

                }
            }
        }

        public void changeAllChk(bool state)
        {
            for (int i = 0; i < pnlParticipants.Controls.Count; i++)
            {
                CheckBox chkGuest = (CheckBox)pnlParticipants.Controls[i];
                chkGuest.Checked = state;
            }

        }

        private void ChkEveryOne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEveryOne.Checked)
            {
                changeAllChk(true);
            }
            else
            {
                changeAllChk(false);
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            string message = "Etes vous sur de vouloir annuler l'ajout ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, "",buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                annuler.DynamicInvoke();
            }
           
        }

        private void rtxtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            rtxtDescription.BackColor = Color.White;
        }
    }
}
