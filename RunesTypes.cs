using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWell
{
    static class RunesTypes
    {
        static List<RuneType> ppList;

        static RunesTypes()
        {
            ppList = new List<RuneType>();
            ppList.Add(new RuneType("Vitalité", RuneFamily.Base, Properties.Resources.Vi, 0.20, 5, 15, 50));
            ppList.Add(new RuneType("Agilité", RuneFamily.Base, Properties.Resources.Age, 1, 1, 3, 10));
            ppList.Add(new RuneType("Chance", RuneFamily.Base, Properties.Resources.Cha, 1, 1, 3, 10));
            ppList.Add(new RuneType("Force", RuneFamily.Base, Properties.Resources.Fo, 1, 1, 3, 10));
            ppList.Add(new RuneType("Intelligence", RuneFamily.Base, Properties.Resources.Ine, 1, 1, 3, 10));
            ppList.Add(new RuneType("Sagesse", RuneFamily.Base, Properties.Resources.Sa, 3, 1, 3, 10));
            ppList.Add(new RuneType("Initiative", RuneFamily.Base, Properties.Resources.Ini, 0.1, 10, 30, 100));

            ppList.Add(new RuneType("Dommage", RuneFamily.Dommage, Properties.Resources.Do, 20, 1, -1, -1));
            ppList.Add(new RuneType("Dommage air", RuneFamily.Dommage, Properties.Resources.DoAir, 5, 1, 3, -1));
            ppList.Add(new RuneType("Dommage eau", RuneFamily.Dommage, Properties.Resources.DoEau, 5, 1, 3, -1));
            ppList.Add(new RuneType("Dommage terre", RuneFamily.Dommage, Properties.Resources.DoTerre, 5, 1, 3, -1));
            ppList.Add(new RuneType("Dommage neutre", RuneFamily.Dommage, Properties.Resources.DoNeutre, 5, 1, 3, -1));
            ppList.Add(new RuneType("Dommage feu", RuneFamily.Dommage, Properties.Resources.DoFeu, 5, 1, 3, -1));
            ppList.Add(new RuneType("Dommage poussée", RuneFamily.Dommage, Properties.Resources.DoPou, 5, 1, 3, -1));
            ppList.Add(new RuneType("Dommage critique", RuneFamily.Dommage, Properties.Resources.DoCri, 5, 1, 3, -1));
            ppList.Add(new RuneType("Dommage piège", RuneFamily.Dommage, Properties.Resources.Pi, 5, 1, 3, -1));

            ppList.Add(new RuneType("Resistance air %", RuneFamily.Resistance, Properties.Resources.RePerAir, 6, 1, -1, -1));
            ppList.Add(new RuneType("Resistance eau %", RuneFamily.Resistance, Properties.Resources.RePerEau, 6, 1, -1, -1));
            ppList.Add(new RuneType("Resistance terre %", RuneFamily.Resistance, Properties.Resources.RePerTerre, 6, 1, -1, -1));
            ppList.Add(new RuneType("Resistance neutre %", RuneFamily.Resistance, Properties.Resources.RePerNeutre, 6, 1, -1, -1));
            ppList.Add(new RuneType("Resistance feu %", RuneFamily.Resistance, Properties.Resources.RePerFeu, 6, 1, -1, -1));

            ppList.Add(new RuneType("Resistance air fixe", RuneFamily.Resistance, Properties.Resources.ReAir, 2, 1, -1, -1));
            ppList.Add(new RuneType("Resistance eau fixe", RuneFamily.Resistance, Properties.Resources.ReEau, 2, 1, -1, -1));
            ppList.Add(new RuneType("Resistance terre fixe", RuneFamily.Resistance, Properties.Resources.ReTerre, 2, 1, -1, -1));
            ppList.Add(new RuneType("Resistance neutre fixe", RuneFamily.Resistance, Properties.Resources.ReNeutre, 2, 1, -1, -1));
            ppList.Add(new RuneType("Resistance feu fixe", RuneFamily.Resistance, Properties.Resources.ReFeu, 2, 1, -1, -1));
            ppList.Add(new RuneType("Resistance poussée fixe", RuneFamily.Resistance, Properties.Resources.RePou, 2, 1, 3, -1));
            ppList.Add(new RuneType("Resistance critique fixe", RuneFamily.Resistance, Properties.Resources.ReCri, 2, 1, 3, -1));

            ppList.Add(new RuneType("Pods", RuneFamily.Helper, Properties.Resources.Pod, 0.25, 10, 30, 100));
            ppList.Add(new RuneType("Prospection", RuneFamily.Helper, Properties.Resources.Prospe, 3, 1, 3, -1));

            ppList.Add(new RuneType("PA", RuneFamily.Special, Properties.Resources.GaPa, 100, 1, -1, -1));
            ppList.Add(new RuneType("PM", RuneFamily.Special, Properties.Resources.GaPme, 90, 1, -1, -1));
            ppList.Add(new RuneType("Portée", RuneFamily.Special, Properties.Resources.Po, 51, 1, -1, -1));
            ppList.Add(new RuneType("Invocation", RuneFamily.Special, Properties.Resources.Invo, 30, 1, -1, -1));
            ppList.Add(new RuneType("Chasse", RuneFamily.Special, Properties.Resources.Chasse, 5, 1, -1, -1));

            ppList.Add(new RuneType("Tacle", RuneFamily.SlowDown, Properties.Resources.Tac, 4, 1, 3, -1));
            ppList.Add(new RuneType("Fuite", RuneFamily.SlowDown, Properties.Resources.Fui, 4, 1, 3, -1));
            ppList.Add(new RuneType("Retrait PA", RuneFamily.SlowDown, Properties.Resources.RetPa, 7, 1, 3, -1));
            ppList.Add(new RuneType("Retrait PM", RuneFamily.SlowDown, Properties.Resources.RetPme, 7, 1, 3, -1));
            ppList.Add(new RuneType("Esquive PA", RuneFamily.SlowDown, Properties.Resources.RePa, 7, 1, 3, -1));
            ppList.Add(new RuneType("Esquive PM", RuneFamily.SlowDown, Properties.Resources.RePme, 7, 1, 3, -1));

            ppList.Add(new RuneType("Soin", RuneFamily.Power, Properties.Resources.So, 10, 1, -1, -1));
            ppList.Add(new RuneType("Puissance", RuneFamily.Power, Properties.Resources.DoPer, 2, 1, 3, 10));
            ppList.Add(new RuneType("Critique %", RuneFamily.Power, Properties.Resources.Cri, 10, 1, -1, -1));
            ppList.Add(new RuneType("Renvoi dommage", RuneFamily.Power, Properties.Resources.DoRen, 10, 1, -1, -1));
            ppList.Add(new RuneType("Puissance piège %", RuneFamily.Power, Properties.Resources.PiPer, 2, 1, 3, 10));
        }
        
        public static List<RuneType> GetRuneTypes()
        {
            return ppList;
        }
    }

    public enum RuneFamily
    {
        Base,
        Dommage,
        Resistance,
        Special,
        SlowDown,
        Helper,
        Power
    }

    public enum RunePower
    {
        Normal,
        Pa,
        Ra
    }

    public class RuneType
    {
        string ppName;
        double ppWeigth;
        int ppNormalValue, ppPaValue, ppRaValue;
        Image ppImage;
        RuneFamily ppFamily;

        public RuneType(string name, RuneFamily family, Image img, double weigth, int normalValue, int paValue, int raValue)
        {
            ppName = name;
            ppImage = img;
            ppWeigth = weigth;
            ppNormalValue = normalValue;
            ppPaValue = paValue;
            ppRaValue = raValue;
            ppFamily = family;
        }

        public String Name
        {
            get { return ppName; }
        }

        public Image Image
        {
            get { return ppImage; }
        }

        public RuneFamily Family
        {
            get { return ppFamily; }
        }

        public Boolean HasPa
        {
            get { return ppPaValue != -1; }
        }

        public Boolean HasRa
        {
            get { return ppRaValue != -1; }
        }

        public double GetWeigth(RunePower power)
        {
            return GetValue(power) * ppWeigth;
        }

        public double GetValue(RunePower power)
        {
            int value = 0;

            switch (power)
            {
                case RunePower.Normal:
                    value = ppNormalValue;
                    break;
                case RunePower.Pa:
                    value = ppPaValue;
                    break;
                case RunePower.Ra:
                    value = ppRaValue;
                    break;
            }

            return value;
        }

        public override string ToString()
        {
            return ppName;
        }
    }
}
