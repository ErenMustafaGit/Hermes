namespace Hermes
{
    partial class BulleAjEvenement
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
            this.txtNomEvenement = new System.Windows.Forms.TextBox();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.cboEventCreator = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.appFontLabel2 = new Hermes.UI.AppFontLabel();
            this.cboCreateur = new Hermes.UI.AppFontLabel();
            this.lblFinEvenement = new Hermes.UI.AppFontLabel();
            this.lblDebutEvenement = new Hermes.UI.AppFontLabel();
            this.lblNomEvenement = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // txtNomEvenement
            // 
            this.txtNomEvenement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNomEvenement.Location = new System.Drawing.Point(112, 170);
            this.txtNomEvenement.MaxLength = 30;
            this.txtNomEvenement.Name = "txtNomEvenement";
            this.txtNomEvenement.Size = new System.Drawing.Size(230, 27);
            this.txtNomEvenement.TabIndex = 11;
            this.txtNomEvenement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEvenement_KeyPress);
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.dtpDateDebut.Location = new System.Drawing.Point(376, 170);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(219, 25);
            this.dtpDateDebut.TabIndex = 13;
            this.dtpDateDebut.Value = new System.DateTime(2021, 5, 18, 18, 23, 0, 0);
            this.dtpDateDebut.ValueChanged += new System.EventHandler(this.DtpDateDebut_ValueChanged);
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.dtpDateFin.Location = new System.Drawing.Point(376, 253);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(219, 25);
            this.dtpDateFin.TabIndex = 15;
            this.dtpDateFin.Value = new System.DateTime(2021, 5, 18, 18, 23, 0, 0);
            this.dtpDateFin.ValueChanged += new System.EventHandler(this.DtpDateFin_ValueChanged);
            // 
            // cboEventCreator
            // 
            this.cboEventCreator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboEventCreator.FormattingEnabled = true;
            this.cboEventCreator.Location = new System.Drawing.Point(112, 253);
            this.cboEventCreator.Name = "cboEventCreator";
            this.cboEventCreator.Size = new System.Drawing.Size(230, 28);
            this.cboEventCreator.TabIndex = 17;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.Location = new System.Drawing.Point(376, 323);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(101, 30);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnContinuer
            // 
            this.btnContinuer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinuer.Location = new System.Drawing.Point(495, 323);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(100, 30);
            this.btnContinuer.TabIndex = 21;
            this.btnContinuer.Text = "Continuer";
            this.btnContinuer.UseVisualStyleBackColor = false;
            this.btnContinuer.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // appFontLabel2
            // 
            this.appFontLabel2.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.appFontLabel2.AppFontHeight = 24F;
            this.appFontLabel2.AutoSize = true;
            this.appFontLabel2.Location = new System.Drawing.Point(105, 68);
            this.appFontLabel2.Name = "appFontLabel2";
            this.appFontLabel2.Size = new System.Drawing.Size(452, 40);
            this.appFontLabel2.TabIndex = 19;
            this.appFontLabel2.Text = "Ajout d\'un nouvel évènement\r\n";
            // 
            // cboCreateur
            // 
            this.cboCreateur.AppFont = Hermes.AppFont.HelveticaNeue;
            this.cboCreateur.AppFontHeight = 10F;
            this.cboCreateur.AutoSize = true;
            this.cboCreateur.Location = new System.Drawing.Point(109, 225);
            this.cboCreateur.Name = "cboCreateur";
            this.cboCreateur.Size = new System.Drawing.Size(169, 16);
            this.cboCreateur.TabIndex = 18;
            this.cboCreateur.Text = "Créateur de l\'évènement";
            // 
            // lblFinEvenement
            // 
            this.lblFinEvenement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblFinEvenement.AppFontHeight = 10F;
            this.lblFinEvenement.AutoSize = true;
            this.lblFinEvenement.Location = new System.Drawing.Point(373, 224);
            this.lblFinEvenement.Name = "lblFinEvenement";
            this.lblFinEvenement.Size = new System.Drawing.Size(131, 16);
            this.lblFinEvenement.TabIndex = 16;
            this.lblFinEvenement.Text = "Fin de l\'évènement";
            // 
            // lblDebutEvenement
            // 
            this.lblDebutEvenement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDebutEvenement.AppFontHeight = 10F;
            this.lblDebutEvenement.AutoSize = true;
            this.lblDebutEvenement.Location = new System.Drawing.Point(373, 141);
            this.lblDebutEvenement.Name = "lblDebutEvenement";
            this.lblDebutEvenement.Size = new System.Drawing.Size(152, 16);
            this.lblDebutEvenement.TabIndex = 14;
            this.lblDebutEvenement.Text = "Début de l\'évènement";
            // 
            // lblNomEvenement
            // 
            this.lblNomEvenement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblNomEvenement.AppFontHeight = 10F;
            this.lblNomEvenement.AutoSize = true;
            this.lblNomEvenement.Location = new System.Drawing.Point(109, 141);
            this.lblNomEvenement.Name = "lblNomEvenement";
            this.lblNomEvenement.Size = new System.Drawing.Size(142, 16);
            this.lblNomEvenement.TabIndex = 10;
            this.lblNomEvenement.Text = "Nom de l\'évènement";
            // 
            // BulleAjEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.appFontLabel2);
            this.Controls.Add(this.cboCreateur);
            this.Controls.Add(this.cboEventCreator);
            this.Controls.Add(this.lblFinEvenement);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.lblDebutEvenement);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.txtNomEvenement);
            this.Controls.Add(this.lblNomEvenement);
            this.Name = "BulleAjEvenement";
            this.Size = new System.Drawing.Size(705, 405);
            this.Load += new System.EventHandler(this.BulleAjEvenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomEvenement;
        private UI.AppFontLabel lblNomEvenement;
        private UI.AppFontLabel lblDebutEvenement;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private UI.AppFontLabel lblFinEvenement;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private UI.AppFontLabel cboCreateur;
        private System.Windows.Forms.ComboBox cboEventCreator;
        private UI.AppFontLabel appFontLabel2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnContinuer;
    }
}
