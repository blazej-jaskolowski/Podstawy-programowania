using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata 
 * przestępne od roku_początkowego do roku_końcowego włącznie. */

namespace C.Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rok1, rok2, i;
            Console.Write("Podaj rok początkowy: ");
            rok1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj rok końcowy: ");
            rok2 = Convert.ToInt32(Console.ReadLine());

            for (i = rok1; i <= rok2; i++)
                if (((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0))
                    Console.Write("{0}, ", i);

            Console.ReadKey(true);
        }
    }
}
