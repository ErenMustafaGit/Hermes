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
    public partial class AjNouvelleDepense2 : UserControl
    {
        Panel ecran;
        int CodeEvenement;
        DateTime Date;
        string Description;
        int CodePayeur;
        Decimal Amount;
        public AjNouvelleDepense2(int codeEvenement, DateTime date, string description, int codePayeur, Decimal amount)
        {
            InitializeComponent();
            this.CodeEvenement = codeEvenement;
            this.Date = date;
            this.Description = description;
            this.CodePayeur = codePayeur;
            this.Amount = amount;
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void AjNouvelleDepense2_Load(object sender, EventArgs e)
        {
            PartyEvent evenement = PartyEvent.GetPartyEvent(this.CodeEvenement);
            List<Participant> guests = evenement.GetGuests();
            for(int i = 0; i < guests.Count; i++)
            {
                CheckBox chkGuest = new CheckBox();
                chkGuest.Text = guests[i].FirstName + " " + guests[i].LastName;
                chkGuest.Tag = guests[i].CodeParticipant;

                chkGuest.Left = chkEveryOne.Left;
                chkGuest.Top = 50 + 30 * i;
                chkGuest.AutoSize = false;
                chkGuest.Width = 300;
                chkGuest.Height = 22;
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

        private void BtnValider_Click(object sender, EventArgs e)
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
                Expenditure newExpenditure = new Expenditure()
                {
                    NumExpenditure = 100,
                    Amount = this.Amount,
                    Description = this.Description,
                    Comment = comment,
                    DateExpenditure = this.Date,
                    CodeEvent = this.CodeEvenement,
                    CodeParticipant = this.CodePayeur,
                };

                
                
                if (Database.InsertExpenditure(newExpenditure, getBeneficiary()))
                {
                    //UNE POPUP A AJOUTER
                    MessageBox.Show("AJOUTE POPUP");

                    this.ecran.Controls.Clear();
                    Accueil a = new Accueil();
                    a.setPanel = this.ecran;
                    this.ecran.Controls.Add(a);
                }
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string message = "Voulez vous vraiment annuler l'ajout ?";
            string caption = "";
            result = result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                this.ecran.Controls.Clear();
                Accueil a = new Accueil();
                a.setPanel = this.ecran;
                this.ecran.Controls.Add(a);
            }
        }
    }
}
