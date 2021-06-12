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
using Hermes.Extensions;

namespace Hermes
{
    public partial class RemboursementUser : UserControl
    {
        readonly UserParticipationRecord record;
        readonly int sharesForUser;

        public RemboursementUser()
        {
            InitializeComponent();
        }

        public RemboursementUser(UserParticipationRecord record, int sharesForUser)
        {
            this.record = record;
            this.sharesForUser = sharesForUser;

            InitializeComponent();
        }

        private void RemboursementUser_Load(object sender, EventArgs e)
        {
            lblNom.Text = this.record.Expense.Description;
            lblNbrPart.Text = Math.Round(this.sharesForUser / this.record.ExpenseTotalShares * 100) + " % des parts";
            lblAmountDepense.Text = this.record.Amount.ToEuros();
        }
    }
}
