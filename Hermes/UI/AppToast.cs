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
        public EventHandler OnClosed;
        
        public Color BackgroundColor
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        public Color TextColor
        {
            get => this.textLabel.ForeColor;
            set => this.textLabel.ForeColor = this.closeButton.ForeColor = value;
        }

        public string Message
        {
            get => this.textLabel.Text;
            set => this.textLabel.Text = value;
        }

        public AppToast()
        {
            InitializeComponent();
            this.closeButton.Font = new Font(FontManager.GetFontFamily(AppFont.Icons), 12f);
            this.closeButton.Text = Icons.CLOSE;
        }

        public void Close()
        {
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

            toast.ResumeLayout();

            return toast;
        }
    }
}
