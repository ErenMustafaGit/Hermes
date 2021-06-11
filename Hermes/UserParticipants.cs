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
    public partial class UserParticipants : UserControl
    {
        public Participant participant;
        public UserParticipants()
        {
            InitializeComponent();
            lblIconeMail.Text = Hermes.UI.Icons.MAIL;
            lblIconeTel.Text = Hermes.UI.Icons.PHONE;
            lblIconePart.Text = Hermes.UI.Icons.FINANCE;
        }

        public Participant SetParticipant
        {
            set { this.participant = value; }
        }


        private void UserParticipants_Load(object sender, EventArgs e)
        {

            lblPrenomNom.Text = this.participant.LastName + " " + this.participant.FirstName;
            if(lblPrenomNom.Text.Length > 20)
            {
                lblPrenomNom.Left -= 20;
                lblPrenomNom.AppFontHeight -= 6;
            }
            // Espacement sur le numéro de téléphone
            lblTel.Text = Espacement(this.participant.PhoneNumber);

            lblEmail.Text = this.participant.Mail;
            lblNbPart.Text = this.participant.NbParts.ToString() + " part(s)";
        }

        //Permet de faire un espacement de un entre chaque dizaine
        public string Espacement(string numEspace)
        {
            string temp = "";
            for (int i = 0; i < numEspace.Length; i++)
            {
                temp += numEspace[i];
                if (i == 1 || i == 3 || i == 5 || i == 7)
                    temp += " ";

            }
            return temp;
        }
    }
}
