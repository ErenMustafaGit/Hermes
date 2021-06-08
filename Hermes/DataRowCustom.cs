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
    public partial class DataRowCustom : UserControl
    {
        private string name;
        private double plus;
        private double moins;
        public DataRowCustom(string name, double plus, double moins)
        {
            InitializeComponent();
            this.name = name;
            this.plus = plus;
            this.moins = moins;
        }

        public void ChangeColor()
        {
            this.BackColor = Color.FromArgb(238, 250, 255);
        }

        private void DataRowCustom_Load(object sender, EventArgs e)
        {
            lblPersonnes.Text = name;
            lblPlus.Text = plus.ToString("0.00");
            lblMoins.Text = moins.ToString("0.00");
            lblSolde.Text = (plus - moins).ToString("0.00");
        }
    }
}
