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
    public partial class UserParticipants : UserControl
    {
        public string prenomNom;
        public string numero;
        public string email;
        public UserParticipants()
        {
            InitializeComponent();
            lblIconeMail.Text = Hermes.UI.Icons.MAIL;
            lblIconeTel.Text = Hermes.UI.Icons.PHONE;
        }

        public string SetPrenomNom
        {
            set { this.prenomNom = value; }
        }

        public string SetNumero
        {
            set { this.numero = value; }
        }

        public string SetEmail
        {
            set { this.email = value; }
        }

        private void UserParticipants_Load(object sender, EventArgs e)
        {
            // Espacement sur le numéro de téléphone
            string numEspace = Espacement(this.numero);

            lblPrenomNom.Text = this.prenomNom;
            lblTel.Text = numEspace;
            lblEmail.Text = this.email;
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
