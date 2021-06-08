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


        //pour fix le double actualisation de la page
        //Bricolage, mais efficace 
        private int start = -2;
        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        public BilanGlobal(PartyEvent partyEvent, int index)
        {
            this.index = index;
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
            cboEvenements.SelectedIndex = index;
            Actualisation();

        }

        private void cboEvenements_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bricolage, mais efficace
            start++;
            if(start >= 1)
            {
                Actualisation();
            }
        
        }

        private void DataGridViewCustom1_Load(object sender, EventArgs e)
        {

        }

        public void Actualisation()
        {
            pnlBilanToutePersonnes.Controls.Clear();
            pnlBilanCasParCas.Controls.Clear();

            PartyEvent partyEventRefreshed = allEvent[cboEvenements.SelectedIndex];

            DataGridViewCustom dataGridViewCustom = new DataGridViewCustom(partyEventRefreshed);
            pnlBilanToutePersonnes.Controls.Add(dataGridViewCustom);


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
