using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hermes
{
    public partial class AjoutRapideBouton : UserControl
    {

        public AjoutRapideBouton()
        {
            InitializeComponent();
        }

        private void AjoutRapideBouton_Load(object sender, EventArgs e)
        {
            this.cbbEvenements.Size = new Size(245, 30);
        }
    }
}
