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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.btnShowItem = new System.Windows.Forms.Button();
            this.lblWellValue = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.pnlItem = new MagicWell.ItemPanel();
            this.lblMsg = new System.Windows.Forms.Label();
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
            this.lblWellValue.Size = new System.Drawing.Size(116, 23);
            this.lblWellValue.TabIndex = 4;
            this.lblWellValue.Text = "Puits : 0";
            this.lblWellValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Image = global::MagicWell.Properties.Resources.Close16;
            this.btnReset.Location = new System.Drawing.Point(399, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(23, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(11, 52);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(317, 47);
            this.txtMsg.TabIndex = 8;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(334, 50);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(78, 49);
            this.btnParse.TabIndex = 9;
            this.btnParse.Text = "Calculer";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // pnlItem
            // 
            this.pnlItem.Location = new System.Drawing.Point(11, 110);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(411, 541);
            this.pnlItem.TabIndex = 6;
            this.pnlItem.WellValue = 0D;
            this.pnlItem.WellChange += new MagicWell.ItemPanel.WellValueChangeHandler(this.pnlItem_WellChange);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 36);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(126, 13);
            this.lblMsg.TabIndex = 10;
            this.lblMsg.Text = "Message de forgemagie :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 663);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.lblWellValue);
            this.Controls.Add(this.btnShowItem);
            this.Controls.Add(this.cboItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Magic Well";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Button btnShowItem;
        private System.Windows.Forms.Label lblWellValue;
        private ItemPanel pnlItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label lblMsg;
    }
}

