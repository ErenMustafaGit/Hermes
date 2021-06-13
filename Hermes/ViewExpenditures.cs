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
using Hermes.UI;

namespace Hermes
{
    public partial class ViewExpenditures : UserControl
    {
        private Panel ecran;
        private int expenseIndex;

        //Evenement de base qui doit être afficher en 1er
        private int idBasicEvent = -1;

        //Label pour dire qu'il n'y a pas de dépense dans cet evenement
        AppFontLabel lblNone;

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
            lblIconeDesc.Text = Hermes.UI.Icons.INFORMATION;
            //Creation de lblNone et Invisible
            lblNone = new AppFontLabel();
            lblNone.Text = "Il n'y a pas de dépense dans cet évenement";
            lblNone.AutoSize = true;
            lblNone.Left = (this.Width / 2) - 260;
            lblNone.Top = this.Height / 2;
            lblNone.ForeColor = Color.Gray;
            lblNone.AppFontHeight = 16;
            this.Controls.Add(lblNone);
            lblNone.BringToFront();
            lblNone.Visible = false;
        }

        public ViewExpenditures(int idBasicEvent)
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
            lblIconeDesc.Text = Hermes.UI.Icons.INFORMATION;

            this.idBasicEvent = idBasicEvent;


            //Creation de lblNone et Invisible
            lblNone = new AppFontLabel();
            lblNone.Text = "Il n'y a pas de dépense dans cet évenement";
            lblNone.AutoSize = true;
            lblNone.Left = (this.Width / 2) - 260;
            lblNone.Top = this.Height / 2;
            lblNone.ForeColor = Color.Gray;
            lblNone.AppFontHeight = 16;
            this.Controls.Add(lblNone);
            lblNone.BringToFront();
            lblNone.Visible = false;
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void ViewExpenditures_Load(object sender, EventArgs e)
        {
            lblIconCreator.Text = Hermes.UI.Icons.FINANCE;
            lblIconMoney.Text = Hermes.UI.Icons.COINS;

            FontFamily helvetica = FontManager.GetFontFamily(AppFont.HelveticaNeue);
            cboEvenement.Font = new Font(helvetica, cboEvenement.Font.Size);
            btnAddExpenditure.Font = new Font(helvetica, btnAddExpenditure.Font.Size);

            cboEvenement.DataSource = Database.FetchEvents().ToDataTable();
            cboEvenement.DisplayMember = "Name";
            cboEvenement.ValueMember = "Id";

            if (idBasicEvent != -1)
                cboEvenement.SelectedValue = idBasicEvent;

            PartyEvent currentEvent = PartyEvent.GetFromId((int)cboEvenement.SelectedValue);
            btnAddExpenditure.Visible = !currentEvent.Completed;

            RefreshExpenditures();
            cboEvenement.SelectedIndexChanged += new EventHandler(cboEvenement_SelectedIndexChanged);

        }
        public void RefreshExpenditures()
        {
            

            pnlListExpenditure.Controls.Clear();

            PartyEvent currentEvent = PartyEvent.GetFromId((int)cboEvenement.SelectedValue);
            List<Expense> expenses = currentEvent.GetExpenses();
            
            //Si des dépenses existe pour l'evenement sélectionner
            if(expenses.Count != 0)
            {
                
                for (int i = 0; i < expenses.Count; i++)
                {
                    Hermes.UI.AppFontLabel lblDepense = new Hermes.UI.AppFontLabel();
                    lblDepense.AppFont = AppFont.HelveticaNeue_Bold;
                    lblDepense.Text = expenses[i].Description.Substring(0, 1).ToUpper() + expenses[i].Description.Substring(1);
                    //lblDepense.Tag = expenses[i].Id;
                    lblDepense.Left = 20;
                    lblDepense.Top = 10 + 47 * i;
                    lblDepense.AutoSize = true;
                    lblDepense.Height = 30;
                    lblDepense.AppFontHeight = 16F;
                    lblDepense.Tag = i;
                    lblDepense.MouseClick += new MouseEventHandler(lblDepense_MouseClick);
                    lblDepense.MouseEnter += new EventHandler(lblDepense_MouseHover);
                    lblDepense.MouseLeave += new EventHandler(lblDepense_MouseLeave);
                    if (i == 0)
                    {
                        lblDepense.ForeColor = Color.FromArgb(72, 141, 255);
                    }
                    else
                    {
                        lblDepense.ForeColor = Color.FromArgb(12, 12, 12);
                    }
                    pnlListExpenditure.Controls.Add(lblDepense);
                }

                this.lblNone.Visible = false;

                lblExpenditureTitle.Visible = true;
                pnlDetailExpenditure.Visible = true;
                pnlListExpenditure.Visible = true;
                pnlBeneficiary.Visible = true;

                lblExpenditureTitle.Text = expenses[0].Description;
                lblExpenditureTitle.Text = lblExpenditureTitle.Text.Substring(0, 1).ToUpper() + lblExpenditureTitle.Text.Substring(1);
                lblMoney.Text = expenses[0].Amount.ToEuros();
                if (expenses[0].Comment.Length != 0)
                {
                    lblDesc.Text = "\"" + expenses[0].Comment + "\"";
                }
                else
                {
                    lblDesc.Text = "Pas de commentaire";
                }
                

                Participant participant = Participant.GetParticipant(expenses[0].AuthorId);
                lblCreator.Text = participant.FirstName + " " + participant.LastName;
                RefreshBeneficiaries(expenses, 0);
            }
            else
            {
                this.lblNone.Visible = true;

                lblExpenditureTitle.Visible = false;
                pnlDetailExpenditure.Visible = false;
                pnlListExpenditure.Visible = false;
                pnlBeneficiary.Visible = false;
            }
        }

        private void RefreshBeneficiaries(List<Expense> expenses, int index)
        {
            pnlBeneficiary.Controls.Clear();
            List<Participant> beneficiaries = expenses[index].GetBeneficiaires();
            expenseIndex = index;

            for(int i = 0; i<beneficiaries.Count; i++)
            {
                Hermes.UI.AppFontLabel lblBeneficiary = new Hermes.UI.AppFontLabel();
                lblBeneficiary.AppFont = AppFont.HelveticaNeue;
                lblBeneficiary.Text = beneficiaries[i].FirstName.Substring(0, 1).ToUpper()+ beneficiaries[i].FirstName.Substring(1) + " " + beneficiaries[i].LastName.ToUpper();
                lblBeneficiary.Left = 10;
                lblBeneficiary.Top = 10 + 30 * i;
                lblBeneficiary.AutoSize = false;
                lblBeneficiary.Width = 300;
                lblBeneficiary.Height = 30;
                lblBeneficiary.AppFontHeight = 12F;
                lblBeneficiary.Tag = i;
                pnlBeneficiary.Controls.Add(lblBeneficiary);
            }

        }

        private void cboEvenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            PartyEvent currentEvent = PartyEvent.GetFromId((int)cboEvenement.SelectedValue);
            btnAddExpenditure.Visible = !currentEvent.Completed;

            RefreshExpenditures();
        }

        private void lblDepense_MouseClick(object sender ,EventArgs e)
        {
            Label depense = (Label)sender;
            depense.ForeColor = Color.FromArgb(72, 141, 255);

            PartyEvent currentEvent = PartyEvent.GetFromId((int)cboEvenement.SelectedValue);
            List<Expense> expenses = currentEvent.GetExpenses();

            if (expenses.Count != 0)
            {
                Participant participant = Participant.GetParticipant(expenses[(int)depense.Tag].AuthorId);

                lblExpenditureTitle.Visible = true;
                pnlDetailExpenditure.Visible = true;
                lblExpenditureTitle.Text = expenses[(int)depense.Tag].Description;
                lblExpenditureTitle.Text = lblExpenditureTitle.Text.Substring(0, 1).ToUpper() + lblExpenditureTitle.Text.Substring(1);
                lblMoney.Text = expenses[(int)depense.Tag].Amount.ToEuros();
                if(expenses[(int)depense.Tag].Comment.Length != 0)
                {
                    lblDesc.Text = "\"" + expenses[(int)depense.Tag].Comment + "\"";
                }
                else
                {
                    lblDesc.Text = "Pas de commentaire";
                }
                lblCreator.Text = participant.FirstName + " " + participant.LastName;
                RefreshBeneficiaries(expenses, (int)depense.Tag);
            }

            //Merci vero
            foreach(Label l in pnlListExpenditure.Controls.OfType<Label>())
            {
                if(l.Tag != depense.Tag)
                    l.ForeColor = Color.FromArgb(12, 12, 12);
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

      
        private void btnAddExpenditure_Click(object sender, EventArgs e)
        {
            //Ajout du panel bulle pour l'ajout
            Panel pnlBulleEmplacement = new Panel();
            pnlBulleEmplacement.Size = new Size(705, 405);
            Point coordonneePanel = new Point(127, 115);
            pnlBulleEmplacement.Location = coordonneePanel;
            this.Controls.Add(pnlBulleEmplacement);
            pnlBulleEmplacement.BringToFront();

            PartyEvent currentEvent = PartyEvent.GetFromId((int)cboEvenement.SelectedValue);

            BulleAjDepense bulleAjDepense = new BulleAjDepense(currentEvent);
            bulleAjDepense.setPanel = pnlBulleEmplacement;
            bulleAjDepense.setPanelPrincipal = ecran;
            pnlBulleEmplacement.Controls.Add(bulleAjDepense);
            pnlBulleEmplacement.Visible = true;

        }

        private void btnAddBeneficiary_Click(object sender, EventArgs e)
        {
           //

        }
    }
}
