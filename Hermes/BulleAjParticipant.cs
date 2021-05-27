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
    public partial class BulleAjParticipant : UserControl
    {
        public Delegate annuler;
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

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            annuler.DynamicInvoke();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool valide = true;
            if (txtFirstName.Text.Length < 2)
            {
                //AVEC DES ALERTES SUR LES CHAMPS NON REMPLIS
                valide = false;
            }
            if (txtLastName.Text.Length < 2)
            {
                valide = false;
            }
            if (txtMail.Text.Length < 8 && !txtMail.Text.Contains("@"))
            {
                valide = false;
            }

            if (txtPhoneNumber.Text.Length < 8)
            {
                valide = false;
            }


           
            if (valide)
            {

                //Creation du nouveau participant
                Participant newParticipant = new Participant()
                {
                    CodeParticipant = 0,
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    NbParts = int.Parse(txtPhoneNumber.Text),
                    //Balance = null,
                    Mail = txtMail.Text,
                };

                //Database.InsertParticipant(newParticipant)
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }
    }
}
