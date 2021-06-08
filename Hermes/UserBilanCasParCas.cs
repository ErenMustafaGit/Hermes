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
    public partial class UserBilanCasParCas : UserControl
    {
        private Participant participant;
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
                //doit ...
                /*
                UI.AppFontLabel arrow = new UI.AppFontLabel();
                arrow.AppFont = AppFont.Icons;
                arrow.Text = Hermes.UI.Icons.RIGHT_ARROW; 
                arrow.AppFontHeight = 9;
                */

                UI.AppFontLabel duesNeedToGive = new UI.AppFontLabel();
                duesNeedToGive.AppFont = AppFont.HelveticaNeue;
                duesNeedToGive.AppFontHeight = 12;
                duesNeedToGive.Top = 0 + 55 * (i / modulo);
                duesNeedToGive.Left = 0 + 150 * (i % modulo);
                duesNeedToGive.AutoSize = true;
                duesNeedToGive.ForeColor = Color.FromArgb(249, 249, 249);
                duesNeedToGive.Text = "doit " + dues[i].Amount.ToString("0.00") + "€" + "\na " + dues[i].To.FirstName + " " + dues[i].To.LastName;
                pnlDues.Controls.Add(duesNeedToGive);
            }

        }

        private void appFontLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
