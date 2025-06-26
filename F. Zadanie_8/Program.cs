using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący ciąg n (1<=n<=1000) liczb naturalnych i wypisujący na ekranie 
 * wszystkie parzyste liczby w kolejności niemalejącej. Do wypisywania elementów tablicy użyj pętli foreach.
 * Wskazówka: Posortuj wczytane liczby, a następnie z tablicy wypisz tylko liczby parzyste.*/

namespace F.Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; 
            int i, j;
            int n, tmp; 

            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            //wczytanie n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write($"Podaj tab[{i}]=");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            //sortowanie
            for (i = 0; i < n; i++)
                for (j = i + 1; j < n; j++)
                    if (tab[i] > tab[j]) //zamiana kolejności elem tab
                    {
                        tmp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = tmp;
                    }


            Console.Write("Liczby parzyste: ");
            foreach (int elem in tab)
            {
                if (elem % 2 == 0) // parzystość
                    Console.Write($"{elem}, ");
            }

            Console.ReadKey(true);
        }
    }
}
