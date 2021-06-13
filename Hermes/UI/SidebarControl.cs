﻿using System;
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

namespace Hermes.UI
{
    public partial class SidebarControl : UserControl
    {
        enum MenuItem
        {
            Invalid = 0,
            Home,
            Events,
            Invited,
            Spendings,
            Summaries
        }

        private Panel ecrans;
        private static Color BLUE = ColorTranslator.FromHtml("#2693f8");
        private static Color WHITE = Color.FromArgb(249, 249, 249);

        private const int RETRACTED_WIDTH = 116;
        private const int DEPLOYED_WIDTH = 280;
        private const int RETRACT_INTERVAL = 100; // ms

        private bool m_Deployed = false;
        private MenuItem m_Selected = MenuItem.Home;
        private Timer m_RetractTimer = new Timer();
        private bool m_EnteredLabel = false;

        public SidebarControl()
        {
            InitializeComponent();

            // Setup icons.
            lblIconeAccueil.Text = Icons.HOME;
            lblIconeEvenement.Text = Icons.CALENDAR_1;
            lblIconeParticipant.Text = Icons.USER_GROUP;
            lblIconeDepense.Text = Icons.MONEY_BAG;
            lblIconeBilan.Text = Icons.CLIPBOARD;

            // Setup item labels.
            lblIconeAccueil.Tag = lblAccueil.Tag = MenuItem.Home;
            lblIconeEvenement.Tag = lblEvenements.Tag = MenuItem.Events;
            lblIconeParticipant.Tag = lblParticipants.Tag = MenuItem.Invited;
            lblIconeDepense.Tag = lblDepenses.Tag = MenuItem.Spendings;
            lblIconeBilan.Tag = lblBilan.Tag = MenuItem.Summaries;

            // Setup the retract timer.
            m_RetractTimer.Interval = RETRACT_INTERVAL;
            m_RetractTimer.Tick += OnRetractTimerTick;
        }

        public Panel setPanel
        {
            set { this.ecrans = value; }
        }

        private void Deploy()
        {
            m_RetractTimer.Stop();

            if (m_Deployed)
                return;

            this.Size = new Size(DEPLOYED_WIDTH, this.Size.Height);
            m_Deployed = true;
        }

        private void Retract()
        {
            if (!m_Deployed)
                return;

            m_RetractTimer.Start();
        }

        // We use a timer to workaround some WinForms quirks.
        private void OnRetractTimerTick(object sender, EventArgs e)
        {
            m_RetractTimer.Stop();

            this.Size = new Size(RETRACTED_WIDTH, this.Size.Height);
            m_Deployed = false;
        }

        private void RefreshMenu()
        {
            // Set all labels who have the same tag as the current selection to blue, otherwise they are set to white.
            foreach (Control c in this.Controls)
            {
                if (c is AppFontLabel l)
                {
                    if ((MenuItem)l.Tag == m_Selected)
                    {
                        l.ForeColor = BLUE;
                    }
                    else
                    {
                        l.ForeColor = WHITE;
                    }
                }
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            m_Selected = (MenuItem)((Control)sender).Tag;

            this.RefreshMenu();

            // Have to make-do with what I've got here
            this.ecrans.Controls.Clear();
            switch (m_Selected)
            {
                case MenuItem.Home:
                    Accueil a = new Accueil();
                    a.setPanel = this.ecrans;
                    this.ecrans.Controls.Add(a);
                    break;

                case MenuItem.Events:
                    Evenements ee = new Evenements();
                    ee.setPanel = this.ecrans;
                    this.ecrans.Controls.Add(ee);
                    break;

                case MenuItem.Invited:
                    Participants participants = new Participants();
                    participants.setPanel = this.ecrans;
                    this.ecrans.Controls.Add(participants);
                    break;

                case MenuItem.Spendings:
                    ViewExpenditures expendituresView = new ViewExpenditures();
                    expendituresView.setPanel = this.ecrans;
                    this.ecrans.Controls.Add(expendituresView);
                    break;

                case MenuItem.Summaries:
                    Bilan bilan = new Bilan();
                    bilan.setPanel = this.ecrans;
                    this.ecrans.Controls.Add(bilan);
                    break;
            }
        }

        private void SideBarUserControls_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.MouseEnter += new EventHandler(Control_MouseEnter);
                c.MouseLeave += new EventHandler(Control_MouseLeave);
            }

            this.RefreshMenu();
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.Deploy();
            m_EnteredLabel = true;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            m_EnteredLabel = false;
        }

        private void SidebarControl_MouseEnter(object sender, EventArgs e)
        {
            this.Deploy();
        }

        private void SidebarControl_MouseLeave(object sender, EventArgs e)
        {
            // Hacky way to handle weird WinForms event ordering.
            if (m_EnteredLabel)
            {
                m_EnteredLabel = false;
                return;
            }

            this.Retract();
        }
    }
}
