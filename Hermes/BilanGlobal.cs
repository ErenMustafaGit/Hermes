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
    public partial class BilanGlobal : UserControl
    {
        private PartyEvent currentEvent;
        private List<PartyEvent> allEvent;
        public Panel ecran;
        public int index;

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        public BilanGlobal(PartyEvent partyEvent)
        {
            this.currentEvent = partyEvent;
            InitializeComponent();
        }

        private void BilanGlobal_Load(object sender, EventArgs e)
        {
            pnlBilanCasParCas.HorizontalScroll.Enabled = false;
            pnlBilanCasParCas.HorizontalScroll.Visible = false;
            pnlBilanCasParCas.HorizontalScroll.Maximum = 0;
            pnlBilanCasParCas.AutoScroll = true;

          
            allEvent = Database.FetchEvents();
            DataTable table = Database.FetchEvents().ToDataTable();
            cboEvenements.DataSource = table;
            cboEvenements.DisplayMember = "Name";
            cboEvenements.ValueMember = "Id";


        }

        private void cboEvenements_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBilanCasParCas.Controls.Clear();
            PartyEvent partyEventRefreshed = allEvent[cboEvenements.SelectedIndex];
            List<Participant> listeParticipant = partyEventRefreshed.GetGuests();
            List<PartyEvent.Due> remboursement = partyEventRefreshed.CalculateDues();

            int modulo = 2;
            for (int i = 0; i < listeParticipant.Count(); i++)
            {
                List<PartyEvent.Due> dueParticipant = new List<PartyEvent.Due>();
                foreach (PartyEvent.Due due in remboursement)
                {
                    if (due.FromId == listeParticipant[i].CodeParticipant)
                    {
                        dueParticipant.Add(due);
                    }
                }
                UserBilanCasParCas user = new UserBilanCasParCas(listeParticipant[i].FirstName + " " + listeParticipant[i].LastName, dueParticipant, partyEventRefreshed);
                user.Top = 0 + 245 * (i / modulo);
                user.Left = 0 + 400 * (i % modulo);
                pnlBilanCasParCas.Controls.Add(user);
            }
        }
    }
}
