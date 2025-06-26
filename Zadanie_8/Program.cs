using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący numer wyrazu ciągu (n) i wypisujący na ekranie jego wartość.
   Ciąg arytmetyczny: a(n)=3n-1 */

namespace Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Podaj numer wyrazu ciągu (n): ");
            n = Convert.ToInt32(Console.ReadLine());

            int wyraz = 3 * n - 1;

            Console.WriteLine($"{n}-ty wyraz ciągu a(n)=3n-1 wynosi: {wyraz}");

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

        }
    }
}
