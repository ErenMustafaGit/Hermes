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
    public partial class AjNouvelleDepense : UserControl
    {
        Panel ecran;
        int indice;
        public AjNouvelleDepense(int indice)
        {
            InitializeComponent();
            this.indice = indice;
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void AjNouvelleDepense_Load(object sender, EventArgs e)
        {

            DataTable events = PartyEvent.toDataTable(Database.FetchEvents());
            cboEvenements.DataSource = events;
            cboEvenements.DisplayMember = "Title";
            cboEvenements.ValueMember = "Code";
            cboEvenements.SelectedIndex = indice - 1;

            PartyEvent selectedEvent = PartyEvent.GetPartyEvent(int.Parse(cboEvenements.SelectedValue.ToString()));

            updateGuests();

            dtpDebut.Value = selectedEvent.BeginDate;

           
        }
        public void updateGuests()
        {
            PartyEvent selectedEvent = PartyEvent.GetPartyEvent(int.Parse(cboEvenements.SelectedValue.ToString()));
            DataTable guests = Participant.toConcatenateDataTable(selectedEvent.GetGuests());
            cboPayePar.DataSource = guests;
            cboPayePar.DisplayMember = "name";
            cboPayePar.ValueMember = "codeParticipant";
        }

        private void cbbEvenement_SelectedIndexChanged(object sender, EventArgs e)
        {
           //supp
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {
        }

        private void appFontLabel7_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string message = "Voulez vous vraiment annuler l'ajout ?";
            string caption = "";
            result = result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                this.ecran.Controls.Clear();
                Accueil a = new Accueil();
                a.setPanel = this.ecran;
                this.ecran.Controls.Add(a);
            }
            
        }

        private void appFontLabel7_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblAnnuler_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void CboPayePar_SelectedValueChanged(object sender, EventArgs e)
        {
            //sup
        }

        private void cboPayePar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //
        }

        private void cboEvenements_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PartyEvent selectedEvent = PartyEvent.GetPartyEvent(int.Parse(cboEvenements.SelectedValue.ToString()));
            dtpDebut.Value = selectedEvent.BeginDate;
            updateGuests();
        }

        //Continuer
        private void AppFontLabel8_Click(object sender, EventArgs e)
        {
            
            this.ecran.Controls.Clear();
            AjNouvelleDepense2 suite = new AjNouvelleDepense2(int.Parse(cboEvenements.SelectedValue.ToString()), dtpDebut.Value, txtWhere.Text, int.Parse(cboPayePar.SelectedValue.ToString()), numAmount.Value);
            suite.setPanel = this.ecran;
            this.ecran.Controls.Add(suite);
        }

        private void AppFontLabel8_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void AppFontLabel8_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
