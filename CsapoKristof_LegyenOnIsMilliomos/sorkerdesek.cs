using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsapoKristof_LegyenOnIsMilliomos
{
    public class Sorkerdesek
    {
        public List<Sorkerdes> Lista { get; private set; }
        private Random rnd;

        public Sorkerdesek()
        {
            Lista = new List<Sorkerdes>();
            rnd = new Random();
        }

        public void BetoltFajlbol(string fajlNev)
        {
            if (!File.Exists(fajlNev))
            {
                Console.WriteLine("A sorkérdés fájl nem található!");
                return;
            }

            var sorok = File.ReadAllLines(fajlNev);
            foreach (var sor in sorok)
            {
                var mezok = sor.Split(';');
                if (mezok.Length < 7) continue;

                string szoveg = mezok[0];
                var elemek = new List<string> { mezok[1], mezok[2], mezok[3], mezok[4] };
                string sorrend = mezok[5];
                string kategoria = mezok[6];

                Lista.Add(new Sorkerdes(szoveg, elemek, sorrend, kategoria));
            }
        }

        public Sorkerdes GetRandom()
        {
            if (Lista.Count == 0) return null;
            return Lista[rnd.Next(Lista.Count)];
        }
    }
}