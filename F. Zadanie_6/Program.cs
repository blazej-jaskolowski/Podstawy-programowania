using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli foreach. */

namespace F.Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dni = new string[] {"poniedziałek",
            "wtorek", "środa", "czwartek", "piątek",
            "sobota", "niedziela"};

            //wypisujemy elementy tablicy
            foreach (string elem in dni)
                Console.Write($"{elem}, ");

            Console.ReadKey(true);
        }
    }
}
