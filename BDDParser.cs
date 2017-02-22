using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        Force,
        Sagesse
    }

    class BDDParser
    {


        public class Item
        {
            string ppName;
            int ppLevel;
            Dictionary<Stat, int> ppMaxStats;
            ItemType ppType;
        }

        public BDDParser()
        {

        }

        public static void Parse(String path)
        {
            if (File.Exists(path))
            {
                List<String> itemsTypes = new List<string>();

                foreach (ItemType t in Enum.GetValues(typeof(ItemType)))
                    itemsTypes.Add(t.ToString());

                var json = System.IO.File.ReadAllText(path);
                Dictionary<string, object> items = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);


                for (int count = 0; count < items.Count; count++)
                {
                    Dictionary<string, object> item = JsonConvert.DeserializeObject<Dictionary<string, object>>(items[items.Keys.ToList()[count]].ToString());

                    ItemType type;
                    if (Enum.TryParse(item["type"].ToString(), out type))
                    {
                        String nom = item["name"].ToString();
                        int level = Int32.Parse(item["level"].ToString());
                    }
                }
            }
        }
    }
}
