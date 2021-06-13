namespace Hermes
{
    partial class BulleAjEvenement2
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
            this.pnlParticipants = new System.Windows.Forms.Panel();
            this.chkEveryOne = new System.Windows.Forms.CheckBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblDescription = new Hermes.UI.AppFontLabel();
            this.lblParticipants = new Hermes.UI.AppFontLabel();
            this.pnlParticipants.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlParticipants
            // 
            this.pnlParticipants.Controls.Add(this.chkEveryOne);
            this.pnlParticipants.Location = new System.Drawing.Point(68, 92);
            this.pnlParticipants.Name = "pnlParticipants";
            this.pnlParticipants.Size = new System.Drawing.Size(267, 272);
            this.pnlParticipants.TabIndex = 1;
            // 
            // chkEveryOne
            // 
            this.chkEveryOne.AutoSize = true;
            this.chkEveryOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEveryOne.Location = new System.Drawing.Point(15, 12);
            this.chkEveryOne.Name = "chkEveryOne";
            this.chkEveryOne.Size = new System.Drawing.Size(135, 22);
            this.chkEveryOne.TabIndex = 0;
            this.chkEveryOne.Text = "Tout le monde";
            this.chkEveryOne.UseVisualStyleBackColor = true;
            this.chkEveryOne.CheckedChanged += new System.EventHandler(this.ChkEveryOne_CheckedChanged);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(364, 92);
            this.rtxtDescription.MaxLength = 200;
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(258, 226);
            this.rtxtDescription.TabIndex = 2;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtDescription_KeyPress);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.Location = new System.Drawing.Point(364, 334);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(123, 30);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.ForeColor = System.Drawing.SystemColors.Control;
            this.btnValider.Location = new System.Drawing.Point(493, 334);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(129, 30);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDescription.AppFontHeight = 11F;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(361, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 18);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblParticipants
            // 
            this.lblParticipants.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblParticipants.AppFontHeight = 20F;
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Location = new System.Drawing.Point(39, 43);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(167, 34);
            this.lblParticipants.TabIndex = 0;
            this.lblParticipants.Text = "Participants";
            // 
            // BulleAjEvenement2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.pnlParticipants);
            this.Controls.Add(this.lblParticipants);
            this.Name = "BulleAjEvenement2";
            this.Size = new System.Drawing.Size(705, 405);
            this.Load += new System.EventHandler(this.BulleAjEvenement2_Load);
            this.pnlParticipants.ResumeLayout(false);
            this.pnlParticipants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblParticipants;
        private System.Windows.Forms.Panel pnlParticipants;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private UI.AppFontLabel lblDescription;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.CheckBox chkEveryOne;
    }
}
