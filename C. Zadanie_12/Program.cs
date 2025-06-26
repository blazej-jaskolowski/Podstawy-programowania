using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for.
 * Oto wydruk dla wysokości h=6:
 *  1
 *  2 4
 *  3 6 9
 *  4 8 12 16
 *  5 10 15 20 25
 *  6 12 18 24 30 36 */

namespace C.Zadanie_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wysokosc;
            Console.Write("Podaj wysokość trójkąta: ");
            wysokosc = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= wysokosc; i++) // wiersze
            {
                for (int j = 1; j <= i; j++) // kolumny
                {
                    Console.Write("{0,4}", i * j); // odstęp
                }
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
