using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Wczytaj liczbę naturalną n>1 i wypisz wszystkie liczby pierwsze z przedziału [1,n].

namespace E.Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Podaj liczbę naturalną n > 1: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 1)
                {
                    Console.WriteLine("Błąd! Liczba musi być większa od 1.");
                }
            } while (n <= 1);

            Console.WriteLine($"\nLiczby pierwsze z przedziału [1,{n}]:");

            // pętla bierze każdą lizbę z przedziału [1,n] && n > 1
            for (int i = 2; i <= n; i++)
            {
                bool jestPierwsza = true;

                // Sprawdzanie czy liczba jest pierwsza
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        jestPierwsza = false;
                        break;
                    }
                }

                if (jestPierwsza)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.ReadKey();
        }
    }
}
