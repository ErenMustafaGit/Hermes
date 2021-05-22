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
    public partial class ViewExpenditures : UserControl
    {
        private Panel ecran;
        public ViewExpenditures()
        {
            InitializeComponent();

            pnlListExpenditure.AutoScroll = false;
            pnlListExpenditure.HorizontalScroll.Enabled = false;
            pnlListExpenditure.HorizontalScroll.Visible = false;
            pnlListExpenditure.HorizontalScroll.Maximum = 0;
            pnlListExpenditure.AutoScroll = true;

            pnlBeneficiary.AutoScroll = false;
            pnlBeneficiary.HorizontalScroll.Enabled = false;
            pnlBeneficiary.HorizontalScroll.Visible = false;
            pnlBeneficiary.HorizontalScroll.Maximum = 0;
            pnlBeneficiary.AutoScroll = true;
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void ViewExpenditures_Load(object sender, EventArgs e)
        {
            cboEvenement.DataSource = PartyEvent.toDataTable(Database.FetchEvents());
            cboEvenement.DisplayMember = "Title";
            cboEvenement.ValueMember = "Code";
            lblIconCreator.Text = Hermes.UI.Icons.FINANCE;
            lblIconMoney.Text = Hermes.UI.Icons.COINS;


            RefreshExpenditures();

        }
        public void RefreshExpenditures()
        {
            pnlListExpenditure.Controls.Clear();
            PartyEvent currentEvent = PartyEvent.GetPartyEvent((int)cboEvenement.SelectedValue);
            List<Expenditure> expenditures = currentEvent.GetExpenditures();
            for(int i = 0; i<expenditures.Count; i++)
            {
                Hermes.UI.AppFontLabel lbl = new Hermes.UI.AppFontLabel();
                lbl.Text = expenditures[i].Description;
                lbl.Tag = expenditures[i].NumExpenditure;
                lbl.Left = 20;
                lbl.Top = 20 + 40 * i;
                lbl.AutoSize = false;
                lbl.Width = 300;
                lbl.Height = 30;
                lbl.AppFontHeight = 16F;
                if(i == 0)
                {
                    lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
                }
                pnlListExpenditure.Controls.Add(lbl);
            }
            lblExpenditureTitle.Text = expenditures[0].Description;
            lblMoney.Text = expenditures[0].Amount.ToString() + "€";
            lblCreator.Text = Participant.GetParticipant(expenditures[0].CodeParticipant).LastName.ToUpper() + " " + Participant.GetParticipant(expenditures[0].CodeParticipant).FirstName;

            //List<Participant> beneficiaries = expenditures[0].GetParticipant();
        }
    }
}
