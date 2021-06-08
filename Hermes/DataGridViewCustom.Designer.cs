namespace Hermes
{
    partial class DataGridViewCustom
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.appFontLabel3 = new Hermes.UI.AppFontLabel();
            this.appFontLabel2 = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.lblPersonnes = new Hermes.UI.AppFontLabel();
            this.pnlRows = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.pnlTitle.Controls.Add(this.appFontLabel3);
            this.pnlTitle.Controls.Add(this.appFontLabel2);
            this.pnlTitle.Controls.Add(this.appFontLabel1);
            this.pnlTitle.Controls.Add(this.lblPersonnes);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(830, 42);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTitle_Paint);
            // 
            // appFontLabel3
            // 
            this.appFontLabel3.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel3.AppFontHeight = 11F;
            this.appFontLabel3.AutoSize = true;
            this.appFontLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.appFontLabel3.Location = new System.Drawing.Point(686, 13);
            this.appFontLabel3.Name = "appFontLabel3";
            this.appFontLabel3.Size = new System.Drawing.Size(47, 17);
            this.appFontLabel3.TabIndex = 3;
            this.appFontLabel3.Text = "Solde";
            // 
            // appFontLabel2
            // 
            this.appFontLabel2.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel2.AppFontHeight = 11F;
            this.appFontLabel2.AutoSize = true;
            this.appFontLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.appFontLabel2.Location = new System.Drawing.Point(560, 13);
            this.appFontLabel2.Name = "appFontLabel2";
            this.appFontLabel2.Size = new System.Drawing.Size(49, 17);
            this.appFontLabel2.TabIndex = 2;
            this.appFontLabel2.Text = "Moins";
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel1.AppFontHeight = 11F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.appFontLabel1.Location = new System.Drawing.Point(436, 13);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(37, 17);
            this.appFontLabel1.TabIndex = 1;
            this.appFontLabel1.Text = "Plus";
            // 
            // lblPersonnes
            // 
            this.lblPersonnes.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblPersonnes.AppFontHeight = 11F;
            this.lblPersonnes.AutoSize = true;
            this.lblPersonnes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblPersonnes.Location = new System.Drawing.Point(49, 13);
            this.lblPersonnes.Name = "lblPersonnes";
            this.lblPersonnes.Size = new System.Drawing.Size(80, 17);
            this.lblPersonnes.TabIndex = 0;
            this.lblPersonnes.Text = "Personnes";
            // 
            // pnlRows
            // 
            this.pnlRows.Location = new System.Drawing.Point(0, 40);
            this.pnlRows.Name = "pnlRows";
            this.pnlRows.Size = new System.Drawing.Size(830, 157);
            this.pnlRows.TabIndex = 1;
            this.pnlRows.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlRows_Paint);
            // 
            // DataGridViewCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRows);
            this.Controls.Add(this.pnlTitle);
            this.Name = "DataGridViewCustom";
            this.Size = new System.Drawing.Size(830, 197);
            this.Load += new System.EventHandler(this.DataGridViewCustom_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private UI.AppFontLabel appFontLabel3;
        private UI.AppFontLabel appFontLabel2;
        private UI.AppFontLabel appFontLabel1;
        private UI.AppFontLabel lblPersonnes;
        private System.Windows.Forms.Panel pnlRows;
    }
}
