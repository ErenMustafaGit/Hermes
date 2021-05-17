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
    public partial class SideBarUserControls : UserControl
    {
        private Panel ecrans;
        public SideBarUserControls()
        {
            InitializeComponent();
        }
       
        public Panel setPanel
        {
            set { this.ecrans = value; }
        }

        public Panel getSideBar
        {
            get => this.sideBar;
        }

        private void SibeBarUS_Load(object sender, EventArgs e)
        {

        }

        private void LblIconeAccueil_Click(object sender, EventArgs e)
        {
            this.ecrans.Controls.Clear();
            Accueil a = new Accueil();
            this.ecrans.Controls.Add(a);
        }

        private void LblIconeEvenement_Click(object sender, EventArgs e)
        {
            this.ecrans.Controls.Clear();
            Evenements ee = new Evenements();
            this.ecrans.Controls.Add(ee);
        }

        private void SideBarUserControls_Load(object sender, EventArgs e)
        {

        }
    }
}
