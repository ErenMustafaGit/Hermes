using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes.UI
{
    public partial class AppToast : UserControl
    {
        private const int TickRate = 16; // 16 ms, approx 60hz
        public EventHandler OnClosed;
        
        public Color BackgroundColor
        {
            get => this.BackColor;
            set
            {
                this.BackColor = value;
                this.timerPanel.BackColor = ControlPaint.LightLight(value);
            }
        }

        public Color TextColor
        {
            get => this.textLabel.ForeColor;
            set => this.textLabel.ForeColor = this.closeButton.ForeColor = this.iconLabel.ForeColor = value;
        }

        public string Message
        {
            get => this.textLabel.Text;
            set => this.textLabel.Text = value;
        }

        public string Icon
        {
            get => this.iconLabel.Text;
            set => this.iconLabel.Text = value;
        }

        private TimeSpan m_Duration = new TimeSpan();
        private DateTime m_Start, m_PreviousTick;
        private Timer m_Timer;
        private bool m_HasMouseHover;

        public TimeSpan Duration
        {
            get => m_Duration;
            set
            {
                m_Duration = value;
                timerPanel.Visible = m_Duration.Ticks > 0;
            }
        }

        public AppToast()
        {
            InitializeComponent();
            this.closeButton.Font = new Font(FontManager.GetFontFamily(AppFont.Icons), 12f);
            this.closeButton.Text = Icons.CLOSE;

            // Handle mouse enter/leave for all subcontrols
            this.MouseEnter += this.OnMouseEnter;
            this.textLabel.MouseEnter += this.OnMouseEnter;
            this.iconLabel.MouseEnter += this.OnMouseEnter;
            this.closeButton.MouseEnter += this.OnMouseEnter;
            this.timerPanel.MouseEnter += this.OnMouseEnter;

            this.MouseLeave += this.OnMouseLeave;
            this.textLabel.MouseLeave += this.OnMouseLeave;
            this.iconLabel.MouseLeave += this.OnMouseLeave;
            this.closeButton.MouseLeave += this.OnMouseLeave;
            this.timerPanel.MouseLeave += this.OnMouseLeave;
        }

        public AppToast SetDuration(TimeSpan duration)
        {
            this.Duration = duration;
            return this;
        }

        public AppToast SetDurationInSeconds(double s)
        {
            this.Duration = TimeSpan.FromSeconds(s);
            return this;
        }

        public AppToast SetDurationInMilliseconds(double ms)
        {
            this.Duration = TimeSpan.FromMilliseconds(ms);
            return this;
        }

        public AppToast SetIcon(string icon)
        {
            this.Icon = icon;
            return this;
        }

        public void OnAdded()
        {
            if (m_Duration.Ticks > 0)
            {
                m_Timer = new Timer();
                m_Timer.Interval = TickRate;
                m_Timer.Tick += OnTimerTick;

                m_Start = DateTime.Now;
                m_Timer.Start();
            }
        }

        private void OnMouseEnter(object sender, EventArgs e) => this.m_HasMouseHover = true;
        private void OnMouseLeave(object sender, EventArgs e) => this.m_HasMouseHover = false;

        private void OnTimerTick(object sender, EventArgs e)
        {
            DateTime tick = DateTime.Now;
            TimeSpan elapsed = tick - m_Start;
            if (!m_HasMouseHover)
            {
                if (elapsed > m_Duration)
                {
                    // Close the toast if the duration was elapsed
                    this.Close();
                }
                else
                {
                    // Otherwise, resize the "timer" bar
                    double progress = elapsed.TotalMilliseconds / m_Duration.TotalMilliseconds;
                    timerPanel.Width = (int)(this.Width * (1d - progress));
                }
            }
            else
            {
                // Hacky way to prevent the toast's duration from decreasing
                // We just shift the start by the amount of time elapsed since last tick
                m_Start += tick - m_PreviousTick;
            }
            m_PreviousTick = tick;
        }

        public void ShowToast()
        {
            MainForm.ShowToast(this);
        }

        public void Close()
        {
            this.m_Timer.Stop();
            this.OnClosed.Invoke(this, EventArgs.Empty);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static AppToast CreateWarningToast(string message)
        {
            AppToast toast = new AppToast();
            toast.SuspendLayout();

            toast.BackgroundColor = Color.FromArgb(0xFD, 0x7E, 0x14);
            toast.Message = message;
            toast.Icon = Icons.CIRCLED_EXCLAMATION_MARK;

            toast.ResumeLayout();

            return toast;
        }

        public static AppToast CreateErrorToast(string message)
        {
            AppToast toast = new AppToast();
            toast.SuspendLayout();

            toast.BackgroundColor = Color.FromArgb(0xDC, 0x35, 0x45);
            toast.TextColor = Color.White;
            toast.Message = message;
            toast.Icon = Icons.CIRCLED_CROSS;

            toast.ResumeLayout();

            return toast;
        }

        public static AppToast CreateSuccessToast(string message)
        {
            AppToast toast = new AppToast();
            toast.SuspendLayout();

            toast.BackgroundColor = Color.FromArgb(0x20, 0xC9, 0x27);
            toast.TextColor = Color.White;
            toast.Message = message;
            toast.Icon = Icons.CIRCLED_TICK;

            toast.ResumeLayout();

            return toast;
        }
    }
}
