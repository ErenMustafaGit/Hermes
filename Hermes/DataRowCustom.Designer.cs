namespace Hermes
{
    partial class DataRowCustom
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
            this.lblSolde = new Hermes.UI.AppFontLabel();
            this.lblMoins = new Hermes.UI.AppFontLabel();
            this.lblPlus = new Hermes.UI.AppFontLabel();
            this.lblPersonnes = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblSolde
            // 
            this.lblSolde.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblSolde.AppFontHeight = 11F;
            this.lblSolde.AutoSize = true;
            this.lblSolde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.lblSolde.Location = new System.Drawing.Point(686, 13);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(49, 19);
            this.lblSolde.TabIndex = 7;
            this.lblSolde.Text = "Solde";
            this.lblSolde.Click += new System.EventHandler(this.DataRowCustom_Click);
            this.lblSolde.MouseEnter += new System.EventHandler(this.DataRowCustom_Enter);
            this.lblSolde.MouseLeave += new System.EventHandler(this.DataRowCustom_Leave);
            // 
            // lblMoins
            // 
            this.lblMoins.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblMoins.AppFontHeight = 11F;
            this.lblMoins.AutoSize = true;
            this.lblMoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.lblMoins.Location = new System.Drawing.Point(560, 13);
            this.lblMoins.Name = "lblMoins";
            this.lblMoins.Size = new System.Drawing.Size(52, 19);
            this.lblMoins.TabIndex = 6;
            this.lblMoins.Text = "Moins";
            this.lblMoins.Click += new System.EventHandler(this.DataRowCustom_Click);
            this.lblMoins.MouseEnter += new System.EventHandler(this.DataRowCustom_Enter);
            this.lblMoins.MouseLeave += new System.EventHandler(this.DataRowCustom_Leave);
            // 
            // lblPlus
            // 
            this.lblPlus.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblPlus.AppFontHeight = 11F;
            this.lblPlus.AutoSize = true;
            this.lblPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.lblPlus.Location = new System.Drawing.Point(436, 13);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(40, 19);
            this.lblPlus.TabIndex = 5;
            this.lblPlus.Text = "Plus";
            this.lblPlus.Click += new System.EventHandler(this.DataRowCustom_Click);
            this.lblPlus.MouseEnter += new System.EventHandler(this.DataRowCustom_Enter);
            this.lblPlus.MouseLeave += new System.EventHandler(this.DataRowCustom_Leave);
            // 
            // lblPersonnes
            // 
            this.lblPersonnes.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblPersonnes.AppFontHeight = 11F;
            this.lblPersonnes.AutoSize = true;
            this.lblPersonnes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.lblPersonnes.Location = new System.Drawing.Point(49, 13);
            this.lblPersonnes.Name = "lblPersonnes";
            this.lblPersonnes.Size = new System.Drawing.Size(85, 19);
            this.lblPersonnes.TabIndex = 4;
            this.lblPersonnes.Text = "Participant";
            this.lblPersonnes.Click += new System.EventHandler(this.DataRowCustom_Click);
            this.lblPersonnes.MouseEnter += new System.EventHandler(this.DataRowCustom_Enter);
            this.lblPersonnes.MouseLeave += new System.EventHandler(this.DataRowCustom_Leave);
            // 
            // DataRowCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.lblMoins);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblPersonnes);
            this.Name = "DataRowCustom";
            this.Size = new System.Drawing.Size(830, 42);
            this.Load += new System.EventHandler(this.DataRowCustom_Load);
            this.Click += new System.EventHandler(this.DataRowCustom_Click);
            this.MouseEnter += new System.EventHandler(this.DataRowCustom_Enter);
            this.MouseLeave += new System.EventHandler(this.DataRowCustom_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblSolde;
        private UI.AppFontLabel lblMoins;
        private UI.AppFontLabel lblPlus;
        private UI.AppFontLabel lblPersonnes;
    }
}
