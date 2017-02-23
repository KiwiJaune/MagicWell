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
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.btnShowItem = new System.Windows.Forms.Button();
            this.lblWellValue = new System.Windows.Forms.Label();
            this.pnlItem = new MagicWell.ItemPanel();
            this.SuspendLayout();
            // 
            // cboItems
            // 
            this.cboItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Location = new System.Drawing.Point(12, 12);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(178, 21);
            this.cboItems.TabIndex = 0;
            // 
            // btnShowItem
            // 
            this.btnShowItem.Location = new System.Drawing.Point(196, 11);
            this.btnShowItem.Name = "btnShowItem";
            this.btnShowItem.Size = new System.Drawing.Size(75, 23);
            this.btnShowItem.TabIndex = 1;
            this.btnShowItem.Text = "Afficher";
            this.btnShowItem.UseVisualStyleBackColor = true;
            this.btnShowItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblWellValue
            // 
            this.lblWellValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWellValue.Location = new System.Drawing.Point(277, 11);
            this.lblWellValue.Name = "lblWellValue";
            this.lblWellValue.Size = new System.Drawing.Size(138, 23);
            this.lblWellValue.TabIndex = 4;
            this.lblWellValue.Text = "Puits : 0";
            this.lblWellValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlItem
            // 
            this.pnlItem.Location = new System.Drawing.Point(12, 41);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(411, 558);
            this.pnlItem.TabIndex = 6;
            this.pnlItem.WellChange += new MagicWell.ItemPanel.WellValueChangeHandler(this.pnlItem_WellChange);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 613);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.lblWellValue);
            this.Controls.Add(this.btnShowItem);
            this.Controls.Add(this.cboItems);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Button btnShowItem;
        private System.Windows.Forms.Label lblWellValue;
        private ItemPanel pnlItem;
    }
}

