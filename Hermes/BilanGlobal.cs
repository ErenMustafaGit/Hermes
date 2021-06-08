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
            btnBilanGlobal.Visible = true;
            //Bricolage, mais efficace
            start++;
            if(start >= 1)
            {
                Actualisation();
                this.index = cboEvenements.SelectedIndex;
            }

            if (currentEvent.Completed)
            {
                btnBilanGlobal.Visible = false;
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
            currentEvent = partyEventRefreshed;

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

        private void BtnBilanGlobal_Click(object sender, EventArgs e)
        {
            if (!currentEvent.Completed)
            {
                DialogResult dialogResult = MessageBox.Show("Vous voulez vraiment solder\nl'évènement " + this.currentEvent.Name + " ?", "Solder évènement", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    currentEvent.CloseEvent();
                    //Notification à faire apparaitre
                    MessageBox.Show("Evenement bien soldé ! ");

                    //Refresh
                    this.ecran.Controls.Clear();
                    MessageBox.Show(this.index.ToString());
                    BilanGlobal refreshed = new BilanGlobal(this.currentEvent, this.index);
                    refreshed.setPanel = this.ecran;
                    this.ecran.Controls.Add(refreshed);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            
        }
    }
}
