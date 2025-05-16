using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsapoKristof_LegyenOnIsMilliomos
{
    public class Sorkerdes
    {
        public string Szoveg { get; set; }
        public List<string> Elemei { get; set; }
        public string HelyesSorrend { get; set; }
        public string Kategoria { get; set; }

        public Sorkerdes(string szoveg, List<string> elemei, string helyesSorrend, string kategoria)
        {
            Szoveg = szoveg;
            Elemei = elemei;
            HelyesSorrend = helyesSorrend;
            Kategoria = kategoria;
        }
    }
}

