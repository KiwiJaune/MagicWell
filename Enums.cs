using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWell
{
    public enum ItemType
    {
        Amulette,
        Anneau,
        Arc,
        Baguette,
        Bâton,
        Bottes,
        Cape,
        Ceinture,
        Chapeau,
        Dague,
        Épée,
        Faux,
        Hache,
        Marteau,
        Pelle
    }

    public enum Stat
    {
        Agilite,
        Chance,
        Chasse,
        Critique,
        Dommage,
        Dommage_Air,
        Dommage_Critique,
        Dommage_Eau,
        Dommage_Feu,
        Dommage_Neutre,
        Dommage_Pousee,
        Dommage_Terre,
        Force,
        Fuite,
        PA,
        PM,
        Intelligence,
        Initiative,
        Invocation,
        Dommage_Piege,
        Portee,
        Pods,
        Prospection,
        Puissance,
        Puissance_Piege,
        Resistance_Air_Fixe,
        Resistance_Critique_Fixe,
        Resistance_Eau_Fixe,
        Resistance_Feu_Fixe,
        Resistance_Neutre_Fixe,
        Esquive_PA,
        Resistance_Air_Pourcent,
        Resistance_Eau_Pourcent,
        Resistance_Feu_Pourcent,
        Resistance_Neutre_Pourcent,
        Resistance_Terre_Pourcent,
        Esquive_PM,
        Renvoi_Dommage,
        Resistance_Poussee_Fixe,
        Resistance_Terre_Fixe,
        Retrait_PA,
        Retrait_PM,
        Sagesse,
        Soin,
        Tacle,
        Vitalite,
        Unknown
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
}
