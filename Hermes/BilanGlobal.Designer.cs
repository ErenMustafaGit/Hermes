namespace Hermes
{
    partial class BilanGlobal
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
            this.btnBilanGlobal = new System.Windows.Forms.Button();
            this.pnlBilanToutePersonnes = new System.Windows.Forms.Panel();
            this.pnlBilanCasParCas = new System.Windows.Forms.Panel();
            this.exportPdf = new System.Windows.Forms.Button();
            this.lblVueGlobale = new Hermes.UI.AppFontLabel();
            this.lblGoBaaack = new Hermes.UI.AppFontLabel();
            this.lblEvenement = new Hermes.UI.AppFontLabel();
            this.appFontLabel2 = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // cboEvenements
            // 
            this.cboEvenements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Location = new System.Drawing.Point(422, 101);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(281, 28);
            this.cboEvenements.TabIndex = 7;
            this.cboEvenements.SelectedIndexChanged += new System.EventHandler(this.cboEvenements_SelectedIndexChanged);
            // 
            // btnBilanGlobal
            // 
            this.btnBilanGlobal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnBilanGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilanGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnBilanGlobal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBilanGlobal.Location = new System.Drawing.Point(735, 117);
            this.btnBilanGlobal.Name = "btnBilanGlobal";
            this.btnBilanGlobal.Size = new System.Drawing.Size(182, 28);
            this.btnBilanGlobal.TabIndex = 40;
            this.btnBilanGlobal.Text = "Solder l\'évènement";
            this.btnBilanGlobal.UseVisualStyleBackColor = false;
            this.btnBilanGlobal.Click += new System.EventHandler(this.BtnBilanGlobal_Click);
            // 
            // pnlBilanToutePersonnes
            // 
            this.pnlBilanToutePersonnes.Location = new System.Drawing.Point(87, 163);
            this.pnlBilanToutePersonnes.Name = "pnlBilanToutePersonnes";
            this.pnlBilanToutePersonnes.Size = new System.Drawing.Size(830, 191);
            this.pnlBilanToutePersonnes.TabIndex = 41;
            // 
            // pnlBilanCasParCas
            // 
            this.pnlBilanCasParCas.Location = new System.Drawing.Point(87, 369);
            this.pnlBilanCasParCas.Name = "pnlBilanCasParCas";
            this.pnlBilanCasParCas.Size = new System.Drawing.Size(830, 220);
            this.pnlBilanCasParCas.TabIndex = 42;
            // 
            // exportPdf
            // 
            this.exportPdf.FlatAppearance.BorderSize = 0;
            this.exportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportPdf.Location = new System.Drawing.Point(799, 63);
            this.exportPdf.Name = "exportPdf";
            this.exportPdf.Size = new System.Drawing.Size(46, 41);
            this.exportPdf.TabIndex = 43;
            this.exportPdf.Text = "PDF";
            this.exportPdf.UseVisualStyleBackColor = true;
            this.exportPdf.Click += new System.EventHandler(this.exportPdf_Click);
            // 
            // lblVueGlobale
            // 
            this.lblVueGlobale.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblVueGlobale.AppFontHeight = 9F;
            this.lblVueGlobale.AutoSize = true;
            this.lblVueGlobale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.lblVueGlobale.Location = new System.Drawing.Point(48, 607);
            this.lblVueGlobale.Name = "lblVueGlobale";
            this.lblVueGlobale.Size = new System.Drawing.Size(63, 14);
            this.lblVueGlobale.TabIndex = 44;
            this.lblVueGlobale.Text = "Vue global";
            this.lblVueGlobale.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.lblVueGlobale.MouseEnter += new System.EventHandler(this.lblGoBaaack_MouseEnter);
            this.lblVueGlobale.MouseLeave += new System.EventHandler(this.lblGoBaaack_MouseLeave);
            // 
            // lblGoBaaack
            // 
            this.lblGoBaaack.AppFont = Hermes.AppFont.Icons;
            this.lblGoBaaack.AppFontHeight = 20F;
            this.lblGoBaaack.AutoSize = true;
            this.lblGoBaaack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.lblGoBaaack.Location = new System.Drawing.Point(23, 599);
            this.lblGoBaaack.Name = "lblGoBaaack";
            this.lblGoBaaack.Size = new System.Drawing.Size(29, 27);
            this.lblGoBaaack.TabIndex = 43;
            this.lblGoBaaack.Text = "O";
            this.lblGoBaaack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblGoBaaack.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.lblGoBaaack.MouseEnter += new System.EventHandler(this.lblGoBaaack_MouseEnter);
            this.lblGoBaaack.MouseLeave += new System.EventHandler(this.lblGoBaaack_MouseLeave);
            // 
            // lblEvenement
            // 
            this.lblEvenement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblEvenement.AppFontHeight = 12F;
            this.lblEvenement.AutoSize = true;
            this.lblEvenement.Location = new System.Drawing.Point(418, 69);
            this.lblEvenement.Name = "lblEvenement";
            this.lblEvenement.Size = new System.Drawing.Size(197, 19);
            this.lblEvenement.TabIndex = 8;
            this.lblEvenement.Text = "Dans quel évènements ? *";
            // 
            // appFontLabel2
            // 
            this.appFontLabel2.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.appFontLabel2.AppFontHeight = 40F;
            this.appFontLabel2.AutoSize = true;
            this.appFontLabel2.Location = new System.Drawing.Point(66, 68);
            this.appFontLabel2.Name = "appFontLabel2";
            this.appFontLabel2.Size = new System.Drawing.Size(325, 67);
            this.appFontLabel2.TabIndex = 2;
            this.appFontLabel2.Text = "Bilan global";
            // 
            // BilanGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVueGlobale);
            this.Controls.Add(this.lblGoBaaack);
            this.Controls.Add(this.exportPdf);
            this.Controls.Add(this.pnlBilanCasParCas);
            this.Controls.Add(this.pnlBilanToutePersonnes);
            this.Controls.Add(this.btnBilanGlobal);
            this.Controls.Add(this.lblEvenement);
            this.Controls.Add(this.cboEvenements);
            this.Controls.Add(this.appFontLabel2);
            this.Name = "BilanGlobal";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.BilanGlobal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel appFontLabel2;
        private UI.AppFontLabel lblEvenement;
        private System.Windows.Forms.ComboBox cboEvenements;
        private System.Windows.Forms.Button btnBilanGlobal;
        private System.Windows.Forms.Panel pnlBilanToutePersonnes;
        private System.Windows.Forms.Panel pnlBilanCasParCas;
        private UI.AppFontLabel lblVueGlobale;
        private UI.AppFontLabel lblGoBaaack;
        private System.Windows.Forms.Button exportPdf;
    }
}
