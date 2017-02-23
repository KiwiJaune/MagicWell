using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWell
{
    static class BDDParser
    {
        public static List<Item> Parse(String path)
        {
            List<Item> items = new List<Item>();

            if (File.Exists(path))
            {
                List<String> itemsTypes = new List<string>();

                foreach (ItemType t in Enum.GetValues(typeof(ItemType)))
                    itemsTypes.Add(t.ToString());

                var json = System.IO.File.ReadAllText(path);
                Dictionary<string, object> jsonItems = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);


                for (int count = 0; count < jsonItems.Count; count++)
                {
                    Dictionary<string, object> jsonItem = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonItems[jsonItems.Keys.ToList()[count]].ToString());

                    ItemType type;
                    if (Enum.TryParse(jsonItem["type"].ToString(), out type) && jsonItem.ContainsKey("effects") && jsonItem["effects"] != null)
                    {
                        String sEffects = jsonItem["effects"].ToString();

                        sEffects = sEffects.Replace("[", "").Replace("]", "").Replace(" ", "").Replace("\r\n", "").Replace("\"", "");

                        String[] tabEffects = sEffects.Split(',');

                        Item item = new Item();
                        item.Name = jsonItem["name"].ToString();
                        item.Level = Int32.Parse(jsonItem["level"].ToString());

                        for (int iEffect = 0; iEffect < tabEffects.Length; iEffect += 2)
                        {
                            Stat s = JsonToStat(tabEffects[iEffect]);
                            if (s != Stat.Unknown)
                            {
                                if (s == Stat.Puissance && item.MaxStats.ContainsKey(Stat.Puissance))
                                    s = Stat.Puissance_Piege;

                                if (! item.MaxStats.ContainsKey(s))
                                    item.MaxStats.Add(s, Int32.Parse(tabEffects[iEffect + 1]));
                            }
                            else if (tabEffects[iEffect].Contains("Renvoie"))
                            {
                                // Cas spécial rattrapage de décallage pour le renvoi dommage
                                s = Stat.Renvoi_Dommage;
                                item.MaxStats.Add(s, Int32.Parse(tabEffects[iEffect].Replace("Renvoie", "").Replace("dommages", "").Split('à')[1]));
                                iEffect -= 1;
                            }
                        }

                        items.Add(item);

                    }
                }
            }
            
            return items;
        }

        private static Stat JsonToStat(String val)
        {
            Stat res = Stat.Unknown;

            switch (val)
                {
                case "agi": res = Stat.Agilite; break;
                case "cha": res = Stat.Chance; break;
                case "cri": res = Stat.Critique; break;
                case "do": res = Stat.Dommage; break;
                case "do_air": res = Stat.Dommage_Air; break;
                case "do_cri": res = Stat.Dommage_Critique; break;
                case "do_eau": res = Stat.Dommage_Eau; break;
                case "do_feu": res = Stat.Dommage_Feu; break;
                case "do_neutre": res = Stat.Dommage_Neutre; break;
                case "do_pou": res = Stat.Dommage_Pousee; break;
                case "do_terre": res = Stat.Dommage_Terre; break;
                case "fo": res = Stat.Force; break;
                case "fui": res = Stat.Fuite; break;
                case "ga_pa": res = Stat.PA; break;
                case "ga_pme": res = Stat.PM; break;
                case "ine": res = Stat.Intelligence; break;
                case "ini": res = Stat.Initiative; break;
                case "invo": res = Stat.Invocation; break;
                case "pi": res = Stat.Dommage_Piege; break;
                case "po": res = Stat.Portee; break;
                case "pod": res = Stat.Pods; break;
                case "prospe": res = Stat.Prospection; break;
                case "pui": res = Stat.Puissance; break;
                case "re_air": res = Stat.Resistance_Air_Fixe; break;
                case "re_cri": res = Stat.Resistance_Critique_Fixe; break;
                case "re_eau": res = Stat.Resistance_Eau_Fixe; break;
                case "re_feu": res = Stat.Resistance_Feu_Fixe; break;
                case "re_neutre": res = Stat.Resistance_Neutre_Fixe; break;
                case "re_pa": res = Stat.Esquive_PA; break;
                case "re_per_air": res = Stat.Resistance_Air_Pourcent; break;
                case "re_per_eau": res = Stat.Resistance_Eau_Pourcent; break;
                case "re_per_feu": res = Stat.Resistance_Feu_Pourcent; break;
                case "re_per_neutre": res = Stat.Resistance_Neutre_Pourcent; break;
                case "re_per_terre": res = Stat.Resistance_Terre_Pourcent; break;
                case "re_pme": res = Stat.Esquive_PM; break;
                case "re_pou": res = Stat.Resistance_Poussee_Fixe; break;
                case "re_terre": res = Stat.Resistance_Terre_Fixe; break;
                case "ret_pa": res = Stat.Retrait_PA; break;
                case "ret_pme": res = Stat.Retrait_PM; break;
                case "sa": res = Stat.Sagesse; break;
                case "so": res = Stat.Soin; break;
                case "tac": res = Stat.Tacle; break;
                case "vi": res = Stat.Vitalite; break;
            }

            return res;
        }
    }
}
