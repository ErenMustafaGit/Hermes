namespace Hermes
{
    partial class AjoutRapideBouton
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
            this.lblAjoutRapide = new System.Windows.Forms.Label();
            this.cboEvenements = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.lblQuelEvenement = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblAjoutRapide
            // 
            this.lblAjoutRapide.AutoSize = true;
            this.lblAjoutRapide.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.lblAjoutRapide.Location = new System.Drawing.Point(73, 87);
            this.lblAjoutRapide.Name = "lblAjoutRapide";
            this.lblAjoutRapide.Size = new System.Drawing.Size(0, 40);
            this.lblAjoutRapide.TabIndex = 0;
            // 
            // cboEvenements
            // 
            this.cboEvenements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Location = new System.Drawing.Point(80, 239);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(245, 24);
            this.cboEvenements.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAjouter.Location = new System.Drawing.Point(155, 294);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(105, 30);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.appFontLabel1.AppFontHeight = 27F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.Location = new System.Drawing.Point(72, 98);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(266, 90);
            this.appFontLabel1.TabIndex = 5;
            this.appFontLabel1.Text = "Ajout rapide\r\nd\'une dépense\r\n";
            this.appFontLabel1.Click += new System.EventHandler(this.appFontLabel1_Click);
            // 
            // lblQuelEvenement
            // 
            this.lblQuelEvenement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblQuelEvenement.AppFontHeight = 11F;
            this.lblQuelEvenement.AutoSize = true;
            this.lblQuelEvenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblQuelEvenement.Location = new System.Drawing.Point(77, 214);
            this.lblQuelEvenement.Name = "lblQuelEvenement";
            this.lblQuelEvenement.Size = new System.Drawing.Size(173, 17);
            this.lblQuelEvenement.TabIndex = 4;
            this.lblQuelEvenement.Text = "Dans quel évènements ?";
            // 
            // AjoutRapideBouton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appFontLabel1);
            this.Controls.Add(this.lblQuelEvenement);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cboEvenements);
            this.Controls.Add(this.lblAjoutRapide);
            this.Name = "AjoutRapideBouton";
            this.Size = new System.Drawing.Size(508, 491);
            this.Load += new System.EventHandler(this.AjoutRapideBouton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjoutRapide;
        private System.Windows.Forms.ComboBox cboEvenements;
        private System.Windows.Forms.Button btnAjouter;
        private UI.AppFontLabel lblQuelEvenement;
        private UI.AppFontLabel appFontLabel1;
    }
}
