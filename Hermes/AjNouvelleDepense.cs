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
    public partial class AjNouvelleDepense : UserControl
    {
        Panel ecran;
        public AjNouvelleDepense()
        {
            InitializeComponent();
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }


    }
}
