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
    public partial class UserEvenement : UserControl
    {
        public Participant participant;
        public int index;
        public int codeCreateur;
        public UserEvenement()
        {
            InitializeComponent();
            lblIconeCreateurParticipant.Text = Hermes.UI.Icons.USER;
            
        }

        public int setCodeCreateur
        {
            set { this.codeCreateur = value; }
        }
 

        public Participant recupParticipant
        {
            set { this.participant = value; }
        }

        

        private void UserEvenement_Load(object sender, EventArgs e)
        {
            lblTxtParticipant.Text = participant.LastName + " " + participant.FirstName;
            if (participant.CodeParticipant == codeCreateur)
            {
                lblIconeCreateurParticipant.Text = Hermes.UI.Icons.CROWN;
            }

        }

        private void lblIconeCreateurParticipant_Click(object sender, EventArgs e)
        {

        }

        private void appFontLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
