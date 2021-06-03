namespace Hermes
{
    partial class AjoutEvenement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutEvenement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdd = new Hermes.UI.AppFontLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 233);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AppFont = Hermes.AppFont.Icons;
            this.lblAdd.AppFontHeight = 40F;
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(139, 90);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(58, 55);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "O";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblAdd_MouseClick);
            this.lblAdd.MouseEnter += new System.EventHandler(this.lblAdd_MouseEnter);
            this.lblAdd.MouseLeave += new System.EventHandler(this.LblAdd_MouseLeave);
            this.lblAdd.MouseHover += new System.EventHandler(this.LblAdd_MouseHover);
            // 
            // AjoutEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAdd);
            this.Name = "AjoutEvenement";
            this.Size = new System.Drawing.Size(334, 233);
            this.Load += new System.EventHandler(this.AjoutEvenement_Load);
            this.MouseEnter += new System.EventHandler(this.AjoutEvenement_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.AjoutEvenement_MouseLeave);
            this.MouseHover += new System.EventHandler(this.AjoutEvenement_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private UI.AppFontLabel lblAdd;
    }
}
