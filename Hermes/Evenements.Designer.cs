namespace Hermes
{
    partial class Evenements
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
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.pnlAddEvent = new System.Windows.Forms.Panel();
            this.pnlScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScroll
            // 
            this.pnlScroll.Controls.Add(this.pnlAddEvent);
            this.pnlScroll.Location = new System.Drawing.Point(39, 76);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(909, 494);
            this.pnlScroll.TabIndex = 2;
            // 
            // pnlAddEvent
            // 
            this.pnlAddEvent.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddEvent.Location = new System.Drawing.Point(72, 66);
            this.pnlAddEvent.Name = "pnlAddEvent";
            this.pnlAddEvent.Size = new System.Drawing.Size(705, 405);
            this.pnlAddEvent.TabIndex = 0;
            this.pnlAddEvent.Visible = false;
            // 
            // Evenements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlScroll);
            this.Name = "Evenements";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.Evenements_Load);
            this.pnlScroll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.Panel pnlAddEvent;
    }
}
