using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWell
{
    static class Parser
    {
        public static double ParseReliquat(String message)
        {
            List<String> split = message.Split(',').ToList();

            double wellValue = 0;

            foreach (String s in split)
            {
                String stat = s.Trim();
                RuneType rune = IdentifyRune(stat);
                Int32 val = ExtractNumber(stat);

                if (rune != null)
                {
                    wellValue -= rune.UnitWeight * val;
                }
            }

            return wellValue;
        }

        public static RuneType IdentifyRune(String msg)
        {
            List<RuneType> runes = RunesTypes.GetRuneTypes();

            RuneType ret = runes.Find(r => msg.ToUpper().Contains(r.Stat.GetNiceName().ToUpper()));

            return ret;
        }

        public static Int32 ExtractNumber(String msg)
        {
            Int32 size = 1, val, correctVal = 0;

            if (msg[0] == '-')
                size++;

            while(Int32.TryParse(msg.Substring(0, size), out val))
            {
                correctVal = val;
                size += 1;
            }

            return correctVal;
        }
    }
}
