namespace Hermes
{
    partial class UserBilanCasParCas
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
            this.lblName = new Hermes.UI.AppFontLabel();
            this.pnlDues = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblName.AppFontHeight = 20F;
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblName.Location = new System.Drawing.Point(28, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(276, 34);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Murielle Torregrossa";
            // 
            // pnlDues
            // 
            this.pnlDues.Location = new System.Drawing.Point(34, 90);
            this.pnlDues.Name = "pnlDues";
            this.pnlDues.Size = new System.Drawing.Size(353, 129);
            this.pnlDues.TabIndex = 2;
            // 
            // UserBilanCasParCas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnlDues);
            this.Controls.Add(this.lblName);
            this.Name = "UserBilanCasParCas";
            this.Size = new System.Drawing.Size(387, 233);
            this.Load += new System.EventHandler(this.UserBilanCasParCas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblName;
        private System.Windows.Forms.Panel pnlDues;
    }
}
