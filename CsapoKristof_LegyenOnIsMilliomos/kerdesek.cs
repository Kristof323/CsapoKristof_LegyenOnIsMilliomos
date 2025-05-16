using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsapoKristof_LegyenOnIsMilliomos
{
    namespace CsapoKristof_LegyenOnIsMilliomos
    {
        public class Kerdesek
        {
            public List<Kerdes> OsszesKerdes { get; private set; }

            public Kerdesek()
            {
                OsszesKerdes = new List<Kerdes>();
            }

            public void BetoltKerdesekFajlbol(string fajlNev)
            {
                if (!File.Exists(fajlNev))
                {
                    Console.WriteLine($"A fájl nem található: {fajlNev}");
                    return;
                }

                var sorok = File.ReadAllLines(fajlNev);
                foreach (var sor in sorok)
                {1
                    var mezok = sor.Split(';');
                    if (mezok.Length < 7)
                        continue;

                    string kerdesSzoveg = mezok[1];
                    var valaszok = new List<string> { mezok[2], mezok[3], mezok[4], mezok[5] };
                    char helyesValasz = mezok[6].ToUpper()[0];
                    string kategoria = mezok[7];

                    var ujKerdes = new Kerdes(kerdesSzoveg, valaszok, helyesValasz, kategoria);
                    OsszesKerdes.Add(ujKerdes);
                }
            }
        }
    }
}