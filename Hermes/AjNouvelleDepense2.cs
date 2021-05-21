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
        Decimal Montant;
        public AjNouvelleDepense2(int codeEvenement, DateTime date, string description, int codePayeur, Decimal montant)
        {
            InitializeComponent();
            this.CodeEvenement = codeEvenement;
            this.Date = date;
            this.Description = description;
            this.CodePayeur = codePayeur;
            this.Montant = montant;
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
                chkGuest.Left = chkEveryOne.Left;
                chkGuest.Top = 50 + 30 * i;
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
            
            Expenditure newExpenditure = new Expenditure()
            {
                NumExpenditure = 100,
                Description = this.Description,
                Comment = rtxtCommentaire.Text,
                DateExpenditure = this.Date,
                CodeEvent = this.CodeEvenement,
                CodeParticipant = this.CodePayeur,
            };
            //Database.InsertExpenditure(newExpenditure);
        }
    }
}
