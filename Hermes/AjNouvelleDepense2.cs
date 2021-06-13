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
using Hermes.UI;

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

        private int indiceEvenement;
        private int indicePayePar;

        public AjNouvelleDepense2(int codeEvenement, DateTime date, string description, int codePayeur, Decimal amount, int indiceEvenement, int indicePayePar)
        {
            InitializeComponent();
            this.CodeEvenement = codeEvenement;
            this.Date = date;
            this.Description = description;
            this.CodePayeur = codePayeur;
            this.Amount = amount;
            this.indiceEvenement = indiceEvenement;
            this.indicePayePar = indicePayePar;
            lblGoBaaack.Text = Hermes.UI.Icons.LEFT;

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
            FontFamily helvetica = FontManager.GetFontFamily(AppFont.HelveticaNeue);
            FontFamily helvetica_bold = FontManager.GetFontFamily(AppFont.HelveticaNeue_Bold);
            btnCancel.Font = new Font(helvetica, btnCancel.Font.Size);
            btnValider.Font = new Font(helvetica, btnValider.Font.Size);
            chkEveryOne.Font = new Font(helvetica_bold, chkEveryOne.Font.Size + 3);
            rtxtCommentaire.Font = new Font(helvetica, rtxtCommentaire.Font.Size);

            PartyEvent evenement = PartyEvent.GetFromId(this.CodeEvenement);
            List<Participant> guests = evenement.GetGuests();

            int compteur = 0;
            for(int i = 0; i < guests.Count; i++)
            {
                if (guests[i].CodeParticipant != CodePayeur)
                {
                    CheckBox chkGuest = new CheckBox();
                    chkGuest.Text = guests[i].FirstName + " " + guests[i].LastName;
                    chkGuest.Tag = guests[i].CodeParticipant;

                    chkGuest.Left = chkEveryOne.Left;
                    chkGuest.Top = 50 + 30 * compteur;
                    chkGuest.AutoSize = false;
                    chkGuest.Width = 300;
                    chkGuest.Height = 22;
                    chkGuest.Font = new Font(helvetica, chkEveryOne.Font.Size - 3);
                    pnlBeneficiaire.Controls.Add(chkGuest);
                    compteur++;
                }    
            }
            if (compteur == 0)
            {
                chkEveryOne.Text = "Aucune personne\n(autre que le créateur)";
                chkEveryOne.Enabled = false;
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

            if (rtxtCommentaire.Text == "")
            {
                rtxtCommentaire.Text = " ";
            }
            string comment = rtxtCommentaire.Text;
            Expense newExpense = new Expense()
            {
                Amount = this.Amount,
                Description = this.Description,
                Comment = comment,
                Date = this.Date,
                EventId = this.CodeEvenement,
                AuthorId = this.CodePayeur,
            };

            Database.InsertExpense(newExpense, getBeneficiary());

            AppToast.CreateSuccessToast("La dépense a été ajoutée !")
                .SetDurationInSeconds(15)
                .ShowToast();

            this.ecran.Controls.Clear();
            Accueil a = new Accueil();
            a.setPanel = this.ecran;
            this.ecran.Controls.Add(a);

        }
        public List<Participant> getBeneficiary()
        {
            List<Participant> beneficiary = new List<Participant>();
            beneficiary.Add(Participant.GetParticipant(this.CodePayeur));
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
            result = MessageBox.Show(this, message, "Hermès", buttons,
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

        private void lblGoBaaack_Click(object sender, EventArgs e)
        {
            AjNouvelleDepense ajNouvelleDepense = new AjNouvelleDepense(true, CodeEvenement, Date, Description, CodePayeur, Amount, indiceEvenement, indicePayePar, ecran);
            this.ecran.Controls.Clear();
            this.ecran.Controls.Add(ajNouvelleDepense);
        }

        private void ClickableMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void ClickableMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
