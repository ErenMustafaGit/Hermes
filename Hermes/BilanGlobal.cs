using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hermes.DataModel;

namespace Hermes
{
    public partial class BilanGlobal : UserControl
    {
        private PartyEvent currentEvent;
        public Panel ecran;

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        public BilanGlobal(PartyEvent partyEvent)
        {
            this.currentEvent = partyEvent;
            InitializeComponent();
        }

        private void BilanGlobal_Load(object sender, EventArgs e)
        {

        }
    }
}
