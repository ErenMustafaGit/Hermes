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
    public partial class AjoutEvenement : UserControl
    {
        private Panel bulle;
        public Panel setPanel
        {
            set { this.bulle = value; }
        }
        public AjoutEvenement()
        {
            InitializeComponent();
            lblAdd.Text = Hermes.UI.Icons.PLUS;
        }

        private void AjoutEvenement_Load(object sender, EventArgs e)
        {

        }

        private void LblAdd_MouseClick(object sender, MouseEventArgs e)
        {
            this.bulle.Visible = true;
            this.bulle.BringToFront();
            BulleAjEvenement bulleAjEvenement = new BulleAjEvenement();
            this.bulle.Controls.Add(bulleAjEvenement);

        }

        private void LblAdd_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LblAdd_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
