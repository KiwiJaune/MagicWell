using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicWell
{
    public partial class RunePanel : UserControl
    {
        public delegate void WellChangeHandler(RuneType rune, RunePower power, Boolean wellIncrease);
        public event WellChangeHandler WellChange;

        RuneType ppRune;

        public RunePanel()
        {
            InitializeComponent();
        }

        public void ShowRune(RuneType rune)
        {
            ppRune = rune;

            picImage.Image = ppRune.Image;
            lblName.Text = ppRune.Name;
            lblNormalValue.Text = ppRune.GetWeigth(RunePower.Normal).ToString();
            
            lblPaValue.Text = ppRune.GetWeigth(RunePower.Pa).ToString();
            lblPaValue.Visible = ppRune.HasPa;
            btnPa.Visible = ppRune.HasPa;

            lblRaValue.Text = ppRune.GetWeigth(RunePower.Ra).ToString();
            lblRaValue.Visible = ppRune.HasRa;
            btnRa.Visible = ppRune.HasRa;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            oOnWellChange(ppRune, RunePower.Normal, true);
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            oOnWellChange(ppRune, RunePower.Normal, false);
        }

        private void btnPa_Click(object sender, EventArgs e)
        {
            oOnWellChange(ppRune, RunePower.Pa, false);
        }

        private void btnRa_Click(object sender, EventArgs e)
        {
            oOnWellChange(ppRune, RunePower.Ra, false);
        }

        protected void oOnWellChange(RuneType rune, RunePower power, Boolean wellIncrease)
        {
            WellChange(rune, power, wellIncrease);
        }
    }
}
