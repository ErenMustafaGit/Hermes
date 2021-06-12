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
    public partial class UserBilan : UserControl
    {
        private PartyEvent currentEvent;
        public Panel ecran;
        private int index;
        //Bricolage
        private int compteur = -2;
        private int currentIndexPage;
        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        public UserBilan(PartyEvent currentEvent, int index, int currentIndexPage)
        {
            InitializeComponent();
            lblGoBaaack.Text = Hermes.UI.Icons.LEFT;
            this.currentEvent = currentEvent;
            this.index = index;
            this.currentIndexPage = currentIndexPage;
            pnlDepense.HorizontalScroll.Enabled = false;
            pnlDepense.HorizontalScroll.Visible = false;
            pnlDepense.HorizontalScroll.Maximum = 0;
            pnlDepense.AutoScroll = true;

            pnlRemboursement.HorizontalScroll.Enabled = false;
            pnlRemboursement.HorizontalScroll.Visible = false;
            pnlRemboursement.HorizontalScroll.Maximum = 0;
            pnlRemboursement.AutoScroll = true;
        }


        private void Bilan_Load(object sender, EventArgs e)
        {
            List<Participant> listeParticipants = currentEvent.GetGuests();
            DataTable dataTableParticipants = Participant.toConcatenateDataTable(listeParticipants);
            cboParticipant.DataSource = dataTableParticipants;
            cboParticipant.DisplayMember = "Name";
            cboParticipant.ValueMember = "CodeParticipant";
            lblEvent.Text = currentEvent.Name;
            cboParticipant.SelectedIndex = this.index;

            this.SuspendLayout();
            ActualisationDepense();
            ActualisationRemboursement();
            this.ResumeLayout(true);
        }

        private void CboParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {
            compteur++;
            if (compteur >= 1)
            {
                this.SuspendLayout();
                ActualisationDepense();
                ActualisationRemboursement();
                this.ResumeLayout(true);
            }
        }

        private void ActualisationDepense()
        {
            pnlDepense.Controls.Clear();
            List<Participant> listeParticipants = currentEvent.GetGuests();
            Participant participant = listeParticipants[cboParticipant.SelectedIndex];
            List<UserSpendingRecord> listeDepense = Database.QuerySpendings(currentEvent.Id, participant.CodeParticipant);
            Decimal totalAmount = 0;
            foreach (UserSpendingRecord userSpending in listeDepense)
                totalAmount += userSpending.Amount;

            lblTotalDepnse.Text = totalAmount.ToEuros();
            for (int i = 0; i < listeDepense.Count; i++)
            {
                DepenseUser depenseUser = new DepenseUser(listeDepense[i].Date, listeDepense[i].Description, listeDepense[i].Amount);
                Point position = new Point(3, 0 + 129 * i);
                depenseUser.Location = position;
                pnlDepense.Controls.Add(depenseUser);
            }
        }

        private void ActualisationRemboursement()
        {
            pnlRemboursement.Controls.Clear();
            List<Participant> listeParticipants = currentEvent.GetGuests();
            Participant participant = listeParticipants[cboParticipant.SelectedIndex];
            List<UserParticipationRecord> listeRemboursement = Database.QueryParticipation(currentEvent.Id, participant.CodeParticipant);
            Decimal totalAmount = 0;
            totalAmount = CalculeRemboursement(listeRemboursement, participant);
            lblTotalRemboursement.Text = totalAmount.ToEuros();
            for (int i = 0; i < listeRemboursement.Count; i++)
            {
                RemboursementUser remboursementUser = new RemboursementUser(listeRemboursement[i], participant.NbParts);
                Point position = new Point(1, 0 + 129 * i);
                remboursementUser.Location = position;
                pnlRemboursement.Controls.Add(remboursementUser);
            }
        }

        private decimal CalculeRemboursement(List<UserParticipationRecord> listeRemboursement, Participant participant)
        {
            decimal total = 0;
            foreach (UserParticipationRecord userParticipationRecord in listeRemboursement)
                total += userParticipationRecord.Amount / (decimal)userParticipationRecord.ExpenseTotalShares * participant.NbParts;

            return (decimal)total;
        }

        private void btnBilanGlobal_Click(object sender, EventArgs e)
        {
            BilanGlobal bilanGlobal = new BilanGlobal(currentEvent, index);
            bilanGlobal.setPanel = this.ecran;
            this.ecran.Controls.Clear();
            this.ecran.Controls.Add(bilanGlobal);
        }

        private void lblGoBaaack_Click(object sender, EventArgs e)
        {
            BilanGlobal bilanGlobal = new BilanGlobal(currentEvent, currentIndexPage);
            bilanGlobal.setPanel = this.ecran;
            this.ecran.Controls.Clear();
            this.ecran.Controls.Add(bilanGlobal);
        }

        private void lblGoBaaack_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblGoBaaack_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
