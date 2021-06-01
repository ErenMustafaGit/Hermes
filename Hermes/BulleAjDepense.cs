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
    public partial class BulleAjDepense : UserControl
    {

        //Panel où la bulle va être placer
        private static Panel pnlBulleEmplacement;
        
        //Panel où le form de fond va rester visible
        private static Panel pnlPrincipal;

        private static int index;


        public Panel setPanel
        {
            set { pnlBulleEmplacement = value; }
        }


        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }

        public int setIndex
        {
            set { index = value; }
        }


        public BulleAjDepense()
        {
            InitializeComponent();
        }


        private void BulleAjDepense_Load(object sender, EventArgs e)
        {
            List<PartyEvent> listeEvenement = Database.FetchUncompletedEvents();
            DataTable dataTableEvenement = listeEvenement.ToDataTable();
            cboEvenement.DataSource = dataTableEvenement;
            cboEvenement.DisplayMember = "Name";
            cboEvenement.ValueMember = "Id";
            PartyEvent partyEvent = listeEvenement[(int)cboEvenement.SelectedValue - 1];
            dtpDateDepense.MinDate = partyEvent.StartDate;

            List<Participant> listeParticipant = listeEvenement[(int)cboEvenement.SelectedValue - 1].GetGuests();
            DataTable dataTableParticipant = Participant.toConcatenateDataTable(listeParticipant);
            cboEventCreator.DataSource = dataTableParticipant;
            cboEventCreator.DisplayMember = "Name";
            cboEventCreator.ValueMember = "CodeParticipant";
            cboEvenement.SelectedIndexChanged += new System.EventHandler(cboEventCreator_SelectedIndexChanged);
            cboEvenement.SelectedIndex = index - 1;
        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            //Suppression de la bulle
            pnlBulleEmplacement.Controls.Clear();
            pnlBulleEmplacement.Visible = false;

        }


        private void btnContinuer_Click(object sender, EventArgs e)
        {
            bool done = true;
            txtDescription.BackColor = Color.White;
            numAmount.BackColor = Color.White;
            if(txtDescription.Text.Length == 0)
            {
                done = false;
                txtDescription.Focus();
                txtDescription.BackColor = Color.LightPink;
            }
            if(numAmount.Value <= 0)
            {
                done = false;
                numAmount.Focus();
                numAmount.BackColor = Color.LightPink;
            }
            if (done)
            {
                decimal montant = numAmount.Value;
                string description = txtDescription.Text;
                int codeParticipant = (int)cboEventCreator.SelectedValue;
                int codeEvenement = (int)cboEvenement.SelectedValue;
                DateTime dateDepense = dtpDateDepense.Value;

                pnlBulleEmplacement.Controls.Clear();
                BulleAjDepense2 bulleAjDepense2 = new BulleAjDepense2(montant, description, codeParticipant, codeEvenement, dateDepense, pnlPrincipal, pnlBulleEmplacement);
                pnlBulleEmplacement.Controls.Add(bulleAjDepense2);
            }

        }

        private void cboEventCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PartyEvent> listeEvenement = Database.FetchEvents();
            DataTable dataTableEvenement = listeEvenement.ToDataTable();

            List<Participant> listeParticipant = listeEvenement[(int)cboEvenement.SelectedValue - 1].GetGuests();
            DataTable dataTableParticipant = Participant.toConcatenateDataTable(listeParticipant);
            cboEventCreator.DataSource = dataTableParticipant;
            cboEventCreator.DisplayMember = "Name";
            cboEventCreator.ValueMember = "CodeParticipant";

        }
    }
}
