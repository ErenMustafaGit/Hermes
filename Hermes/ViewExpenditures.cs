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
            cboEvenement.SelectedIndexChanged += new EventHandler(cboEvenement_SelectedIndexChanged);

        }
        public void RefreshExpenditures()
        {
            pnlListExpenditure.Controls.Clear();
            PartyEvent currentEvent = PartyEvent.GetPartyEvent((int)cboEvenement.SelectedValue);
            List<Expenditure> expenditures = currentEvent.GetExpenditures();
            foreach(Expenditure e in expenditures)
            {
                MessageBox.Show(e.Description.ToString());
            }
            for(int i = 0; i<expenditures.Count; i++)
            {
                Hermes.UI.AppFontLabel lbl = new Hermes.UI.AppFontLabel();
                lbl.AppFont = AppFont.HelveticaNeue_Bold;
                lbl.Text = expenditures[i].Description;
                lbl.Text = lbl.Text.Substring(0, 1).ToUpper() + lbl.Text.Substring(1) ;
                lbl.Tag = expenditures[i].NumExpenditure;
                lbl.Left = 20;
                lbl.Top = 20 + 50 * i;
                lbl.AutoSize = false;
                lbl.Width = 300;
                lbl.Height = 30;
                lbl.AppFontHeight = 16F;
                if(i == 0)
                {
                    //Sale fou
                    //lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
                    lbl.ForeColor = Color.FromArgb(72, 141, 255);
                }
                pnlListExpenditure.Controls.Add(lbl);
            }
            if(expenditures.Count != 0)
            {
                lblExpenditureTitle.Text = expenditures[0].Description;
                lblExpenditureTitle.Text = lblExpenditureTitle.Text.Substring(0, 1).ToUpper() + lblExpenditureTitle.Text.Substring(1);
                lblMoney.Text = expenditures[0].Amount.ToString() + "€";
                lblCreator.Text = Participant.GetParticipant(expenditures[0].CodeParticipant).FirstName + " " + Participant.GetParticipant(expenditures[0].CodeParticipant).LastName;
            }
            else
            {
                MessageBox.Show("Pas de dépense dans cet évènement");
                return;
            }
            //List<Participant> beneficiaries = expenditures[0].GetParticipant();
        }



        private void cboEvenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshExpenditures();
        }
    }
}
