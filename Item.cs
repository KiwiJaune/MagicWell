using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWell
{
    public class Item
    {
        string ppName;
        int ppLevel;
        Dictionary<Stat, int> ppMaxStats;
        ItemType ppType;

        public Item()
        {
            ppName = "";
            ppLevel = 0;
            ppMaxStats = new Dictionary<Stat, int>();
            ppType = ItemType.Amulette;
        }

        public string Name
        {
            get
            {
                return ppName;
            }

            set
            {
                ppName = value;
            }
        }

        public int Level
        {
            get
            {
                return ppLevel;
            }

            set
            {
                ppLevel = value;
            }
        }

        public Dictionary<Stat, int> MaxStats
        {
            get
            {
                return ppMaxStats;
            }

            set
            {
                ppMaxStats = value;
            }
        }

        public ItemType Type
        {
            get
            {
                return ppType;
            }

            set
            {
                ppType = value;
            }
        }

        public override string ToString()
        {
            return ppName;
        }
    }
}
