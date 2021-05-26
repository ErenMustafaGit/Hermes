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
    public partial class BulleAjDepense2 : UserControl
    {
        private decimal montant;
        private string description;
        private int codeParticipant;
        private int codeEvenement;
        private DateTime dateDepense;


        private Panel pnlBulleEmplacement;
        private Panel pnlPrincipal;

        public BulleAjDepense2(decimal montant, string description, int codeParticipant, int codeEvenement, DateTime dateDepense, Panel pnlPrincipal, Panel pnlBulleEmplacement)
        {
            this.montant = montant;
            this.description = description;
            this.codeEvenement = codeEvenement;
            this.codeParticipant = codeParticipant;
            this.dateDepense = dateDepense;
            this.pnlPrincipal = pnlPrincipal;
            this.pnlBulleEmplacement = pnlBulleEmplacement;
            InitializeComponent();
        }

        private void BulleAjDepense2_Load(object sender, EventArgs e)
        {
            PartyEvent evenement = PartyEvent.GetFromId(this.codeEvenement);
            List<Participant> guests = evenement.GetGuests();
            for (int i = 0; i < guests.Count; i++)
            {
                CheckBox chkGuest = new CheckBox();
                chkGuest.AutoSize = true;
                chkGuest.Text = guests[i].LastName + " " + guests[i].FirstName;
                chkGuest.Left = chkEveryOne.Left;
                chkGuest.Top = 50 + 30 * i;
                chkGuest.Tag = i;
                pnlBeneficiaire.Controls.Add(chkGuest);
            }
        }

        private void ChkEveryOne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEveryOne.Checked)
            {
                changeAllChk(true);
            }
            else
            {
                changeAllChk(false);
            }
        }

        public void changeAllChk(bool state)
        {
            for (int i = 0; i < pnlBeneficiaire.Controls.Count; i++)
            {
                CheckBox chkGuest = (CheckBox)pnlBeneficiaire.Controls[i];
                chkGuest.Checked = state;
            }

        }

        private void BtnContinuer_Click(object sender, EventArgs e)
        {
            bool done = false;

            foreach (CheckBox chk in pnlBeneficiaire.Controls)
            {
                if (chk.Checked)
                    done = true;
            }
            if (rtxtCommentaire.Text == "")
            {
                rtxtCommentaire.BackColor = Color.LightPink;
                done = false;
            }

            if (done)
            {
                string comment = rtxtCommentaire.Text.Replace('\'', ' ');
                Expense newExpenditure = new Expense()
                {
                    Id = 100,
                    Amount = this.montant,
                    Description = this.description,
                    Comment = rtxtCommentaire.Text,
                    Date = this.dateDepense.Date,
                    EventId = this.codeEvenement,
                    AuthorId = this.codeParticipant,
                };

                Database.InsertExpense(newExpenditure, getBeneficiary());
                //UNE POPUP A AJOUTER
                MessageBox.Show("AJOUTE POPUP");

                this.pnlBulleEmplacement.Controls.Clear();
                this.pnlBulleEmplacement.Visible = false;
            }
        }

        public List<Participant> getBeneficiary()
        {
            List<Participant> beneficiary = new List<Participant>();
            foreach (CheckBox chk in pnlBeneficiaire.Controls)
            {
                if (chk.Checked && chk != chkEveryOne)
                {
                    beneficiary.Add(Participant.GetParticipant((int)chk.Tag));
                }
            }

            return beneficiary;
        }

    }
}
