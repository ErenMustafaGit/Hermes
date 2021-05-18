namespace Hermes
{
    partial class AjNouvelleDepense
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
            this.cboEvenements = new System.Windows.Forms.ComboBox();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.nupPersonne = new System.Windows.Forms.NumericUpDown();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.cboPayePar = new System.Windows.Forms.ComboBox();
            this.appFontLabel8 = new Hermes.UI.AppFontLabel();
            this.lblAnnuler = new Hermes.UI.AppFontLabel();
            this.appFontLabel6 = new Hermes.UI.AppFontLabel();
            this.appFontLabel5 = new Hermes.UI.AppFontLabel();
            this.appFontLabel4 = new Hermes.UI.AppFontLabel();
            this.appFontLabel3 = new Hermes.UI.AppFontLabel();
            this.appFontLabel2 = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.lblNouvelleDepense = new Hermes.UI.AppFontLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nupPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEvenements
            // 
            this.cboEvenements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Location = new System.Drawing.Point(171, 259);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(249, 28);
            this.cboEvenements.TabIndex = 3;
            this.cboEvenements.SelectedIndexChanged += new System.EventHandler(this.cbbEvenement_SelectedIndexChanged);
            // 
            // txtWhere
            // 
            this.txtWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtWhere.Location = new System.Drawing.Point(171, 341);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(249, 27);
            this.txtWhere.TabIndex = 9;
            // 
            // nupPersonne
            // 
            this.nupPersonne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nupPersonne.Location = new System.Drawing.Point(174, 415);
            this.nupPersonne.Name = "nupPersonne";
            this.nupPersonne.Size = new System.Drawing.Size(246, 27);
            this.nupPersonne.TabIndex = 10;
            // 
            // dtpDebut
            // 
            this.dtpDebut.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpDebut.Location = new System.Drawing.Point(479, 261);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(263, 27);
            this.dtpDebut.TabIndex = 11;
            this.dtpDebut.Value = new System.DateTime(2021, 5, 18, 18, 23, 0, 0);
            this.dtpDebut.ValueChanged += new System.EventHandler(this.dtpDebut_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpFin.Location = new System.Drawing.Point(479, 342);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(263, 27);
            this.dtpFin.TabIndex = 14;
            this.dtpFin.Value = new System.DateTime(2021, 5, 18, 18, 23, 0, 0);
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // cboPayePar
            // 
            this.cboPayePar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboPayePar.FormattingEnabled = true;
            this.cboPayePar.Location = new System.Drawing.Point(479, 415);
            this.cboPayePar.Name = "cboPayePar";
            this.cboPayePar.Size = new System.Drawing.Size(263, 28);
            this.cboPayePar.TabIndex = 15;
            this.cboPayePar.SelectedValueChanged += new System.EventHandler(this.CboPayePar_SelectedValueChanged);
            // 
            // appFontLabel8
            // 
            this.appFontLabel8.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel8.AppFontHeight = 9F;
            this.appFontLabel8.AutoSize = true;
            this.appFontLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.appFontLabel8.Location = new System.Drawing.Point(841, 576);
            this.appFontLabel8.Name = "appFontLabel8";
            this.appFontLabel8.Size = new System.Drawing.Size(61, 14);
            this.appFontLabel8.TabIndex = 19;
            this.appFontLabel8.Text = "Continuer";
            // 
            // lblAnnuler
            // 
            this.lblAnnuler.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblAnnuler.AppFontHeight = 9F;
            this.lblAnnuler.AutoSize = true;
            this.lblAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblAnnuler.Location = new System.Drawing.Point(771, 576);
            this.lblAnnuler.Name = "lblAnnuler";
            this.lblAnnuler.Size = new System.Drawing.Size(49, 14);
            this.lblAnnuler.TabIndex = 18;
            this.lblAnnuler.Text = "Annuler";
            this.lblAnnuler.Click += new System.EventHandler(this.appFontLabel7_Click);
            this.lblAnnuler.MouseLeave += new System.EventHandler(this.lblAnnuler_MouseLeave);
            this.lblAnnuler.MouseHover += new System.EventHandler(this.appFontLabel7_MouseHover);
            // 
            // appFontLabel6
            // 
            this.appFontLabel6.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel6.AppFontHeight = 10F;
            this.appFontLabel6.AutoSize = true;
            this.appFontLabel6.Location = new System.Drawing.Point(476, 387);
            this.appFontLabel6.Name = "appFontLabel6";
            this.appFontLabel6.Size = new System.Drawing.Size(65, 16);
            this.appFontLabel6.TabIndex = 16;
            this.appFontLabel6.Text = "Payé par";
            // 
            // appFontLabel5
            // 
            this.appFontLabel5.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel5.AppFontHeight = 10F;
            this.appFontLabel5.AutoSize = true;
            this.appFontLabel5.Location = new System.Drawing.Point(476, 313);
            this.appFontLabel5.Name = "appFontLabel5";
            this.appFontLabel5.Size = new System.Drawing.Size(98, 16);
            this.appFontLabel5.TabIndex = 13;
            this.appFontLabel5.Text = "Date de fin ? *";
            // 
            // appFontLabel4
            // 
            this.appFontLabel4.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel4.AppFontHeight = 10F;
            this.appFontLabel4.AutoSize = true;
            this.appFontLabel4.Location = new System.Drawing.Point(476, 236);
            this.appFontLabel4.Name = "appFontLabel4";
            this.appFontLabel4.Size = new System.Drawing.Size(119, 16);
            this.appFontLabel4.TabIndex = 12;
            this.appFontLabel4.Text = "Date de début ? *";
            // 
            // appFontLabel3
            // 
            this.appFontLabel3.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel3.AppFontHeight = 10F;
            this.appFontLabel3.AutoSize = true;
            this.appFontLabel3.Location = new System.Drawing.Point(168, 385);
            this.appFontLabel3.Name = "appFontLabel3";
            this.appFontLabel3.Size = new System.Drawing.Size(170, 16);
            this.appFontLabel3.TabIndex = 8;
            this.appFontLabel3.Text = "Combien de personne ? *";
            // 
            // appFontLabel2
            // 
            this.appFontLabel2.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel2.AppFontHeight = 10F;
            this.appFontLabel2.AutoSize = true;
            this.appFontLabel2.Location = new System.Drawing.Point(168, 312);
            this.appFontLabel2.Name = "appFontLabel2";
            this.appFontLabel2.Size = new System.Drawing.Size(68, 16);
            this.appFontLabel2.TabIndex = 6;
            this.appFontLabel2.Text = "Où ça ? *";
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel1.AppFontHeight = 10F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.Location = new System.Drawing.Point(168, 231);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(175, 16);
            this.appFontLabel1.TabIndex = 4;
            this.appFontLabel1.Text = "Dans quel évènements ? *";
            // 
            // lblNouvelleDepense
            // 
            this.lblNouvelleDepense.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblNouvelleDepense.AppFontHeight = 35F;
            this.lblNouvelleDepense.AutoSize = true;
            this.lblNouvelleDepense.IsBold = true;
            this.lblNouvelleDepense.Location = new System.Drawing.Point(161, 151);
            this.lblNouvelleDepense.Name = "lblNouvelleDepense";
            this.lblNouvelleDepense.Size = new System.Drawing.Size(411, 59);
            this.lblNouvelleDepense.TabIndex = 2;
            this.lblNouvelleDepense.Text = "Nouvelle dépense";
            // 
            // AjNouvelleDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appFontLabel8);
            this.Controls.Add(this.lblAnnuler);
            this.Controls.Add(this.appFontLabel6);
            this.Controls.Add(this.cboPayePar);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.appFontLabel5);
            this.Controls.Add(this.appFontLabel4);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.nupPersonne);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.appFontLabel3);
            this.Controls.Add(this.appFontLabel2);
            this.Controls.Add(this.appFontLabel1);
            this.Controls.Add(this.cboEvenements);
            this.Controls.Add(this.lblNouvelleDepense);
            this.Name = "AjNouvelleDepense";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.AjNouvelleDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblNouvelleDepense;
        private System.Windows.Forms.ComboBox cboEvenements;
        private UI.AppFontLabel appFontLabel1;
        private UI.AppFontLabel appFontLabel2;
        private UI.AppFontLabel appFontLabel3;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.NumericUpDown nupPersonne;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private UI.AppFontLabel appFontLabel4;
        private UI.AppFontLabel appFontLabel5;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private UI.AppFontLabel appFontLabel6;
        private System.Windows.Forms.ComboBox cboPayePar;
        private UI.AppFontLabel lblAnnuler;
        private UI.AppFontLabel appFontLabel8;
    }
}
