using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnlulerUnsuzler.Classes
{
    class Unluler
    {
        
        string[] unluler = { "a", "e", "ı", "i", "o", "ö", "u", "ü" };

        public string Unler(string kelime)
        {
            string unlu = "";
            for (int i = 0; i <= kelime.Length-1; i++)
            {
                if (unluler.Contains(kelime[i].ToString()))
                {
                    if (!unlu.Contains(kelime[i].ToString()))
                    {
                        unlu = unlu + "  " + kelime[i];
                    }
                    
                }
            }
            return unlu;
        }
        public string Unsuzler(string kelime)
        {
            string unsuz = "";
            for (int i = 0; i <= kelime.Length - 1; i++)
            {
                if (!(unluler.Contains(kelime[i].ToString())))
                {
                    if (!unsuz.Contains(kelime[i].ToString()))
                    {
                        unsuz = unsuz + "  " + kelime[i]; ;
                    }
                    
                }
            }
            return unsuz;
        }

    }
}
