﻿using System;
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
    public partial class BulleAjDepense : UserControl
    {
        private static Panel pnlBulleEmplacement;
        private static Panel pnlPrincipal;
        public Panel setPanel
        {
            set { pnlBulleEmplacement = value; }
        }

        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }

        public BulleAjDepense()
        {
            InitializeComponent();
        }

        private void BulleAjDepense_Load(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlBulleEmplacement.Controls.Clear();
            pnlBulleEmplacement.Visible = false;
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            pnlBulleEmplacement.Controls.Clear();
            BulleAjDepense2 bulleAjDepense2 = new BulleAjDepense2();
            pnlBulleEmplacement.Controls.Add(bulleAjDepense2);
        }
    }
}
