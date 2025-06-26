using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Dany jest ciąg rekurencyjny: a1 = 1, an+1 = (an)^2 - 3
 * Wczytaj od użytkownika liczbę całkowitą n i wypisz na ekranie wartość ciągu an. */

namespace H.Zadanie_4
{
    internal class Program
    {
        static long ciag(int n)
        {
            if (n == 1) return 1;  //a1 = 1
            return ciag(n - 1) * ciag(n - 1) - 3;  //an+1 = (an)^2 - 3
        }

        //test
        static void Main(string[] args)
        {
            Console.Write("Podaj numer wyrazu ciągu n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a{0} = {1}", n, ciag(n));
            Console.ReadKey(true);
        }
        
    }
}
