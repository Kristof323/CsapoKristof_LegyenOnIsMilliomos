using CsapoKristof_LegyenOnIsMilliomos;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsapoKristof_LegyenOnIsMilliomos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kerdesek = new Kerdesek();
            string kerdesFajlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "kerdes.txt");
            kerdesek.BetoltKerdesekFajlbol(kerdesFajlPath);

            var sorkerdesek = new Sorkerdesek();
            string sorkerdesFajlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sorkerdes.txt");
            sorkerdesek.BetoltFajlbol(sorkerdesFajlPath);

            Console.WriteLine("Üdvözlünk a Legyen Ön is Milliomos játékban!");
            Console.WriteLine("Kezdésként válaszolj egy sorkérdésre, hogy elindulhass a fődíj felé!\n");

            var sorkerdes = sorkerdesek.GetRandom();

            if (sorkerdes == null)
            {
                Console.WriteLine("Nem található sorkérdés.");
                return;
            }

            Console.WriteLine(sorkerdes.Szoveg);
            for (int i = 0; i < sorkerdes.Elemei.Count; i++)
            {
                Console.WriteLine($"{(char)('A' + i)}. {sorkerdes.Elemei[i]}");
            }

            Console.Write("\nAdd meg a helyes sorrendet (pl. ACBD): ");
            string valasz = Console.ReadLine()?.ToUpper();

            if (valasz != sorkerdes.HelyesSorrend)
            {
                Console.WriteLine("Helytelen sorrend. Nem indul a játék.");
                return;
            }

            Console.WriteLine("\nHelyes válasz! Kezdődik a játék!\n");

            Console.Write("Válassz egy kategóriát (pl. BIOLÓGIA, TÖRTÉNELEM, ZENE...): ");
            string kategoria = Console.ReadLine()?.ToUpper();

            var randomKerdes = kerdesek.GetRandomKerdes(kategoria);
            if (randomKerdes != null)
            {
                Console.WriteLine("\n" + randomKerdes.Szoveg);
                char valaszBetuje = 'A';
                foreach (var valaszLehetoseg in randomKerdes.Valaszok)
                {
                    Console.WriteLine($"{valaszBetuje}: {valaszLehetoseg}");
                    valaszBetuje++;
                }

                Console.Write("\nMi a válaszod (A, B, C vagy D)? ");
                char felhasznaloValasz = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (felhasznaloValasz == randomKerdes.HelyesValasz)
                {
                    Console.WriteLine("Helyes válasz! Gratulálok!");
                }
                else
                {
                    Console.WriteLine($"Sajnos rossz válasz. A helyes válasz: {randomKerdes.HelyesValasz}");
                }
            }
            else
            {
                Console.WriteLine("Ebben a kategóriában nincs kérdés.");
            }
        }
    }
}
