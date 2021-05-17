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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEvenements = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAjoutRapide
            // 
            this.lblAjoutRapide.AutoSize = true;
            this.lblAjoutRapide.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.lblAjoutRapide.Location = new System.Drawing.Point(73, 87);
            this.lblAjoutRapide.Name = "lblAjoutRapide";
            this.lblAjoutRapide.Size = new System.Drawing.Size(252, 80);
            this.lblAjoutRapide.TabIndex = 0;
            this.lblAjoutRapide.Text = "Ajout rapide\r\nd\'une dépense\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(77, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dans quel évènements ?";
            // 
            // cbbEvenements
            // 
            this.cbbEvenements.FormattingEnabled = true;
            this.cbbEvenements.Location = new System.Drawing.Point(80, 247);
            this.cbbEvenements.Name = "cbbEvenements";
            this.cbbEvenements.Size = new System.Drawing.Size(245, 21);
            this.cbbEvenements.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAjouter.Location = new System.Drawing.Point(155, 298);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(105, 30);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // AjoutRapideBouton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbbEvenements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAjoutRapide);
            this.Name = "AjoutRapideBouton";
            this.Size = new System.Drawing.Size(508, 491);
            this.Load += new System.EventHandler(this.AjoutRapideBouton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjoutRapide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEvenements;
        private System.Windows.Forms.Button btnAjouter;
    }
}
