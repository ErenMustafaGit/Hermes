namespace Hermes
{
    partial class AjoutEvenement
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
            this.lblAdd = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AppFont = Hermes.AppFont.Icons;
            this.lblAdd.AppFontHeight = 40F;
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(129, 87);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(58, 55);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "O";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AjoutEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.lblAdd);
            this.Name = "AjoutEvenement";
            this.Size = new System.Drawing.Size(334, 233);
            this.Load += new System.EventHandler(this.AjoutEvenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblAdd;
    }
}
