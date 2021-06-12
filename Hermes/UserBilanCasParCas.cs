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
using Hermes.UI;
using Hermes.Extensions;

namespace Hermes
{
    public partial class UserBilanCasParCas : UserControl
    {
        private List<PartyEvent.Due> dues;
        private PartyEvent currentEvent;

        public UserBilanCasParCas(string name, List<PartyEvent.Due> dues, PartyEvent currentEvent)
        {
            this.dues = dues;
            this.currentEvent = currentEvent;
            InitializeComponent();
            lblName.Text = name;
        }

        private void UserBilanCasParCas_Load(object sender, EventArgs e)
        {
            pnlDues.HorizontalScroll.Enabled = false;
            pnlDues.HorizontalScroll.Visible = false;
            pnlDues.HorizontalScroll.Maximum = 0;
            pnlDues.AutoScroll = true;

            int modulo = 1;
            for (int i = 0; i < dues.Count; i++)
            {
                // doit ...
                AppFontLabel arrow = new AppFontLabel();
                arrow.AppFont = AppFont.Icons;
                arrow.Text = Hermes.UI.Icons.RIGHT_ARROW; 
                arrow.Top = 5 + 55 * (i / modulo);
                arrow.Left = 0 + 150 * (i % modulo);
                arrow.AppFontHeight = 25;
                arrow.ForeColor = Color.FromArgb(249, 249, 249);
                arrow.AutoSize = true;


                AppFontLabel duesNeedToGive = new AppFontLabel();
                duesNeedToGive.AppFont = AppFont.HelveticaNeue;
                duesNeedToGive.AppFontHeight = 12;
                duesNeedToGive.Top = 0 + 55 * (i / modulo);
                duesNeedToGive.Left = 60 + 150 * (i % modulo);
                duesNeedToGive.AutoSize = true;
                duesNeedToGive.ForeColor = Color.FromArgb(249, 249, 249);
                duesNeedToGive.Text = "doit " + dues[i].Amount.ToEuros() + "\nà " + dues[i].To.FirstName + " " + dues[i].To.LastName;
                pnlDues.Controls.Add(arrow);
                pnlDues.Controls.Add(duesNeedToGive);
            }
        }
    }
}
