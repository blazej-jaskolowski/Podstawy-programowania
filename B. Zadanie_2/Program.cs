using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, 
 * ujemna, czy też równa zero. */

namespace B.Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba {0} jest dodatnia.", a);
            else if (a < 0)
                Console.WriteLine("Liczba {0} jest ujemna.", a);
            else
                Console.WriteLine("Liczba {0} jest równa zero.", a);

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
