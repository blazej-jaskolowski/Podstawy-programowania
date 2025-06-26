using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz 
   tych liczb z uwzględnieniem części całkowitej i reszty z dzielenia.*/

namespace Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}/{1}={2} r{3}", a, b, a / b, a % b);

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
