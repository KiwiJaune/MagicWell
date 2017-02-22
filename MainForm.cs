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
        List<RuneType> ppRunes;
        double ppWellValue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ppRunes = RunesTypes.GetRuneTypes();
            cboRuneType.Items.AddRange(ppRunes.ToArray());
            cboRuneType.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RunePanel panel = new RunePanel();
            panel.ShowRune((RuneType)cboRuneType.SelectedItem);
            panel.Margin = new Padding(0);

            panel.WellChange += Panel_WellChange;

            panelsContainer.Controls.Add(panel);
        }

        private void Panel_WellChange(RuneType rune, RunePower power, bool wellIncrease)
        {
            double value = rune.GetWeigth(power) * (wellIncrease ? 1 : -1);

            ppWellValue += value;
            lblWellValue.Text = ppWellValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDDParser.Parse("dofus-data.json");
        }
    }
}
