namespace MagicWell
{
    partial class MainForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboRuneType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWellValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboRuneType
            // 
            this.cboRuneType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRuneType.FormattingEnabled = true;
            this.cboRuneType.Location = new System.Drawing.Point(84, 12);
            this.cboRuneType.Name = "cboRuneType";
            this.cboRuneType.Size = new System.Drawing.Size(178, 21);
            this.cboRuneType.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(268, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.panelsContainer.Location = new System.Drawing.Point(12, 39);
            this.panelsContainer.Name = "flowLayoutPanel1";
            this.panelsContainer.Size = new System.Drawing.Size(400, 500);
            this.panelsContainer.TabIndex = 3;
            // 
            // lblWellValue
            // 
            this.lblWellValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWellValue.Location = new System.Drawing.Point(11, 11);
            this.lblWellValue.Name = "lblWellValue";
            this.lblWellValue.Size = new System.Drawing.Size(66, 23);
            this.lblWellValue.TabIndex = 4;
            this.lblWellValue.Text = "0";
            this.lblWellValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 550);
            this.Controls.Add(this.lblWellValue);
            this.Controls.Add(this.panelsContainer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboRuneType);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRuneType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel panelsContainer;
        private System.Windows.Forms.Label lblWellValue;
    }
}

