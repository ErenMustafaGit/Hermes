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
        private Delegate annuler;
        public BulleAjEvenement()
        {
            InitializeComponent();
        }

        public Delegate Annuler
        {
            set { this.annuler = value; }
        }

        private void DtpDateDebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtpDateFin_ValueChanged(object sender, EventArgs e)
        {
            dtpDateFin.MinDate = dtpDateDebut.Value;
        }

        private void BulleAjEvenement_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            cboEvenements.DataSource = Participant.toConcatenateDataTable(database.FetchParticipant());
            cboEvenements.DisplayMember = "Name";
            cboEvenements.ValueMember = "CodeParticipant";
        }

        //btnAnnuler_Click
        private void Button1_Click(object sender, EventArgs e)
        {
            annuler.DynamicInvoke();
        }
    }
}
