namespace Hermes
{
    partial class UserParticipants
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
            this.lblIconeMail = new Hermes.UI.AppFontLabel();
            this.lblEmail = new Hermes.UI.AppFontLabel();
            this.lblIconeTel = new Hermes.UI.AppFontLabel();
            this.lblTel = new Hermes.UI.AppFontLabel();
            this.lblPrenomNom = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblIconeMail
            // 
            this.lblIconeMail.AppFont = Hermes.AppFont.Icons;
            this.lblIconeMail.AppFontHeight = 12F;
            this.lblIconeMail.AutoSize = true;
            this.lblIconeMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconeMail.Location = new System.Drawing.Point(44, 124);
            this.lblIconeMail.Name = "lblIconeMail";
            this.lblIconeMail.Size = new System.Drawing.Size(20, 19);
            this.lblIconeMail.TabIndex = 6;
            this.lblIconeMail.Text = "O";
            // 
            // lblEmail
            // 
            this.lblEmail.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblEmail.AppFontHeight = 10F;
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblEmail.Location = new System.Drawing.Point(81, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 21);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "0612362516";
            // 
            // lblIconeTel
            // 
            this.lblIconeTel.AppFont = Hermes.AppFont.Icons;
            this.lblIconeTel.AppFontHeight = 12F;
            this.lblIconeTel.AutoSize = true;
            this.lblIconeTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconeTel.Location = new System.Drawing.Point(44, 93);
            this.lblIconeTel.Name = "lblIconeTel";
            this.lblIconeTel.Size = new System.Drawing.Size(20, 19);
            this.lblIconeTel.TabIndex = 4;
            this.lblIconeTel.Text = "O";
            // 
            // lblTel
            // 
            this.lblTel.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblTel.AppFontHeight = 10F;
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblTel.Location = new System.Drawing.Point(81, 93);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(110, 21);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "0612362516";
            // 
            // lblPrenomNom
            // 
            this.lblPrenomNom.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblPrenomNom.AppFontHeight = 18F;
            this.lblPrenomNom.AutoSize = true;
            this.lblPrenomNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblPrenomNom.Location = new System.Drawing.Point(42, 33);
            this.lblPrenomNom.Name = "lblPrenomNom";
            this.lblPrenomNom.Size = new System.Drawing.Size(203, 34);
            this.lblPrenomNom.TabIndex = 2;
            this.lblPrenomNom.Text = "appFontLabel2";
            // 
            // UserParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.lblIconeMail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblIconeTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblPrenomNom);
            this.Name = "UserParticipants";
            this.Size = new System.Drawing.Size(378, 177);
            this.Load += new System.EventHandler(this.UserParticipants_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblPrenomNom;
        private UI.AppFontLabel lblTel;
        private UI.AppFontLabel lblIconeTel;
        private UI.AppFontLabel lblIconeMail;
        private UI.AppFontLabel lblEmail;
    }
}
