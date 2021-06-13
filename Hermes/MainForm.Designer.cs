
namespace Hermes
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEcran = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblMinimise = new Hermes.UI.AppFontLabel();
            this.lblExit = new Hermes.UI.AppFontLabel();
            this.sideBarUserControls1 = new Hermes.UI.SidebarControl();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEcran
            // 
            this.pnlEcran.Location = new System.Drawing.Point(115, 0);
            this.pnlEcran.Name = "pnlEcran";
            this.pnlEcran.Size = new System.Drawing.Size(965, 640);
            this.pnlEcran.TabIndex = 3;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlTitleBar.Controls.Add(this.lblMinimise);
            this.pnlTitleBar.Controls.Add(this.lblExit);
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1080, 34);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // lblMinimise
            // 
            this.lblMinimise.AppFont = Hermes.AppFont.HelveticaNeue_Medium;
            this.lblMinimise.AppFontHeight = 16F;
            this.lblMinimise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinimise.Location = new System.Drawing.Point(1023, 0);
            this.lblMinimise.Name = "lblMinimise";
            this.lblMinimise.Size = new System.Drawing.Size(18, 24);
            this.lblMinimise.TabIndex = 3;
            this.lblMinimise.Text = "_";
            this.lblMinimise.Click += new System.EventHandler(this.LblMinimise_Click);
            this.lblMinimise.MouseEnter += new System.EventHandler(this.Clickable_MouseEnter);
            this.lblMinimise.MouseLeave += new System.EventHandler(this.Clickable_MouseLeave);
            // 
            // lblExit
            // 
            this.lblExit.AppFont = Hermes.AppFont.Icons;
            this.lblExit.AppFontHeight = 10F;
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExit.Location = new System.Drawing.Point(1050, 8);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(16, 16);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.Clickable_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.Clickable_MouseLeave);
            // 
            // sideBarUserControls1
            // 
            this.sideBarUserControls1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.sideBarUserControls1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sideBarUserControls1.Location = new System.Drawing.Point(0, 0);
            this.sideBarUserControls1.Name = "sideBarUserControls1";
            this.sideBarUserControls1.Size = new System.Drawing.Size(116, 640);
            this.sideBarUserControls1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.sideBarUserControls1);
            this.Controls.Add(this.pnlEcran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::Hermes.Properties.Resources.AppIcon;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEcran;
        private UI.SidebarControl sideBarUserControls1;
        private System.Windows.Forms.Panel pnlTitleBar;
        private UI.AppFontLabel lblExit;
        private UI.AppFontLabel lblMinimise;
    }
}

