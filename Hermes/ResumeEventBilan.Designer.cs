namespace Hermes
{
    partial class ResumeEventBilan
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
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.lblIconDate = new Hermes.UI.AppFontLabel();
            this.lblIconCreator = new Hermes.UI.AppFontLabel();
            this.lblIconNbPart = new Hermes.UI.AppFontLabel();
            this.lblIconDescription = new Hermes.UI.AppFontLabel();
            this.lblDate = new Hermes.UI.AppFontLabel();
            this.lblCreator = new Hermes.UI.AppFontLabel();
            this.lblNbPart = new Hermes.UI.AppFontLabel();
            this.lblDescription = new Hermes.UI.AppFontLabel();
            this.lblTitre = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnMoreInfo.FlatAppearance.BorderSize = 0;
            this.btnMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreInfo.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.btnMoreInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnMoreInfo.Location = new System.Drawing.Point(106, 185);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(125, 28);
            this.btnMoreInfo.TabIndex = 13;
            this.btnMoreInfo.Text = "Bilan";
            this.btnMoreInfo.UseVisualStyleBackColor = false;
            this.btnMoreInfo.Click += new System.EventHandler(this.BtnMoreInfo_Click);
            // 
            // lblIconDate
            // 
            this.lblIconDate.AppFont = Hermes.AppFont.Icons;
            this.lblIconDate.AppFontHeight = 15F;
            this.lblIconDate.AutoSize = true;
            this.lblIconDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconDate.Location = new System.Drawing.Point(24, 116);
            this.lblIconDate.Name = "lblIconDate";
            this.lblIconDate.Size = new System.Drawing.Size(21, 20);
            this.lblIconDate.TabIndex = 9;
            this.lblIconDate.Text = "O";
            // 
            // lblIconCreator
            // 
            this.lblIconCreator.AppFont = Hermes.AppFont.Icons;
            this.lblIconCreator.AppFontHeight = 15F;
            this.lblIconCreator.AutoSize = true;
            this.lblIconCreator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconCreator.Location = new System.Drawing.Point(24, 146);
            this.lblIconCreator.Name = "lblIconCreator";
            this.lblIconCreator.Size = new System.Drawing.Size(21, 20);
            this.lblIconCreator.TabIndex = 10;
            this.lblIconCreator.Text = "O";
            // 
            // lblIconNbPart
            // 
            this.lblIconNbPart.AppFont = Hermes.AppFont.Icons;
            this.lblIconNbPart.AppFontHeight = 15F;
            this.lblIconNbPart.AutoSize = true;
            this.lblIconNbPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconNbPart.Location = new System.Drawing.Point(24, 88);
            this.lblIconNbPart.Name = "lblIconNbPart";
            this.lblIconNbPart.Size = new System.Drawing.Size(21, 20);
            this.lblIconNbPart.TabIndex = 11;
            this.lblIconNbPart.Text = "O";
            // 
            // lblIconDescription
            // 
            this.lblIconDescription.AppFont = Hermes.AppFont.Icons;
            this.lblIconDescription.AppFontHeight = 15F;
            this.lblIconDescription.AutoSize = true;
            this.lblIconDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconDescription.Location = new System.Drawing.Point(24, 59);
            this.lblIconDescription.Name = "lblIconDescription";
            this.lblIconDescription.Size = new System.Drawing.Size(21, 20);
            this.lblIconDescription.TabIndex = 12;
            this.lblIconDescription.Text = "O";
            // 
            // lblDate
            // 
            this.lblDate.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDate.AppFontHeight = 10F;
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblDate.Location = new System.Drawing.Point(58, 117);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "BeginDate";
            // 
            // lblCreator
            // 
            this.lblCreator.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblCreator.AppFontHeight = 10F;
            this.lblCreator.AutoSize = true;
            this.lblCreator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblCreator.Location = new System.Drawing.Point(58, 147);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(64, 16);
            this.lblCreator.TabIndex = 6;
            this.lblCreator.Text = "Createur";
            // 
            // lblNbPart
            // 
            this.lblNbPart.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblNbPart.AppFontHeight = 10F;
            this.lblNbPart.AutoSize = true;
            this.lblNbPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNbPart.Location = new System.Drawing.Point(58, 89);
            this.lblNbPart.Name = "lblNbPart";
            this.lblNbPart.Size = new System.Drawing.Size(150, 16);
            this.lblNbPart.TabIndex = 7;
            this.lblNbPart.Text = "Nombre de participant";
            // 
            // lblDescription
            // 
            this.lblDescription.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDescription.AppFontHeight = 10F;
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblDescription.Location = new System.Drawing.Point(58, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 16);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblTitre
            // 
            this.lblTitre.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblTitre.AppFontHeight = 20F;
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblTitre.Location = new System.Drawing.Point(12, 16);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(73, 34);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Titre";
            // 
            // ResumeEventBilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.lblIconDate);
            this.Controls.Add(this.lblIconCreator);
            this.Controls.Add(this.lblIconNbPart);
            this.Controls.Add(this.lblIconDescription);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblNbPart);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitre);
            this.Name = "ResumeEventBilan";
            this.Size = new System.Drawing.Size(334, 233);
            this.Load += new System.EventHandler(this.ResumeEventBilan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoreInfo;
        private UI.AppFontLabel lblIconDate;
        private UI.AppFontLabel lblIconCreator;
        private UI.AppFontLabel lblIconNbPart;
        private UI.AppFontLabel lblIconDescription;
        private UI.AppFontLabel lblDate;
        private UI.AppFontLabel lblCreator;
        private UI.AppFontLabel lblNbPart;
        private UI.AppFontLabel lblDescription;
        private UI.AppFontLabel lblTitre;
    }
}
