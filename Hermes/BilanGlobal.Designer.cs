namespace Hermes
{
    partial class BilanGlobal
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
            this.appFontLabel2 = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // appFontLabel2
            // 
            this.appFontLabel2.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.appFontLabel2.AppFontHeight = 40F;
            this.appFontLabel2.AutoSize = true;
            this.appFontLabel2.Location = new System.Drawing.Point(118, 99);
            this.appFontLabel2.Name = "appFontLabel2";
            this.appFontLabel2.Size = new System.Drawing.Size(325, 67);
            this.appFontLabel2.TabIndex = 2;
            this.appFontLabel2.Text = "Bilan global";
            // 
            // BilanGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appFontLabel2);
            this.Name = "BilanGlobal";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.BilanGlobal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel appFontLabel2;
    }
}
