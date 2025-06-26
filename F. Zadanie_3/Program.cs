using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, 
 * sortujący je niemalejąco i wypisujący posortowane liczby na ekranie.*/

namespace F.Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; //tablica 1000 liczb typu int
            int i, j; //i-licznik pętli
            int n, tmp; //n-ilość elementów tablicy, tmp-zmienna pomocnicza

            //wczytuje n
            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            //wczytuje n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write($"Podaj tab[{i}]=");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            //sortujemy elementy tablicy
            for (i = 0; i < n; i++)
                for (j = i + 1; j < n; j++)
                    if (tab[i] > tab[j]) //zamiana kolejności elem tab
                    {
                        tmp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = tmp;
                    }

            //wyświetlam elementy tablicy na ekranie
            Console.Write("Elementy tablicy: ");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{tab[i]}, ");
            }
            Console.ReadKey(true);
        }
    }
}
