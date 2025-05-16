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
            string fajlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "kerdes.txt");
            kerdesek.BetoltKerdesekFajlbol(fajlPath);


            var randomKerdes = kerdesek.GetRandomKerdes("BIOLÓGIA");
            if (randomKerdes != null)
            {
                Console.WriteLine(randomKerdes.Szoveg);
                char valaszBetuje = 'A';
                foreach (var valasz in randomKerdes.Valaszok)
                {
                    Console.WriteLine($"{valaszBetuje}: {valasz}");
                    valaszBetuje++;
                }
            }
            else
            {
                Console.WriteLine("Nincs kérdés ebben a kategóriában.");
            }
        }
    }
}
