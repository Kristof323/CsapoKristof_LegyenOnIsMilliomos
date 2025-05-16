using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsapoKristof_LegyenOnIsMilliomos
{
    public class Kerdes
    {
        public string Szoveg { get; set; }
        public List<string> Valaszok { get; set; }
        public char HelyesValasz { get; set; }
        public string Kategoria { get; set; }

        public Kerdes(string szoveg, List<string> valaszok, char helyesValasz, string kategoria)
        {
            Szoveg = szoveg;
            Valaszok = valaszok;
            HelyesValasz = helyesValasz;
            Kategoria = kategoria;
        }
    }
}
