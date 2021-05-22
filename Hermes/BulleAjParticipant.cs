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
    public partial class BulleAjParticipant : UserControl
    {
        public Delegate annuler;
        public Delegate Annuler
        {
            set { this.annuler = value; }
        }

        public BulleAjParticipant()
        {
            InitializeComponent();
        }



        private void BulleAjParticipant_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            annuler.DynamicInvoke();
        }
    }
}
