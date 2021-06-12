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

            pnlBeneficiaire.HorizontalScroll.Enabled = false;
            pnlBeneficiaire.HorizontalScroll.Visible = false;
            pnlBeneficiaire.HorizontalScroll.Maximum = 0;
            pnlBeneficiaire.AutoScroll = true;

        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void AjNouvelleDepense2_Load(object sender, EventArgs e)
        {
            PartyEvent evenement = PartyEvent.GetFromId(this.CodeEvenement);
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
            Participant payeur = Participant.GetParticipant(this.CodePayeur);
            string name = payeur.FirstName + " " + payeur.LastName;

            //Coche celui qui paye car il est forcément bénéficiaire
            foreach (CheckBox chk in pnlBeneficiaire.Controls)
            {
                if (chk.Text == name)
                    chk.Checked = true;
            }


            if (rtxtCommentaire.Text == "")
            {
                rtxtCommentaire.BackColor = Color.LightPink;
            }
            else
            {
                string comment = rtxtCommentaire.Text.Replace('\'', ' ');
                Expense newExpense = new Expense()
                {
                    Id = 100,
                    Amount = this.Amount,
                    Description = this.Description,
                    Comment = comment,
                    Date = this.Date,
                    EventId = this.CodeEvenement,
                    AuthorId = this.CodePayeur,
                };

                Database.InsertExpense(newExpense, getBeneficiary());

                //UNE POPUP A AJOUTER
                MessageBox.Show("AJOUTE POPUP");

                this.ecran.Controls.Clear();
                Accueil a = new Accueil();
                a.setPanel = this.ecran;
                this.ecran.Controls.Add(a);
            }
            
        }
        public List<Participant> getBeneficiary()
        {
            List<Participant> beneficiary = new List<Participant>();
            foreach (CheckBox chk in pnlBeneficiaire.Controls)
            {
                if (chk != chkEveryOne)
                {

                    //Coche automatique de celui qui crée la dépense
                    if ((int)chk.Tag == CodePayeur)
                        chk.Checked = true;

                    if(chk.Checked)
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

        private void rtxtCommentaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rtxtCommentaire.BackColor == Color.LightPink)
                rtxtCommentaire.BackColor = Color.White;

        }
    }
}
