namespace MagicWell
{
    partial class RunePanel
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblNormalValue = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPa = new System.Windows.Forms.Button();
            this.lblPaValue = new System.Windows.Forms.Label();
            this.btnRa = new System.Windows.Forms.Button();
            this.lblRaValue = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(132, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(32, 32);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // lblNormalValue
            // 
            this.lblNormalValue.Location = new System.Drawing.Point(208, 9);
            this.lblNormalValue.Name = "lblNormalValue";
            this.lblNormalValue.Size = new System.Drawing.Size(32, 17);
            this.lblNormalValue.TabIndex = 1;
            this.lblNormalValue.Text = "00";
            this.lblNormalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(241, 6);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(23, 23);
            this.btnNormal.TabIndex = 2;
            this.btnNormal.Text = "-";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Resistance critique fixe";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPa
            // 
            this.btnPa.Location = new System.Drawing.Point(299, 6);
            this.btnPa.Name = "btnPa";
            this.btnPa.Size = new System.Drawing.Size(23, 23);
            this.btnPa.TabIndex = 5;
            this.btnPa.Text = "-";
            this.btnPa.UseVisualStyleBackColor = true;
            this.btnPa.Click += new System.EventHandler(this.btnPa_Click);
            // 
            // lblPaValue
            // 
            this.lblPaValue.Location = new System.Drawing.Point(275, 9);
            this.lblPaValue.Name = "lblPaValue";
            this.lblPaValue.Size = new System.Drawing.Size(23, 17);
            this.lblPaValue.TabIndex = 4;
            this.lblPaValue.Text = "00";
            this.lblPaValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRa
            // 
            this.btnRa.Location = new System.Drawing.Point(357, 6);
            this.btnRa.Name = "btnRa";
            this.btnRa.Size = new System.Drawing.Size(23, 23);
            this.btnRa.TabIndex = 7;
            this.btnRa.Text = "-";
            this.btnRa.UseVisualStyleBackColor = true;
            this.btnRa.Click += new System.EventHandler(this.btnRa_Click);
            // 
            // lblRaValue
            // 
            this.lblRaValue.Location = new System.Drawing.Point(333, 9);
            this.lblRaValue.Name = "lblRaValue";
            this.lblRaValue.Size = new System.Drawing.Size(23, 17);
            this.lblRaValue.TabIndex = 6;
            this.lblRaValue.Text = "00";
            this.lblRaValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(170, 6);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(23, 23);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // RunePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnRa);
            this.Controls.Add(this.lblRaValue);
            this.Controls.Add(this.btnPa);
            this.Controls.Add(this.lblPaValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.lblNormalValue);
            this.Controls.Add(this.picImage);
            this.Name = "RunePanel";
            this.Size = new System.Drawing.Size(390, 36);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblNormalValue;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPa;
        private System.Windows.Forms.Label lblPaValue;
        private System.Windows.Forms.Button btnRa;
        private System.Windows.Forms.Label lblRaValue;
        private System.Windows.Forms.Button btnPlus;
    }
}
