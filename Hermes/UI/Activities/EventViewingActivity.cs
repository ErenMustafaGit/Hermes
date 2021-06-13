using Hermes.DataModel;
using Hermes.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes.UI.Activities
{
    public partial class EventViewingActivity : UserControl
    {
        private int m_OpenedOn = -1;
        private BindingSource m_Source;

        public EventViewingActivity(int currentId = -1)
        {
            InitializeComponent();

            m_OpenedOn = currentId;
        }

        public EventViewingActivity(PartyEvent current)
            : this(current.Id)
        {
        }

        // Honestly, won't change this at this point... Alexander wrote it this way, I don't like it at all, but well...

        public Panel ecran;
        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void backLabels_Click(object sender, EventArgs e)
        {
            Evenements evenements = new Evenements();
            evenements.setPanel = this.ecran;
            this.ecran.Controls.Clear();
            this.ecran.Controls.Add(evenements);
        }
        // 

        private void SetupIcons()
        {
            calendarIconLabel.Text = Icons.CALENDAR_1;

            backArrowLabel.Text = Icons.LEFT;

            // Navigation bar.
            firstItemLabel.Text = Icons.DOUBLE_LEFT;
            previousItemLabel.Text = Icons.LEFT;
            nextItemLabel.Text = Icons.RIGHT;
            lastItemLabel.Text = Icons.DOUBLE_RIGHT;
        }

        private void SetupBindings()
        {
            m_Source = Database.GetBindingSource("Evenements");
            m_Source.CurrentChanged += OnSourceRowChanged;

            // Add bindings for basic text fields.
            this.eventNameLabel.DataBindings.Add(new Binding(
                nameof(this.eventNameLabel.Text), m_Source, "titreEvent"));
            this.descriptionLabel.DataBindings.Add(new Binding(
                nameof(this.descriptionLabel.Text), m_Source, "description"));

            // Add bindings for dates.
            {
                ConvertEventHandler formatFrenchDate = 
                    (_, e) => e.Value = ((DateTime)e.Value).ToFrenchLongDateString();

                Binding b = new Binding(nameof(this.dateBeginLabel.Text), m_Source, "dateDebut");
                b.Format += formatFrenchDate;
                this.dateBeginLabel.DataBindings.Add(b);
                
                b = new Binding(nameof(this.dateEndLabel.Text), m_Source, "dateFin");
                b.Format += formatFrenchDate;
                this.dateEndLabel.DataBindings.Add(b);
            }

            // Add bindings for "completed" label and icon.
            {
                Binding b = new Binding(nameof(this.completedIconLabel.Text), m_Source, "soldeON");
                b.Format += (_, e) => e.Value = (bool)e.Value ? Icons.TICK_OPEN_CIRCLE : Icons.CLOCK;
                this.completedIconLabel.DataBindings.Add(b);

                b = new Binding(nameof(this.completedTextLabel.Text), m_Source, "soldeON");
                b.Format += (_, e) => e.Value = (bool)e.Value ? "Soldé" : "Non soldé";
                this.completedTextLabel.DataBindings.Add(b);
            }

            if (m_OpenedOn != -1)
                m_Source.Position = m_OpenedOn;
        }

        // Would be preferable to have this fully automated using bindings as well, but this sounds like
        // it would require implementing custom controls and all for this to work well.
        private void UpdateInvitedList()
        {
            // Fetch the currently selected row.
            DataRowView dataRowView = (DataRowView)m_Source.Current;

            // Get the author's ID.
            int authorId = (int)dataRowView["codeCreateur"];

            // Fetch the list of people invited to the current event.
            PartyEvent currentEvent = new PartyEvent() { Id = (int)dataRowView["codeEvent"] };
            List<Participant> invited = currentEvent.GetGuests();

            // Retrieve the author from the list, then remove it from that list.
            int authorIndex = invited.FindIndex(p => p.CodeParticipant == authorId);
            Participant author = null;

            // It may be possible that the author isn't invited to its own event...
            if (authorIndex != -1)
            {
                author = invited[authorIndex];
                invited.RemoveAt(authorIndex);
            }

            // Clear the UI list, disable layout calculations.
            invitedPanel.Controls.Clear();
            invitedPanel.SuspendLayout();

            // Add the author first.
            int pos = 0;
            if (author != null)
            {
                UserEvenement authorViewItem = new UserEvenement();
                authorViewItem.setCodeCreateur = authorId;
                authorViewItem.recupParticipant = author;
                authorViewItem.Top = 20 + 80 * pos++;
                invitedPanel.Controls.Add(authorViewItem);
            }

            // Then, add all of the other guests.
            foreach (Participant p in invited)
            {
                UserEvenement user = new UserEvenement();
                user.setCodeCreateur = authorId;
                user.recupParticipant = p;
                user.Top = 20 + 80 * pos++;
                invitedPanel.Controls.Add(user);
            }

            // Resume layout calculations.
            invitedPanel.ResumeLayout(true);
        }

        private void OnSourceRowChanged(object sender, EventArgs e)
        {
            // Update the current position on the UI when it gets changed.
            this.currentIndexLabel.Text = (m_Source.Position + 1).ToString();

            // Manually update the invited list.
            this.UpdateInvitedList();
        }

        private void EventViewingActivity_Load(object sender, EventArgs e)
        {
            this.SetupIcons();

            // Enable the vertical scroll bar on the invited people panel, only when required.
            invitedPanel.HorizontalScroll.Enabled = false;
            invitedPanel.HorizontalScroll.Visible = false;
            invitedPanel.HorizontalScroll.Maximum = 0;
            invitedPanel.AutoScroll = true;

            this.SetupBindings();

            // Set the maximum amount of events that exist on the navigation system.
            this.maximumIndexLabel.Text = m_Source.Count.ToString();

            // Force a refresh of the invited list.
            this.UpdateInvitedList();
        }

        private void firstItemLabel_Click(object sender, EventArgs e) => m_Source.Position = 0;
        private void previousItemLabel_Click(object sender, EventArgs e) => m_Source.Position--;
        private void nextItemLabel_Click(object sender, EventArgs e) => m_Source.Position++;
        private void lastItemLabel_Click(object sender, EventArgs e) => m_Source.Position = m_Source.Count - 1;

        private void Clickable_MouseEnter(object sender, EventArgs e) => this.Cursor = Cursors.Hand;
        private void Clickable_MouseLeave(object sender, EventArgs e) => this.Cursor = Cursors.Default;
    }
}
