using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to 
 * liczba parzysta, czy też nieparzysta. */

namespace B.Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("liczba {0} jest parzysta.", a);
            else
                Console.WriteLine("liczba {0} jest nieparzysta.", a);

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
