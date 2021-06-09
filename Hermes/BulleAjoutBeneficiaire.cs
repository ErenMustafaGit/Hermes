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
    public partial class BulleAjoutBeneficiaire : UserControl
    {
        private PartyEvent currentEvent;
        private int expenseIndex;

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

        public BulleAjoutBeneficiaire(PartyEvent currentEvent, int expenseIndex)
        {
            InitializeComponent();
            this.currentEvent = currentEvent;
            this.expenseIndex = expenseIndex;
        }

        private void BulleAjoutBeneficiaire_Load(object sender, EventArgs e)
        {
            cboExpenses.DataSource = currentEvent.GetExpenses().ToDataTable();
            cboExpenses.DisplayMember = "Description";
            cboExpenses.ValueMember = "Id";
            cboExpenses.SelectedIndex = expenseIndex;

            RefreshPoeple();
        }


        private void RefreshPoeple()
        {
            Expense choosenExpense = Expense.GetFromId((int)cboExpenses.SelectedValue);
            List<Participant> notBeneficiary = choosenExpense.GetBeneficiaires();


            for(int i =0; i<notBeneficiary.Count; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Tag = notBeneficiary[i].CodeParticipant;
                chk.Text = notBeneficiary[i].FirstName + " " + notBeneficiary[i].LastName;

                chk.Left = chkEveryOne.Left + 100 * (i%2);
                chk.Top = 50* (i/2);
                pnlParticipants.Controls.Add(chk);
            }
        }

        private void lblBeneficiaire_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlBulleEmplacement.Controls.Clear();
            pnlBulleEmplacement.Visible = false;
        }
    }
}
