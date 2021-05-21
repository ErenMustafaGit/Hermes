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
        public Panel ecran;
        public Evenements()
        {
            InitializeComponent();
            
            ScrollBar scrollbar = new VScrollBar();
            scrollbar.Dock = DockStyle.Right;
            pnlScroll.Controls.Add(scrollbar);
            //scrollbar.Scroll += (sender, e)

            pnlScroll.AutoScroll = false;
            pnlScroll.HorizontalScroll.Enabled = false;
            pnlScroll.HorizontalScroll.Visible = false;
            pnlScroll.HorizontalScroll.Maximum = 0;
            pnlScroll.AutoScroll = true;
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void Evenements_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            List<PartyEvent> events = database.FetchEvents();

            pnlAddEvent.Visible = false;
            AjoutEvenement ajoutEvent = new AjoutEvenement();
            ajoutEvent.setPanel = this.pnlAddEvent;
            ajoutEvent.Top = 20;
            ajoutEvent.Left = 100;
            pnlScroll.Controls.Add(ajoutEvent);

            int modulo = 2;
            for(int i = 0; i<events.Count; i++)
            {
                ResumePartyEvent resumeEvent = new ResumePartyEvent(events[i].Title, events[i].Description, events[i].GetNbPart(), events[i].BeginDate, events[i].EndDate, events[i].CodeCreator);
                resumeEvent.setPanel = this.ecran;
                resumeEvent.setIndex = i;
                resumeEvent.Top = 20 + 250 * ((i + 1) / modulo);
                resumeEvent.Left = 100 + 350 * ((i + 1) % modulo);
                pnlScroll.Controls.Add(resumeEvent);

            }
            
        }

        private void PnlAddEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
