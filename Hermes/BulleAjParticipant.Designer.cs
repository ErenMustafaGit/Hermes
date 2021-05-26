namespace Hermes
{
    partial class BulleAjParticipant
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblEmail = new Hermes.UI.AppFontLabel();
            this.lblNumero = new Hermes.UI.AppFontLabel();
            this.lblPrenom = new Hermes.UI.AppFontLabel();
            this.lblAjoutDunParticipant = new Hermes.UI.AppFontLabel();
            this.lblNom = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(381, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.ForeColor = System.Drawing.SystemColors.Control;
            this.btnValider.Location = new System.Drawing.Point(492, 330);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(96, 30);
            this.btnValider.TabIndex = 32;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNom.Location = new System.Drawing.Point(132, 174);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(201, 27);
            this.txtNom.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox1.Location = new System.Drawing.Point(132, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 27);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox2.Location = new System.Drawing.Point(381, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 27);
            this.textBox2.TabIndex = 36;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox3.Location = new System.Drawing.Point(381, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 27);
            this.textBox3.TabIndex = 38;
            // 
            // lblEmail
            // 
            this.lblEmail.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblEmail.AppFontHeight = 10F;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(378, 228);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(115, 16);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Adresse e-mail ?";
            // 
            // lblNumero
            // 
            this.lblNumero.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblNumero.AppFontHeight = 10F;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(378, 145);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(167, 16);
            this.lblNumero.TabIndex = 35;
            this.lblNumero.Text = "Numéro de téléphone ? *";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblPrenom.AppFontHeight = 10F;
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(129, 228);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(170, 16);
            this.lblPrenom.TabIndex = 33;
            this.lblPrenom.Text = "Prénom du participant ? *";
            // 
            // lblAjoutDunParticipant
            // 
            this.lblAjoutDunParticipant.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblAjoutDunParticipant.AppFontHeight = 24F;
            this.lblAjoutDunParticipant.AutoSize = true;
            this.lblAjoutDunParticipant.Location = new System.Drawing.Point(175, 69);
            this.lblAjoutDunParticipant.Name = "lblAjoutDunParticipant";
            this.lblAjoutDunParticipant.Size = new System.Drawing.Size(339, 40);
            this.lblAjoutDunParticipant.TabIndex = 30;
            this.lblAjoutDunParticipant.Text = "Ajout d\'un participant";
            // 
            // lblNom
            // 
            this.lblNom.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblNom.AppFontHeight = 10F;
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(129, 145);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(150, 16);
            this.lblNom.TabIndex = 22;
            this.lblNom.Text = "Nom du participant ? *";
            // 
            // BulleAjParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblAjoutDunParticipant);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "BulleAjParticipant";
            this.Size = new System.Drawing.Size(705, 405);
            this.Load += new System.EventHandler(this.BulleAjParticipant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValider;
        private UI.AppFontLabel lblAjoutDunParticipant;
        private System.Windows.Forms.TextBox txtNom;
        private UI.AppFontLabel lblNom;
        private System.Windows.Forms.TextBox textBox1;
        private UI.AppFontLabel lblPrenom;
        private System.Windows.Forms.TextBox textBox2;
        private UI.AppFontLabel lblNumero;
        private System.Windows.Forms.TextBox textBox3;
        private UI.AppFontLabel lblEmail;
    }
}
