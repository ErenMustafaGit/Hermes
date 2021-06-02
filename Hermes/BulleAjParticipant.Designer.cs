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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.nudNbPart = new System.Windows.Forms.NumericUpDown();
            this.lblEmail = new Hermes.UI.AppFontLabel();
            this.lblNumero = new Hermes.UI.AppFontLabel();
            this.lblNbPart = new Hermes.UI.AppFontLabel();
            this.lblPrenom = new Hermes.UI.AppFontLabel();
            this.lblAjoutDunParticipant = new Hermes.UI.AppFontLabel();
            this.lblNom = new Hermes.UI.AppFontLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbPart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(381, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 41;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.ForeColor = System.Drawing.SystemColors.Control;
            this.btnValider.Location = new System.Drawing.Point(492, 351);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(96, 30);
            this.btnValider.TabIndex = 40;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtLastName.Location = new System.Drawing.Point(132, 147);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(201, 27);
            this.txtLastName.TabIndex = 23;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtFirstName.Location = new System.Drawing.Point(132, 230);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(201, 27);
            this.txtFirstName.TabIndex = 31;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(381, 147);
            this.txtPhoneNumber.MaxLength = 30;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(201, 27);
            this.txtPhoneNumber.TabIndex = 36;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.TxtPhoneNumber_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtMail.Location = new System.Drawing.Point(381, 230);
            this.txtMail.MaxLength = 30;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(201, 27);
            this.txtMail.TabIndex = 38;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // nudNbPart
            // 
            this.nudNbPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nudNbPart.Location = new System.Drawing.Point(132, 313);
            this.nudNbPart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNbPart.Name = "nudNbPart";
            this.nudNbPart.Size = new System.Drawing.Size(201, 27);
            this.nudNbPart.TabIndex = 33;
            this.nudNbPart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNbPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudNbPart_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblEmail.AppFontHeight = 10F;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(378, 201);
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
            this.lblNumero.Location = new System.Drawing.Point(378, 118);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(167, 16);
            this.lblNumero.TabIndex = 35;
            this.lblNumero.Text = "Numéro de téléphone ? *";
            // 
            // lblNbPart
            // 
            this.lblNbPart.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblNbPart.AppFontHeight = 10F;
            this.lblNbPart.AutoSize = true;
            this.lblNbPart.Location = new System.Drawing.Point(129, 284);
            this.lblNbPart.Name = "lblNbPart";
            this.lblNbPart.Size = new System.Drawing.Size(129, 16);
            this.lblNbPart.TabIndex = 33;
            this.lblNbPart.Text = "Nombre de part ? *";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblPrenom.AppFontHeight = 10F;
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(129, 201);
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
            this.lblAjoutDunParticipant.Location = new System.Drawing.Point(175, 51);
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
            this.lblNom.Location = new System.Drawing.Point(129, 118);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(150, 16);
            this.lblNom.TabIndex = 22;
            this.lblNom.Text = "Nom du participant ? *";
            // 
            // BulleAjParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudNbPart);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblNbPart);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblAjoutDunParticipant);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblNom);
            this.Name = "BulleAjParticipant";
            this.Size = new System.Drawing.Size(705, 405);
            this.Load += new System.EventHandler(this.BulleAjParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNbPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValider;
        private UI.AppFontLabel lblAjoutDunParticipant;
        private System.Windows.Forms.TextBox txtLastName;
        private UI.AppFontLabel lblNom;
        private System.Windows.Forms.TextBox txtFirstName;
        private UI.AppFontLabel lblPrenom;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private UI.AppFontLabel lblNumero;
        private System.Windows.Forms.TextBox txtMail;
        private UI.AppFontLabel lblEmail;
        private System.Windows.Forms.NumericUpDown nudNbPart;
        private UI.AppFontLabel lblNbPart;
    }
}
