using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicWell
{
    public partial class MainForm : Form
    {
        List<Item> ppItems;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ppItems = BDDParser.Parse("dofus-data.json").OrderBy(i => i.Name).ToList();

            cboItems.Items.AddRange(ppItems.ToArray());

            cboItems.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlItem.ShowItem((Item)cboItems.SelectedItem);
        }

        private void pnlItem_WellChange(double wellValue)
        {
            lblWellValue.Text = "Puits : " + wellValue.ToString();
        }
    }
}
