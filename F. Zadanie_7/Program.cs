using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie najmniejszą i największą wczytaną liczbę.*/

namespace F.Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; 
            int i; 
            int n, min, max; 

            //wczytywanie n
            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            //wczytywanie n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write($"Podaj tab[{i}]=");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            //znajdujemy wartość najmniejszą i największą
            min = tab[0]; //zakładamy że pierwszy element jest min i max
            max = tab[0];
            for (i = 1; i < n; i++)
            {
                if (tab[i] < min) min = tab[i];
                if (tab[i] > max) max = tab[i];
            }

            //wynik
            Console.WriteLine($"Najmniejsza liczba: {min}");
            Console.WriteLine($"Największa liczba: {max}");
            Console.ReadKey(true);
        }
    }
}
