using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący ciąg n (1<=n<=1000) liczb całkowitych (dodatnich i ujemnych) i 
 * wypisujący wczytane liczby na ekranie. */

namespace F.Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab;    
            int i, n;   

            //wczytanie n (1<=n<=1000)
            do
            {
                Console.Write("Podaj ilość elementów tablicy 1<=n<=1000: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0 || n > 1000);


            tab = new int[n];

            //wczytanie n elementów do tablicy tab
            for (i = 0; i < n; i++)
            {
                Console.Write($"Podaj tab[{i}]=");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Elementy tablicy: ");
            foreach (int elem in tab) Console.Write($"{elem}, ");

            Console.ReadKey(true);
        }
    }
}
