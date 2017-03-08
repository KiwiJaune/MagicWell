using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWell
{
    public static class MyExtensions
    {
        public static String GetNiceName(this Stat stat)
        {
            String niceName = "";

            switch (stat)
            {
                case Stat.Agilite: niceName = "Agilité"; break;
                case Stat.Chance: niceName = "Chance"; break;
                case Stat.Chasse: niceName = "Arme de chasse"; break;
                case Stat.Critique: niceName = "% Critique"; break;
                case Stat.Dommage: niceName = "Dommage"; break;
                case Stat.Dommage_Air: niceName = "Dommage Air"; break;
                case Stat.Dommage_Critique: niceName = "Dommage Critique"; break;
                case Stat.Dommage_Eau: niceName = "Dommage Eau"; break;
                case Stat.Dommage_Feu: niceName = "Dommage Feu"; break;
                case Stat.Dommage_Neutre: niceName = "Dommage Neutre"; break;
                case Stat.Dommage_Pousee: niceName = "Dommage Poussée"; break;
                case Stat.Dommage_Terre: niceName = "Dommage Terre"; break;
                case Stat.Force: niceName = "Force"; break;
                case Stat.Fuite: niceName = "Fuite"; break;
                case Stat.PA: niceName = "PA"; break;
                case Stat.PM: niceName = "PM"; break;
                case Stat.Intelligence: niceName = "Intelligence"; break;
                case Stat.Initiative: niceName = "Initiative"; break;
                case Stat.Invocation: niceName = "Invocation"; break;
                case Stat.Dommage_Piege: niceName = "Dommage Piège"; break;
                case Stat.Portee: niceName = "Portée"; break;
                case Stat.Pods: niceName = "Pods"; break;
                case Stat.Prospection: niceName = "Prospection"; break;
                case Stat.Puissance: niceName = "Puissance"; break;
                case Stat.Puissance_Piege: niceName = "Puissance Piège"; break;
                case Stat.Renvoi_Dommage: niceName = "Renvoi Dommage"; break;
                case Stat.Resistance_Air_Fixe: niceName = "Résistance Air"; break;
                case Stat.Resistance_Critique_Fixe: niceName = "Résistance Critique"; break;
                case Stat.Resistance_Eau_Fixe: niceName = "Résistance Eau"; break;
                case Stat.Resistance_Feu_Fixe: niceName = "Résistance Feu"; break;
                case Stat.Resistance_Neutre_Fixe: niceName = "Résistance Neutre"; break;
                case Stat.Esquive_PA: niceName = "Esquive PA"; break;
                case Stat.Resistance_Air_Pourcent: niceName = "% Résistance Air"; break;
                case Stat.Resistance_Eau_Pourcent: niceName = "% Résistance Eau"; break;
                case Stat.Resistance_Feu_Pourcent: niceName = "% Résistance Feu"; break;
                case Stat.Resistance_Neutre_Pourcent: niceName = "% Résistance Neutre"; break;
                case Stat.Resistance_Terre_Pourcent: niceName = "% Résistance Terre"; break;
                case Stat.Esquive_PM: niceName = "Esquive PM"; break;
                case Stat.Resistance_Poussee_Fixe: niceName = "Résistance Poussée"; break;
                case Stat.Resistance_Terre_Fixe: niceName = "Résistance Terre"; break;
                case Stat.Retrait_PA: niceName = "Retrait PA"; break;
                case Stat.Retrait_PM: niceName = "Retrait PM"; break;
                case Stat.Sagesse: niceName = "Sagesse"; break;
                case Stat.Soin: niceName = "Soin"; break;
                case Stat.Tacle: niceName = "Tacle"; break;
                case Stat.Vitalite: niceName = "Vitalité"; break;
                case Stat.Unknown: niceName = "???"; break;
            }

            return niceName;
        }
    }
}
