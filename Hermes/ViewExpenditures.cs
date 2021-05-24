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
            for(int i = 0; i<expenditures.Count; i++)
            {
                Hermes.UI.AppFontLabel lblDepense = new Hermes.UI.AppFontLabel();
                lblDepense.AppFont = AppFont.HelveticaNeue_Bold;
                lblDepense.Text = expenditures[i].Description;
                lblDepense.Text = lblDepense.Text.Substring(0, 1).ToUpper() + lblDepense.Text.Substring(1) ;
                lblDepense.Tag = expenditures[i].NumExpenditure;
                lblDepense.Left = 20;
                lblDepense.Top = 20 + 50 * i;
                lblDepense.AutoSize = false;
                lblDepense.Width = 300;
                lblDepense.Height = 30;
                lblDepense.AppFontHeight = 16F;
                lblDepense.Tag = i;
                lblDepense.MouseClick += new MouseEventHandler(lblDepense_MouseClick);
                lblDepense.MouseHover += new EventHandler(lblDepense_MouseHover);
                lblDepense.MouseLeave += new EventHandler(lblDepense_MouseLeave);
                if(i == 0)
                {
                    //Sale fou
                    //lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
                    lblDepense.ForeColor = Color.FromArgb(72, 141, 255);
                }
                else
                {
                    lblDepense.ForeColor = Color.FromArgb(12, 12, 12);
                }
                pnlListExpenditure.Controls.Add(lblDepense);
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
            //List<Participant> beneficiaries = expenditures[0].GetBeneficiaries();
        }



        private void cboEvenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshExpenditures();
        }

        private void lblDepense_MouseClick(object sender ,EventArgs e)
        {
            Label depense = (Label)sender;
            PartyEvent currentEvent = PartyEvent.GetPartyEvent((int)cboEvenement.SelectedValue);
            List<Expenditure> expenditures = currentEvent.GetExpenditures();
            if (expenditures.Count != 0)
            {
                lblExpenditureTitle.Text = expenditures[(int)depense.Tag].Description;
                lblExpenditureTitle.Text = lblExpenditureTitle.Text.Substring(0, 1).ToUpper() + lblExpenditureTitle.Text.Substring(1);
                lblMoney.Text = expenditures[(int)depense.Tag].Amount.ToString() + "€";
                lblCreator.Text = Participant.GetParticipant(expenditures[(int)depense.Tag].CodeParticipant).FirstName + " " + Participant.GetParticipant(expenditures[(int)depense.Tag].CodeParticipant).LastName;
            }

        }

        private void lblDepense_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblDepense_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
