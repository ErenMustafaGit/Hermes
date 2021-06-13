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
        private  Panel pnlBulleEmplacement;
        //Panel où le form de fond va rester visible
        private Panel pnlPrincipal;

        private PartyEvent currentEvent;

        private bool wentBack;
        private decimal montant;
        private string description;
        private int codeParticipant;
        private int codeEvenement;
        private DateTime dateDepense;
        private int index;



        public Panel setPanel
        {
            set { pnlBulleEmplacement = value; }
        }


        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }


        public BulleAjDepense(PartyEvent currentEvent)
        {
            InitializeComponent();
            this.currentEvent = currentEvent;
            this.wentBack = false;
        }

        public BulleAjDepense(bool wentBack,decimal montant, string description, int codeParticipant, int codeEvenement, DateTime dateDepense, Panel pnlPrincipal, Panel pnlBulleEmplacement, PartyEvent currentEvent, int index)
        {
            InitializeComponent();
            this.wentBack = true;
            this.montant = montant;
            this.description = description;
            this.codeEvenement = codeEvenement;
            this.codeParticipant = codeParticipant;
            this.dateDepense = dateDepense;
            this.pnlPrincipal = pnlPrincipal;
            this.pnlBulleEmplacement = pnlBulleEmplacement;
            this.currentEvent = currentEvent;
            this.index = index;
        }


        private void BulleAjDepense_Load(object sender, EventArgs e)
        {
            FontFamily helvetica = FontManager.GetFontFamily(AppFont.HelveticaNeue);
            cboEvenement.Font = new Font(helvetica, cboEvenement.Font.Size);
            dtpDateDepense.Font = new Font(helvetica, dtpDateDepense.Font.Size);
            txtDescription.Font = new Font(helvetica, txtDescription.Font.Size);
            cboCreateur.Font = new Font(helvetica, cboCreateur.Font.Size);
            numAmount.Font = new Font(helvetica, numAmount.Font.Size);
            btnAnnuler.Font = new Font(helvetica, btnAnnuler.Font.Size);
            btnContinuer.Font = new Font(helvetica, btnContinuer.Font.Size);

            List<PartyEvent> listeEvenement = Database.FetchUncompletedEvents();
            DataTable dataTableEvenement = listeEvenement.ToDataTable();
            cboEvenement.DataSource = dataTableEvenement;
            cboEvenement.DisplayMember = "Name";
            cboEvenement.ValueMember = "Id";
            PartyEvent partyEvent = listeEvenement[cboEvenement.SelectedIndex];
            dtpDateDepense.MinDate = partyEvent.StartDate;

            List<Participant> listeParticipant = listeEvenement[cboEvenement.SelectedIndex].GetGuests();
            DataTable dataTableParticipant = Participant.toConcatenateDataTable(listeParticipant);
            cboEventCreator.DataSource = dataTableParticipant;
            cboEventCreator.DisplayMember = "Name";
            cboEventCreator.ValueMember = "CodeParticipant";

            if (wentBack)
            {
                txtDescription.Text = description;
                numAmount.Value = montant;
                cboEventCreator.SelectedIndex = this.index;
                dtpDateDepense.Value = dateDepense;
                dtpDateDepense.MinDate = currentEvent.StartDate;
                dtpDateDepense.MaxDate = currentEvent.EndDate;
            }


            cboEvenement.SelectedIndexChanged += new System.EventHandler(cboEventCreator_SelectedIndexChanged);
            


            cboEvenement.SelectedValue = currentEvent.Id;
            RefreshGuests();

            if (!wentBack)
            {
                dtpDateDepense.Value = currentEvent.StartDate;
            }
            dtpDateDepense.MinDate = currentEvent.StartDate;
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
            if(txtDescription.Text.Length == 0 || txtDescription.Text.Length > 30)
            {
                //Toast à mettre
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
                BulleAjDepense2 bulleAjDepense2 = new BulleAjDepense2(montant, description, codeParticipant, codeEvenement, dateDepense, pnlPrincipal, pnlBulleEmplacement, currentEvent, (int)cboEventCreator.SelectedIndex);
                pnlBulleEmplacement.Controls.Add(bulleAjDepense2);
            }

        }

        private void cboEventCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void CboEvenement_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CboEvenement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshGuests();
        }
        private void RefreshGuests()
        {
            currentEvent = PartyEvent.GetFromId((int)cboEvenement.SelectedValue);
            dtpDateDepense.MinDate = DateTime.Parse("01/01/2000");
            dtpDateDepense.MaxDate = DateTime.Parse("01/01/2200");
            dtpDateDepense.Value = currentEvent.StartDate;
            dtpDateDepense.MinDate = currentEvent.StartDate;
            dtpDateDepense.MaxDate = currentEvent.EndDate;
            List<Participant> listeParticipant = currentEvent.GetGuests();

            DataTable dataTableParticipant = Participant.toConcatenateDataTable(listeParticipant);
            cboEventCreator.DataSource = dataTableParticipant;
            cboEventCreator.DisplayMember = "Name";
            cboEventCreator.ValueMember = "CodeParticipant";
           
        }
    }
}
