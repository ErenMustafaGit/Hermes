
namespace Hermes.UI
{
    partial class AppToast
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.textLabel = new Hermes.UI.AppFontLabel();
            this.iconLabel = new Hermes.UI.AppFontLabel();
            this.timerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(359, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.AppFont = Hermes.AppFont.HelveticaNeue;
            this.textLabel.AppFontHeight = 12F;
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Location = new System.Drawing.Point(50, 15);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(300, 24);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "appFontLabel1";
            // 
            // iconLabel
            // 
            this.iconLabel.AppFont = Hermes.AppFont.Icons;
            this.iconLabel.AppFontHeight = 16F;
            this.iconLabel.BackColor = System.Drawing.Color.Transparent;
            this.iconLabel.Location = new System.Drawing.Point(10, 0);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(42, 48);
            this.iconLabel.TabIndex = 2;
            this.iconLabel.Text = "?";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerPanel
            // 
            this.timerPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.timerPanel.ForeColor = System.Drawing.Color.Transparent;
            this.timerPanel.Location = new System.Drawing.Point(0, 44);
            this.timerPanel.Name = "timerPanel";
            this.timerPanel.Size = new System.Drawing.Size(400, 4);
            this.timerPanel.TabIndex = 3;
            this.timerPanel.Visible = false;
            // 
            // AppToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timerPanel);
            this.Controls.Add(this.iconLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.textLabel);
            this.Name = "AppToast";
            this.Size = new System.Drawing.Size(400, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private AppFontLabel textLabel;
        private System.Windows.Forms.Button closeButton;
        private AppFontLabel iconLabel;
        private System.Windows.Forms.Panel timerPanel;
    }
}
