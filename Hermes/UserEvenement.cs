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
        public int index;
        public UserEvenement()
        {
            InitializeComponent();
            lblIconeCreateurParticipant.Text = Hermes.UI.Icons.USER;
        }

        public int setIndex
        {
            set { this.index = value; }
        }

        private void UserEvenement_Load(object sender, EventArgs e)
        {

        }

        private void lblIconeCreateurParticipant_Click(object sender, EventArgs e)
        {

        }

        private void appFontLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
