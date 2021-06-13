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

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool valide = true;
            if (txtLastName.Text.Length < 1 || String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                //AVEC DES ALERTES SUR LES CHAMPS NON REMPLIS
                valide = false;
                txtLastName.BackColor = Color.LightPink;

                AppToast.CreateErrorToast("Veuillez entrer un nom valide !")
                        .SetDurationInSeconds(15).ShowToast();
            }
            if (txtFirstName.Text.Length < 1 || String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                valide = false;
                txtFirstName.BackColor = Color.LightPink;

                AppToast.CreateErrorToast("Veuillez entrer un prénom valide !")
                        .SetDurationInSeconds(15).ShowToast();
            }

            if (!EmailManager.IsEmailValid(txtMail.Text))
            {
                valide = false;
                txtMail.BackColor = Color.LightPink;

                AppToast.CreateErrorToast("L'adresse email entrée est invalide !")
                        .SetDurationInSeconds(15).ShowToast();
            }

            if (txtPhoneNumber.Text.Length < 6)
            {
                valide = false;
                txtPhoneNumber.BackColor = Color.LightPink;

                AppToast.CreateErrorToast("Numéro de téléphone trop court !")
                        .SetDurationInSeconds(15).ShowToast();
            }


           
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
            e.Handled = true;
            txtPhoneNumber.BackColor = Color.LightPink;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                txtPhoneNumber.BackColor = Color.White;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                txtMail.Focus();
                txtPhoneNumber.BackColor = Color.White;
            }
        }

        private void TxtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

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
    }
}
