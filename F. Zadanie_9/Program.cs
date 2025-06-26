using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący 
 * na ekranie sumę kwadratów wczytanych liczb. */

namespace F.Zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i; 
            int n; 
            long sumaKwadratow = 0;


            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            // wczytywanie n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write($"Podaj tab[{i}]=");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            // suma kwadratów
            Console.Write("Kwadraty liczb: ");
            for (i = 0; i < n; i++)
            {
                long kwadrat = tab[i] * tab[i];
                sumaKwadratow += kwadrat;

                // kwadraty
                Console.Write($"{tab[i]}^2");
                if (i < n - 1)
                    Console.Write(" + ");
            }

            // wynik
            Console.WriteLine($" = {sumaKwadratow}");
            Console.ReadKey(true);
        }
    }
}
