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
    public partial class Evenements : UserControl
    {
        public Evenements()
        {
            InitializeComponent();
            /*
            ScrollBar scrollbar = new VScrollBar();
            scrollbar.Dock = DockStyle.Right;
            pnlScroll.Controls.Add(scrollbar);
            //scrollbar.Scroll += (sender, e)*/

            pnlScroll.AutoScroll = false;
            pnlScroll.HorizontalScroll.Enabled = false;
            pnlScroll.HorizontalScroll.Visible = false;
            pnlScroll.HorizontalScroll.Maximum = 0;
            pnlScroll.AutoScroll = true;
        }

        private void Evenements_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            List<PartyEvent> events = database.FetchEvents();

            int modulo = 3;
            for(int i = 0; i<events.Count; i++)
            {
                ResumePartyEvent resumeEvent = new ResumePartyEvent(events[i].TitleEvent, events[i].Description, events[i].GetNbPart(), events[i].BeginDate, events[i].EndDate, events[i].CodeCreator);
                resumeEvent.Top = 20 + 232* (i%modulo);
                resumeEvent.Left = 100 + 350 * (i/modulo);
                pnlScroll.Controls.Add(resumeEvent);
            }
            
        }



        
    }
}
