using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsapoKristof_LegyenOnIsMilliomos
{
    public class Kerdesek
    {
        public List<Kerdes> OsszesKerdes { get; private set; }
        private Random rnd;

        public Kerdesek()
        {
            OsszesKerdes = new List<Kerdes>();
            rnd = new Random();
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
            {
                var mezok = sor.Split(';');
                if (mezok.Length < 8)
                    continue;

                string kerdesSzoveg = mezok[1];
                var valaszok = new List<string> { mezok[2], mezok[3], mezok[4], mezok[5] };
                char helyesValasz = mezok[6].ToUpper()[0];
                string kategoria = mezok[7];

                var ujKerdes = new Kerdes(kerdesSzoveg, valaszok, helyesValasz, kategoria);
                OsszesKerdes.Add(ujKerdes);
            }
        }

        public Kerdes GetRandomKerdes(string kategoria)
        {
            var kategoriaKerdesek = OsszesKerdes.FindAll(k => k.Kategoria.Equals(kategoria, StringComparison.OrdinalIgnoreCase));
            if (kategoriaKerdesek.Count == 0)
                return null;

            int index = rnd.Next(kategoriaKerdesek.Count);
            return kategoriaKerdesek[index];
        }
    }
}