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
        public AjoutEvenement()
        {
            InitializeComponent();
            lblAdd.Text = Hermes.UI.Icons.PLUS;
        }

        private void AjoutEvenement_Load(object sender, EventArgs e)
        {

        }
    }
}
