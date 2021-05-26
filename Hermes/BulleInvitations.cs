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
    public partial class BulleInvitations : UserControl
    {
        private static Panel ecran;
        private static Panel pnlBulle;

        public Panel setPanelPrincipal
        {
            set { ecran = value; }
        }

        public Panel setPanelBulle
        {
            set { pnlBulle = value; }
        }

        public BulleInvitations()
        {
            InitializeComponent();
        }

        private void BulleInvitations_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlBulle.Controls.Clear();
            pnlBulle.Visible = false;
        }
    }
}
