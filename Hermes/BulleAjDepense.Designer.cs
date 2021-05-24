namespace Hermes
{
    partial class BulleAjDepense
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.cboEventCreator = new System.Windows.Forms.ComboBox();
            this.txtNomEvenement = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.appFontLabel2 = new Hermes.UI.AppFontLabel();
            this.cboCreateur = new Hermes.UI.AppFontLabel();
            this.lblDebutEvenement = new Hermes.UI.AppFontLabel();
            this.lblNomEvenement = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.cboEvenement = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.Location = new System.Drawing.Point(384, 315);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(96, 30);
            this.btnAnnuler.TabIndex = 31;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnContinuer
            // 
            this.btnContinuer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinuer.Location = new System.Drawing.Point(495, 315);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(96, 30);
            this.btnContinuer.TabIndex = 32;
            this.btnContinuer.Text = "Continuer";
            this.btnContinuer.UseVisualStyleBackColor = false;
            this.btnContinuer.Click += new System.EventHandler(this.btnContinuer_Click);
            // 
            // cboEventCreator
            // 
            this.cboEventCreator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboEventCreator.FormattingEnabled = true;
            this.cboEventCreator.Location = new System.Drawing.Point(120, 242);
            this.cboEventCreator.Name = "cboEventCreator";
            this.cboEventCreator.Size = new System.Drawing.Size(230, 28);
            this.cboEventCreator.TabIndex = 28;
            // 
            // txtNomEvenement
            // 
            this.txtNomEvenement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNomEvenement.Location = new System.Drawing.Point(120, 159);
            this.txtNomEvenement.Name = "txtNomEvenement";
            this.txtNomEvenement.Size = new System.Drawing.Size(230, 27);
            this.txtNomEvenement.TabIndex = 23;
            // 
            // numAmount
            // 
            this.numAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numAmount.Location = new System.Drawing.Point(384, 159);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(195, 27);
            this.numAmount.TabIndex = 33;
            // 
            // appFontLabel2
            // 
            this.appFontLabel2.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.appFontLabel2.AppFontHeight = 24F;
            this.appFontLabel2.AutoSize = true;
            this.appFontLabel2.Location = new System.Drawing.Point(113, 60);
            this.appFontLabel2.Name = "appFontLabel2";
            this.appFontLabel2.Size = new System.Drawing.Size(458, 40);
            this.appFontLabel2.TabIndex = 30;
            this.appFontLabel2.Text = "Ajout d\'une nouvelle dépense";
            // 
            // cboCreateur
            // 
            this.cboCreateur.AppFont = Hermes.AppFont.HelveticaNeue;
            this.cboCreateur.AppFontHeight = 10F;
            this.cboCreateur.AutoSize = true;
            this.cboCreateur.Location = new System.Drawing.Point(117, 214);
            this.cboCreateur.Name = "cboCreateur";
            this.cboCreateur.Size = new System.Drawing.Size(231, 16);
            this.cboCreateur.TabIndex = 29;
            this.cboCreateur.Text = "Nom du createur de la dépense ? *";
            // 
            // lblDebutEvenement
            // 
            this.lblDebutEvenement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDebutEvenement.AppFontHeight = 10F;
            this.lblDebutEvenement.AutoSize = true;
            this.lblDebutEvenement.Location = new System.Drawing.Point(381, 130);
            this.lblDebutEvenement.Name = "lblDebutEvenement";
            this.lblDebutEvenement.Size = new System.Drawing.Size(81, 16);
            this.lblDebutEvenement.TabIndex = 25;
            this.lblDebutEvenement.Text = "Montant ? *";
            // 
            // lblNomEvenement
            // 
            this.lblNomEvenement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblNomEvenement.AppFontHeight = 10F;
            this.lblNomEvenement.AutoSize = true;
            this.lblNomEvenement.Location = new System.Drawing.Point(117, 130);
            this.lblNomEvenement.Name = "lblNomEvenement";
            this.lblNomEvenement.Size = new System.Drawing.Size(153, 16);
            this.lblNomEvenement.TabIndex = 22;
            this.lblNomEvenement.Text = "Nom de la dépense ? *";
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel1.AppFontHeight = 10F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.Location = new System.Drawing.Point(381, 214);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(168, 16);
            this.appFontLabel1.TabIndex = 35;
            this.appFontLabel1.Text = "Dans quel évènement ? *";
            // 
            // cboEvenement
            // 
            this.cboEvenement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboEvenement.FormattingEnabled = true;
            this.cboEvenement.Location = new System.Drawing.Point(384, 242);
            this.cboEvenement.Name = "cboEvenement";
            this.cboEvenement.Size = new System.Drawing.Size(195, 28);
            this.cboEvenement.TabIndex = 34;
            // 
            // BulleAjDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appFontLabel1);
            this.Controls.Add(this.cboEvenement);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.appFontLabel2);
            this.Controls.Add(this.cboCreateur);
            this.Controls.Add(this.cboEventCreator);
            this.Controls.Add(this.lblDebutEvenement);
            this.Controls.Add(this.txtNomEvenement);
            this.Controls.Add(this.lblNomEvenement);
            this.Name = "BulleAjDepense";
            this.Size = new System.Drawing.Size(705, 405);
            this.Load += new System.EventHandler(this.BulleAjDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnContinuer;
        private UI.AppFontLabel appFontLabel2;
        private UI.AppFontLabel cboCreateur;
        private System.Windows.Forms.ComboBox cboEventCreator;
        private UI.AppFontLabel lblDebutEvenement;
        private System.Windows.Forms.TextBox txtNomEvenement;
        private UI.AppFontLabel lblNomEvenement;
        private System.Windows.Forms.NumericUpDown numAmount;
        private UI.AppFontLabel appFontLabel1;
        private System.Windows.Forms.ComboBox cboEvenement;
    }
}
