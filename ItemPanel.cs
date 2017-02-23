using System.Collections.Generic;
using System.Windows.Forms;

namespace MagicWell
{
    public partial class ItemPanel : UserControl
    {
        double ppWellValue;

        public delegate void WellValueChangeHandler(double wellValue);
        public event WellValueChangeHandler WellChange;

        public ItemPanel()
        {
            InitializeComponent();
        }

        public void ShowItem(Item item)
        {
            ppWellValue = 0;

            lblName.Text = item.Name;
            lblLevel.Text = "Niveau " + item.Level.ToString();

            panelsContainer.Controls.Clear();

            foreach (KeyValuePair<Stat, int> stat in item.MaxStats)
            {
                RunePanel panel = new RunePanel();
                panel.ShowRune(RunesTypes.GetRune(stat.Key));
                panel.Margin = new Padding(0);

                panel.WellChange += Panel_WellChange;

                panelsContainer.Controls.Add(panel);
            }

            oOnWellChange();
        }
        

        private void Panel_WellChange(RuneType rune, RunePower power, bool wellIncrease)
        {
            double value = rune.GetWeigth(power) * (wellIncrease ? 1 : -1);

            ppWellValue += value;

            oOnWellChange();
        }

        protected void oOnWellChange()
        {
            WellChange?.Invoke(ppWellValue);
        }
    }
}
