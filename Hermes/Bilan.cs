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
    public partial class Bilan : UserControl
    {
        public Panel ecran;
        public Panel setPanel
        {
            set { this.ecran = value; }
        }
        public Bilan()
        {
            InitializeComponent();
            pnlEvenement.AutoScroll = false;
            pnlEvenement.HorizontalScroll.Enabled = false;
            pnlEvenement.HorizontalScroll.Visible = false;
            pnlEvenement.HorizontalScroll.Maximum = 0;
            pnlEvenement.AutoScroll = true;
        }

        private void Bilan_Load(object sender, EventArgs e)
        {
            List<PartyEvent> events = Database.FetchEvents();

            int modulo = 2;
            for (int i = 0; i < events.Count; i++)
            {
                ResumeEventBilan resumeEventBilan = new ResumeEventBilan(events[i].Name, events[i].Description, events[i].GetNbPart(), events[i].StartDate, events[i].EndDate, events[i].AuthorId);
                resumeEventBilan.setPanel = this.ecran;
                resumeEventBilan.setEvent = events[i];
                resumeEventBilan.Top = 20 + 250 * (i  / modulo);
                resumeEventBilan.Left = 100 + 350 * (i % modulo);
                pnlEvenement.Controls.Add(resumeEventBilan);

            }
        }
    }
}
