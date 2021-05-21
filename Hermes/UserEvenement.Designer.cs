namespace Hermes
{
    partial class UserEvenement
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIconeCreateurParticipant = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblIconeCreateurParticipant
            // 
            this.lblIconeCreateurParticipant.AppFont = Hermes.AppFont.Icons;
            this.lblIconeCreateurParticipant.AppFontHeight = 28F;
            this.lblIconeCreateurParticipant.AutoSize = true;
            this.lblIconeCreateurParticipant.Location = new System.Drawing.Point(11, 13);
            this.lblIconeCreateurParticipant.Name = "lblIconeCreateurParticipant";
            this.lblIconeCreateurParticipant.Size = new System.Drawing.Size(52, 48);
            this.lblIconeCreateurParticipant.TabIndex = 4;
            this.lblIconeCreateurParticipant.Text = "O";
            this.lblIconeCreateurParticipant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIconeCreateurParticipant.Click += new System.EventHandler(this.lblIconeCreateurParticipant_Click);
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel1.AppFontHeight = 13F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.Location = new System.Drawing.Point(83, 23);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(220, 26);
            this.appFontLabel1.TabIndex = 1;
            this.appFontLabel1.Text = "Alexander Yanovskyy";
            this.appFontLabel1.Click += new System.EventHandler(this.appFontLabel1_Click);
            // 
            // UserEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIconeCreateurParticipant);
            this.Controls.Add(this.appFontLabel1);
            this.Name = "UserEvenement";
            this.Size = new System.Drawing.Size(348, 75);
            this.Load += new System.EventHandler(this.UserEvenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel appFontLabel1;
        private UI.AppFontLabel lblIconeCreateurParticipant;
    }
}
