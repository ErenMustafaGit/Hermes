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
            this.lblTxtParticipant = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblIconeCreateurParticipant
            // 
            this.lblIconeCreateurParticipant.AppFont = Hermes.AppFont.Icons;
            this.lblIconeCreateurParticipant.AppFontHeight = 28F;
            this.lblIconeCreateurParticipant.AutoSize = true;
            this.lblIconeCreateurParticipant.Location = new System.Drawing.Point(11, 13);
            this.lblIconeCreateurParticipant.Name = "lblIconeCreateurParticipant";
            this.lblIconeCreateurParticipant.Size = new System.Drawing.Size(42, 38);
            this.lblIconeCreateurParticipant.TabIndex = 4;
            this.lblIconeCreateurParticipant.Text = "O";
            this.lblIconeCreateurParticipant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIconeCreateurParticipant.Click += new System.EventHandler(this.lblIconeCreateurParticipant_Click);
            // 
            // lblTxtParticipant
            // 
            this.lblTxtParticipant.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblTxtParticipant.AppFontHeight = 13F;
            this.lblTxtParticipant.AutoSize = true;
            this.lblTxtParticipant.Location = new System.Drawing.Point(83, 23);
            this.lblTxtParticipant.Name = "lblTxtParticipant";
            this.lblTxtParticipant.Size = new System.Drawing.Size(182, 21);
            this.lblTxtParticipant.TabIndex = 1;
            this.lblTxtParticipant.Text = "Alexander Yanovskyy";
            this.lblTxtParticipant.Click += new System.EventHandler(this.appFontLabel1_Click);
            // 
            // UserEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIconeCreateurParticipant);
            this.Controls.Add(this.lblTxtParticipant);
            this.Name = "UserEvenement";
            this.Size = new System.Drawing.Size(330, 68);
            this.Load += new System.EventHandler(this.UserEvenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblTxtParticipant;
        private UI.AppFontLabel lblIconeCreateurParticipant;
    }
}
