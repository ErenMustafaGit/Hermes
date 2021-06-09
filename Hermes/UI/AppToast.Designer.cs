
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
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(349, 7);
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
            this.textLabel.Location = new System.Drawing.Point(9, 13);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(320, 24);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "appFontLabel1";
            // 
            // AppToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.textLabel);
            this.Name = "AppToast";
            this.Size = new System.Drawing.Size(390, 47);
            this.ResumeLayout(false);

        }

        #endregion

        private AppFontLabel textLabel;
        private System.Windows.Forms.Button closeButton;
    }
}
