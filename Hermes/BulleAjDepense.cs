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
    public partial class BulleAjDepense : UserControl
    {
        private static Panel pnlBulleEmplacement;
        private static Panel pnlPrincipal;
        public Panel setPanel
        {
            set { pnlBulleEmplacement = value; }
        }

        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }

        public BulleAjDepense()
        {
            InitializeComponent();
        }

        private void BulleAjDepense_Load(object sender, EventArgs e)
        {
            List<Participant> listeParticipant = Database.FetchParticipant();
            DataTable dataTableParticipant = Participant.toConcatenateDataTable(listeParticipant);
            cboEventCreator.DataSource = dataTableParticipant;
            cboEventCreator.DisplayMember = "Name";
            cboEventCreator.ValueMember = "CodeParticipant";

            List<PartyEvent> listeEvenement = Database.FetchEvents();
            DataTable dataTableEvenement = PartyEvent.toDataTable(listeEvenement);
            cboEvenement.DataSource = dataTableEvenement;
            cboEvenement.DisplayMember = "Title";
            cboEvenement.ValueMember = "Code";
            PartyEvent partyEvent = listeEvenement[(int)cboEvenement.SelectedValue - 1];
            dtpDateDepense.MinDate = partyEvent.BeginDate;

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlBulleEmplacement.Controls.Clear();
            pnlBulleEmplacement.Visible = false;
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text.Length > 0)
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
            else
            {
                MessageBox.Show("Veuillez saisir un nom de dépense ! ");
            }
            
        }
    }
}
