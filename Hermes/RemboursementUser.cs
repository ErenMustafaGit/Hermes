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
    public partial class RemboursementUser : UserControl
    {
        private Decimal amount;
        private double nombreDePart;
        public RemboursementUser()
        {
            InitializeComponent();
        }

        public RemboursementUser(double nombreDePart, Decimal amount)
        {
            this.nombreDePart = nombreDePart;
            this.amount = amount;
            InitializeComponent();
        }

        private void RemboursementUser_Load(object sender, EventArgs e)
        {
            lblNbrPart.Text = "Nombre de part : " + this.nombreDePart;
            lblAmountDepense.Text = this.amount + "€";
        }
    }
}
