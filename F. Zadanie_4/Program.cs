using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie sumę wczytanych liczb.*/

namespace F.Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; //tablica 1000 liczb typu int
            int i; //i - licznik pętli
            int n, suma; //n-ilość elementów tablicy, suma-suma elem tab

            //wczytuje n
            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            //wczytuje n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write($"Podaj tab[{i}]=");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            //obliczamy sumę wczytanych elementów
            suma = 0;
            for (i = 0; i < n; i++) suma += tab[i];

            //wypisujemy wynik
            Console.WriteLine($"Suma elementów tablicy wynosi {suma}.");
            Console.ReadKey(true);
        }
    }
}
