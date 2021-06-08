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
    public partial class DataGridViewCustom : UserControl
    {
        private PartyEvent currentEvent;
        private List<Participant> participants;
        public DataGridViewCustom(PartyEvent currentEvent)
        {
            InitializeComponent();
            this.currentEvent = currentEvent;
            participants = currentEvent.GetGuests();

            pnlRows.HorizontalScroll.Enabled = false;
            pnlRows.HorizontalScroll.Visible = false;
            pnlRows.HorizontalScroll.Maximum = 0;
            pnlRows.AutoScroll = true;
        }

        private void PnlTitle_Paint(object sender, PaintEventArgs e)
        {
        }

        private void DataGridViewCustom_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < participants.Count; i++)
            {
                Participant participant = participants[i];
                List<UserSpendingRecord> listeDepense = Database.QuerySpendings(currentEvent.Id, participant.CodeParticipant);
                //Plus
                Decimal totalAmount = 0;
                foreach (UserSpendingRecord userSpending in listeDepense)
                    totalAmount += userSpending.Amount;

                //Moins
                List<UserParticipationRecord> listeRemboursement = Database.QueryParticipation(currentEvent.Id, participant.CodeParticipant);
                Decimal totalMinus = 0;
                totalMinus = CalculeRemboursement(listeRemboursement, participant);

                DataRowCustom row = new DataRowCustom(participant.FirstName + " " + participant.LastName, (double)totalAmount, (double)totalMinus);
                // si impaire
                if (i % 2 != 0)
                {
                    row.ChangeColor();
                }
                row.Top = 0 + 42 * i;
                pnlRows.Controls.Add(row);

            }
        }

        private void PnlRows_Paint(object sender, PaintEventArgs e)
        {

        }

        private Decimal CalculeRemboursement(List<UserParticipationRecord> listeRemboursement, Participant participant)
        {
            double total = 0;
            foreach (UserParticipationRecord userParticipationRecord in listeRemboursement)
                total += Convert.ToDouble(userParticipationRecord.Amount) / userParticipationRecord.ExpenseTotalShares * participant.NbParts;

            return (Decimal)total;
        }
    }
}
