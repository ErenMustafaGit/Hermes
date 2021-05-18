
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEcran = new System.Windows.Forms.Panel();
            this.sideBarUserControls1 = new Hermes.SideBarUserControls();
            this.pnlEcran.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(928, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // pnlEcran
            // 
            this.pnlEcran.Controls.Add(this.label1);
            this.pnlEcran.Location = new System.Drawing.Point(113, 0);
            this.pnlEcran.Name = "pnlEcran";
            this.pnlEcran.Size = new System.Drawing.Size(967, 640);
            this.pnlEcran.TabIndex = 3;
            // 
            // sideBarUserControls1
            // 
            this.sideBarUserControls1.BackColor = System.Drawing.Color.White;
            this.sideBarUserControls1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sideBarUserControls1.Location = new System.Drawing.Point(-1, 0);
            this.sideBarUserControls1.Name = "sideBarUserControls1";
            this.sideBarUserControls1.Size = new System.Drawing.Size(116, 640);
            this.sideBarUserControls1.TabIndex = 4;
            this.sideBarUserControls1.Load += new System.EventHandler(this.SideBarUserControls1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.sideBarUserControls1);
            this.Controls.Add(this.pnlEcran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.pnlEcran.ResumeLayout(false);
            this.pnlEcran.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEcran;
        private SideBarUserControls sideBarUserControls1;
    }
}

