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

        public Panel setPanelPrincipal
        {
            set { ecran = value; }
        }

        public Panel setPanelBulle
        {
            set { pnlBulle = value; }
        }

        public BulleInvitations()
        {
            InitializeComponent();
        }

        private void BulleInvitations_Load(object sender, EventArgs e)
        {
            List<PartyEvent> events = Database.FetchEvents();
            cboEvenements.DataSource = events.ToDataTable();
            cboEvenements.DisplayMember = "Name";
            cboEvenements.ValueMember = "Id";

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

            PartyEvent currentEvent = PartyEvent.GetFromId((int)cboEvenements.SelectedValue);
            //List<Participant> nonInvitedParticipants = currentEvent.GetNonInvitedParticipant() -> Christo en train de le faire

            List<Participant> nonInvitedParticipants = Database.FetchParticipant();

            if (nonInvitedParticipants.Count != 0)
            {
                CheckBox chkEveryOne = new CheckBox();
                chkEveryOne.Text = "Tout le monde";
                chkEveryOne.AutoSize = true;
                chkEveryOne.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
                chkEveryOne.Top = 20;
                chkEveryOne.Left = 20;
                pnlParticipant.Controls.Add(chkEveryOne);

                int modulo = 2;
                for (int i = 0; i < nonInvitedParticipants.Count; i++)
                {
                    CheckBox chk = new CheckBox();
                    chk.Text = nonInvitedParticipants[i].LastName + " " + nonInvitedParticipants[i].FirstName;
                    chk.AutoSize = true;
                    chk.Font = new Font("Microsoft Sans Serif", 11.25F);
                    chk.Top = 40 + 20 * (i / modulo);
                    chk.Left = 20 + 300 * (i % modulo);
                    pnlParticipant.Controls.Add(chk);
                }
            }
            else
            {
                //Affichage pour indiquer que tout le monde est déjà invité
            }

        }

        private void CboEvenements_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshParticipants();
        }
    }
}
