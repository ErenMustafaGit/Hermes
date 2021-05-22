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
    public partial class BulleAjEvenement : UserControl
    {
        private Panel ecran;
        private Delegate annuler;
        public BulleAjEvenement()
        {
            InitializeComponent();
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
            
            PartyEvent newEvent = new PartyEvent()
            {
                Code = PartyEvent.GetMaxCode() + 1,
                Title = txtNomEvenement.Text.Replace('\'', ' '),
                BeginDate = dtpDateDebut.Value,
                EndDate = dtpDateFin.Value,
                Description = null,
                BalanceYN = false,
                CodeCreator = Participant.GetParticipant((int)cboEventCreator.SelectedValue).CodeParticipant
            };
            BulleAjEvenement2 suite = new BulleAjEvenement2(newEvent);
            this.ecran.Controls.Clear();
            suite.setPanel = this.ecran;
            this.ecran.Controls.Add(suite);
        }
    }
}
