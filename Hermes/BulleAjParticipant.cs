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
using System.Text.RegularExpressions;

namespace Hermes
{
    public partial class BulleAjParticipant : UserControl
    {
        public Delegate annuler;
        public Panel pnlMain;
        private Panel ecran;

        public Panel SetPanel
        {
            set { this.pnlMain = value; }
        }

        public Panel SetEcran
        {
            set { this.ecran = value; }
        }

        public Delegate Annuler
        {
            set { this.annuler = value; }
        }

        public BulleAjParticipant()
        {
            InitializeComponent();
        }



        private void BulleAjParticipant_Load(object sender, EventArgs e)
        {
            FontFamily helvetica = FontManager.GetFontFamily(AppFont.HelveticaNeue);
            txtFirstName.Font = new Font(helvetica, txtFirstName.Font.Size);
            txtLastName.Font = new Font(helvetica, txtLastName.Font.Size);
            txtMail.Font = new Font(helvetica, txtMail.Font.Size);
            txtPhoneNumber.Font = new Font(helvetica, txtPhoneNumber.Font.Size);
            nudNbPart.Font = new Font(helvetica, nudNbPart.Font.Size);
            btnValider.Font = new Font(helvetica, btnValider.Font.Size);
            button1.Font = new Font(helvetica, button1.Font.Size);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            annuler.DynamicInvoke();
        }

        private bool ValidateFields(bool ignoreEmpty = false, bool sendToasts = false)
        {
            bool valid = true;

            txtPhoneNumber.Text = txtPhoneNumber.Text.Replace(" ", "");
            var phoneNumberMatch = Regex.Match(txtPhoneNumber.Text, @"^(\+[0-9]+)|(0[0-9]{9})$");

            nudNbPart.Validate();

            if ((String.IsNullOrWhiteSpace(txtLastName.Text) || txtLastName.Text.Length < 1) && !ignoreEmpty)
            {
                valid = false;
                txtLastName.BackColor = Color.LightPink;

                if (sendToasts)
                {
                    AppToast.CreateErrorToast("Veuillez entrer un nom valide !")
                            .SetDurationInSeconds(15).ShowToast();
                }
            }

            if ((String.IsNullOrWhiteSpace(txtFirstName.Text) || txtFirstName.Text.Length < 1) && !ignoreEmpty)
            {
                valid = false;
                txtFirstName.BackColor = Color.LightPink;

                if (sendToasts)
                {
                    AppToast.CreateErrorToast("Veuillez entrer un prénom valide !")
                        .SetDurationInSeconds(15).ShowToast();
                }
            }

            if ((String.IsNullOrWhiteSpace(txtMail.Text) && !ignoreEmpty) || (!String.IsNullOrWhiteSpace(txtMail.Text) && !EmailManager.IsEmailValid(txtMail.Text)))
            {
                valid = false;
                txtMail.BackColor = Color.LightPink;

                if (sendToasts)
                {
                    AppToast.CreateErrorToast("L'adresse email entrée est invalide !")
                        .SetDurationInSeconds(15).ShowToast();
                }
            }

            if ((String.IsNullOrWhiteSpace(txtPhoneNumber.Text) && !ignoreEmpty) || (!String.IsNullOrWhiteSpace(txtPhoneNumber.Text) && !phoneNumberMatch.Success))
            {
                valid = false;
                txtPhoneNumber.BackColor = Color.LightPink;

                if (sendToasts)
                {
                    AppToast.CreateErrorToast("Numéro de téléphone invalide !")
                        .SetDurationInSeconds(15).ShowToast();
                }
            }

            return valid;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool valide = this.ValidateFields(sendToasts: true);

            if (valide)
            {
                //Creation du nouveau participant
                Participant newParticipant = new Participant()
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    NbParts = (int)nudNbPart.Value,
                    //Balance = null,
                    Mail = txtMail.Text,
                };
                Database.InsertParticipant(newParticipant);
                pnlMain.Controls.Clear();
                pnlMain.Visible = false;
                ecran.Controls.Clear();

                Participants participants = new Participants();
                participants.setPanel = this.ecran;
                ecran.Controls.Add(participants);


            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPhoneNumber.BackColor = Color.White;

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtMail.Focus();
            }
        }

        //txtLastName_KeyPress !!!! (nom)
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLastName.BackColor = Color.White;

            //Interdiction de mettre un chiffre
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtLastName.BackColor = Color.LightPink;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                txtFirstName.Focus();
            }
        }

        //txtFirstName !!!! (prenom)
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFirstName.BackColor = Color.White;
            //Interdiction de mettre un chiffre
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtFirstName.BackColor = Color.LightPink;
            }
            else if (e.KeyChar == (char)Keys.Enter )
            {
                nudNbPart.Focus();
            }
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMail.BackColor = Color.White;
            if (e.KeyChar == (char)Keys.Enter)
            {
                nudNbPart.Focus();
            }
        }

        private void nudNbPart_KeyPress(object sender, KeyPressEventArgs e)
        {
            nudNbPart.BackColor = Color.White;
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPhoneNumber.Focus();
            }
        }

        private void Field_FocusLeave(object sender, EventArgs e)
        {
            this.ValidateFields(ignoreEmpty: true);
        }
    }
}
