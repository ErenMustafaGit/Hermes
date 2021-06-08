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
    public partial class UserBilan : UserControl
    {
        private PartyEvent currentEvent;
        public Panel ecran;
        private int index;
        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        public UserBilan(PartyEvent currentEvent, int index)
        {
            InitializeComponent();
            this.currentEvent = currentEvent;
            this.index = index;
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
            ActualisationDepense();
            ActualisationRemboursement();
        }

        private void depenseUser1_Load(object sender, EventArgs e)
        {

        }

        private void CboParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pour éviter que ça provoque des bugs d'affichages lors du chargement
            if(cboParticipant.SelectedIndex != 0)
            {
                ActualisationDepense();
                ActualisationRemboursement();
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

            lblTotalDepnse.Text = totalAmount.ToString("0.00") + "€";
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
            lblTotalRemboursement.Text = totalAmount.ToString("0.00") + "€";
            for (int i = 0; i < listeRemboursement.Count; i++)
            {
                RemboursementUser remboursementUser = new RemboursementUser(listeRemboursement[i].ExpenseTotalShares, listeRemboursement[i].Amount);
                Point position = new Point(1, 0 + 129 * i);
                remboursementUser.Location = position;
                pnlRemboursement.Controls.Add(remboursementUser);
            }
        }

        private Decimal CalculeRemboursement(List<UserParticipationRecord> listeRemboursement, Participant participant)
        {
            double total = 0;
            foreach (UserParticipationRecord userParticipationRecord in listeRemboursement)
                total += Convert.ToDouble(userParticipationRecord.Amount)/ userParticipationRecord.ExpenseTotalShares * participant.NbParts;

            return (Decimal)total;
        }

        private void PnlDepense_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBilanGlobal_Click(object sender, EventArgs e)
        {
            BilanGlobal bilanGlobal = new BilanGlobal(currentEvent, index);
            bilanGlobal.setPanel = this.ecran;
            this.ecran.Controls.Clear();
            this.ecran.Controls.Add(bilanGlobal);
        }
    }
}
