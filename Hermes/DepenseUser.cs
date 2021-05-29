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
    public partial class DepenseUser : UserControl
    {
        private DateTime dateDepense;
        private string description;
        private Decimal montant;
        /*
        public DepenseUser()
        {
            InitializeComponent();
        }
        */
        public DepenseUser(DateTime dateDepense, string description, Decimal montant)
        {
            this.dateDepense = dateDepense;
            this.description = description;
            this.montant = montant;
            InitializeComponent();
        }


        private void DepenseUser_Load(object sender, EventArgs e)
        {
            lblAmountDepense.Text = this.montant + "€";
            lblDateDepense.Text = this.dateDepense.ToLongDateString();
            lblNomDepense.Text = this.description;
        }
    }
}
