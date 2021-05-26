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
    public partial class BulleAjEvenement : UserControl
    {
        private Panel ecran;
        private Delegate annuler;
        private static Panel pnlPrincipal;
        public BulleAjEvenement()
        {
            InitializeComponent();
        }

        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }


        public Delegate Annuler
        {
            set { this.annuler = value; }
        }
        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void DtpDateDebut_ValueChanged(object sender, EventArgs e)
        {
            dtpDateFin.MinDate = dtpDateDebut.Value;
        }

        private void DtpDateFin_ValueChanged(object sender, EventArgs e)
        {
            dtpDateFin.MinDate = dtpDateDebut.Value;
        }

        private void BulleAjEvenement_Load(object sender, EventArgs e)
        {
            cboEventCreator.DataSource = Participant.toConcatenateDataTable(Database.FetchParticipant());
            cboEventCreator.DisplayMember = "Name";
            cboEventCreator.ValueMember = "CodeParticipant";
        }

        //btnAnnuler_Click
        private void Button1_Click(object sender, EventArgs e)
        {
            annuler.DynamicInvoke();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if(txtNomEvenement.Text.Length == 0)
            {
                MessageBox.Show("Veuillez saisir le nom de l'évènement !");
                txtNomEvenement.Focus();
                return;
            }
            PartyEvent newEvent = new PartyEvent()
            {
                Id = PartyEvent.GetMaxCode() + 1,
                Name = txtNomEvenement.Text.Replace('\'', ' '),
                StartDate = dtpDateDebut.Value,
                EndDate = dtpDateFin.Value,
                Description = null,
                Completed = false,
                AuthorId = (int)cboEventCreator.SelectedValue
            };
            BulleAjEvenement2 suite = new BulleAjEvenement2(newEvent);
            this.ecran.Controls.Clear();
            suite.setPanel = this.ecran;
            suite.setPanelPrincipal = pnlPrincipal;
            suite.Annuler = annuler;
            this.ecran.Controls.Add(suite);
        }
    }
}
