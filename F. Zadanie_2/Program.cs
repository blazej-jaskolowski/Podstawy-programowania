using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący 
 * wczytane liczby w odwrotnej kolejności na ekranie. */

namespace F.Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; //tablica 1000 liczb typu int
            int i, n; //i-licznik pętli, n ilość elementów tablicy

            //wczytuje n
            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            //wczytuje n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write($"Podaj tab[{i}]=");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            //wyświetlam elementy tablicy na ekranie
            Console.Write("Elementy tablicy: ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write($"{tab[i]}, ");
            }
            Console.ReadKey(true); //pauza
        }
    }
}
