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
            ppList.Add(new RuneType(Stat.Vitalite, RuneFamily.Base, Properties.Resources.Vi, 0.20, 5, 15, 50));
            ppList.Add(new RuneType(Stat.Agilite, RuneFamily.Base, Properties.Resources.Age, 1, 1, 3, 10));
            ppList.Add(new RuneType(Stat.Chance, RuneFamily.Base, Properties.Resources.Cha, 1, 1, 3, 10));
            ppList.Add(new RuneType(Stat.Force, RuneFamily.Base, Properties.Resources.Fo, 1, 1, 3, 10));
            ppList.Add(new RuneType(Stat.Intelligence, RuneFamily.Base, Properties.Resources.Ine, 1, 1, 3, 10));
            ppList.Add(new RuneType(Stat.Sagesse, RuneFamily.Base, Properties.Resources.Sa, 3, 1, 3, 10));
            ppList.Add(new RuneType(Stat.Initiative, RuneFamily.Base, Properties.Resources.Ini, 0.1, 10, 30, 100));

            ppList.Add(new RuneType(Stat.Dommage, RuneFamily.Dommage, Properties.Resources.Do, 20, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Dommage_Air, RuneFamily.Dommage, Properties.Resources.DoAir, 5, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Dommage_Eau, RuneFamily.Dommage, Properties.Resources.DoEau, 5, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Dommage_Terre, RuneFamily.Dommage, Properties.Resources.DoTerre, 5, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Dommage_Neutre, RuneFamily.Dommage, Properties.Resources.DoNeutre, 5, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Dommage_Feu, RuneFamily.Dommage, Properties.Resources.DoFeu, 5, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Dommage_Pousee, RuneFamily.Dommage, Properties.Resources.DoPou, 5, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Dommage_Critique, RuneFamily.Dommage, Properties.Resources.DoCri, 5, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Dommage_Piege, RuneFamily.Dommage, Properties.Resources.Pi, 5, 1, 3, -1));

            ppList.Add(new RuneType(Stat.Resistance_Air_Pourcent, RuneFamily.Resistance, Properties.Resources.RePerAir, 6, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Resistance_Eau_Pourcent, RuneFamily.Resistance, Properties.Resources.RePerEau, 6, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Resistance_Terre_Pourcent, RuneFamily.Resistance, Properties.Resources.RePerTerre, 6, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Resistance_Neutre_Pourcent, RuneFamily.Resistance, Properties.Resources.RePerNeutre, 6, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Resistance_Feu_Pourcent, RuneFamily.Resistance, Properties.Resources.RePerFeu, 6, 1, -1, -1));

            ppList.Add(new RuneType(Stat.Resistance_Air_Fixe, RuneFamily.Resistance, Properties.Resources.ReAir, 2, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Resistance_Eau_Fixe, RuneFamily.Resistance, Properties.Resources.ReEau, 2, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Resistance_Terre_Fixe, RuneFamily.Resistance, Properties.Resources.ReTerre, 2, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Resistance_Neutre_Fixe, RuneFamily.Resistance, Properties.Resources.ReNeutre, 2, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Resistance_Feu_Fixe, RuneFamily.Resistance, Properties.Resources.ReFeu, 2, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Resistance_Poussee_Fixe, RuneFamily.Resistance, Properties.Resources.RePou, 2, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Resistance_Critique_Fixe, RuneFamily.Resistance, Properties.Resources.ReCri, 2, 1, 3, -1));

            ppList.Add(new RuneType(Stat.Pods, RuneFamily.Helper, Properties.Resources.Pod, 0.25, 10, 30, 100));
            ppList.Add(new RuneType(Stat.Prospection, RuneFamily.Helper, Properties.Resources.Prospe, 3, 1, 3, -1));

            ppList.Add(new RuneType(Stat.PA, RuneFamily.Special, Properties.Resources.GaPa, 100, 1, -1, -1));
            ppList.Add(new RuneType(Stat.PM, RuneFamily.Special, Properties.Resources.GaPme, 90, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Portee, RuneFamily.Special, Properties.Resources.Po, 51, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Invocation, RuneFamily.Special, Properties.Resources.Invo, 30, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Chasse, RuneFamily.Special, Properties.Resources.Chasse, 5, 1, -1, -1));

            ppList.Add(new RuneType(Stat.Tacle, RuneFamily.SlowDown, Properties.Resources.Tac, 4, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Fuite, RuneFamily.SlowDown, Properties.Resources.Fui, 4, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Retrait_PA, RuneFamily.SlowDown, Properties.Resources.RetPa, 7, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Retrait_PM, RuneFamily.SlowDown, Properties.Resources.RetPme, 7, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Esquive_PA, RuneFamily.SlowDown, Properties.Resources.RePa, 7, 1, 3, -1));
            ppList.Add(new RuneType(Stat.Esquive_PM, RuneFamily.SlowDown, Properties.Resources.RePme, 7, 1, 3, -1));

            ppList.Add(new RuneType(Stat.Soin, RuneFamily.Power, Properties.Resources.So, 10, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Puissance, RuneFamily.Power, Properties.Resources.DoPer, 2, 1, 3, 10));
            ppList.Add(new RuneType(Stat.Critique, RuneFamily.Power, Properties.Resources.Cri, 10, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Renvoi_Dommage, RuneFamily.Power, Properties.Resources.DoRen, 10, 1, -1, -1));
            ppList.Add(new RuneType(Stat.Puissance_Piege, RuneFamily.Power, Properties.Resources.PiPer, 2, 1, 3, 10));
        }
        
        public static List<RuneType> GetRuneTypes()
        {
            return ppList;
        }
        
        public static RuneType GetRune(Stat stat)
        {
            return ppList.Find(r => r.Stat == stat);
        }
    }

    public class RuneType
    {
        Stat ppStat;
        double ppWeigth;
        int ppNormalValue, ppPaValue, ppRaValue;
        Image ppImage;
        RuneFamily ppFamily;

        public RuneType(Stat stat, RuneFamily family, Image img, double weigth, int normalValue, int paValue, int raValue)
        {
            ppStat = stat;
            ppImage = img;
            ppWeigth = weigth;
            ppNormalValue = normalValue;
            ppPaValue = paValue;
            ppRaValue = raValue;
            ppFamily = family;
        }

        public Stat Stat
        {
            get { return ppStat; }
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

        public String Name
        {
            get { return ppStat.GetNiceName();  }
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
            return ppStat.GetNiceName();
        }
    }
}
