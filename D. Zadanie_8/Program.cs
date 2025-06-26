using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while.

namespace D.Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, dzielnik = 2;
            bool czyPierwsza = true;

            Console.Write("Podaj liczbę naturalną n: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1) //czy mniejsza od 1
            {
                Console.WriteLine($"Liczba {n} nie jest pierwsza.");
                Console.ReadKey();
                return;
            }

            while (dzielnik <= Math.Sqrt(n) && czyPierwsza)  // dzielniki od 2 do pierwiastka z n
            {
                if (n % dzielnik == 0)
                {
                    czyPierwsza = false;
                    break;                  // przerwanie pętli przed inkrementacją, bez przerwania pętli musielibyśmy
                }                           // uwzględnić to w odpowiedzi:
                dzielnik++;                 // Console.WriteLine($"Liczba {n} nie jest pierwsza (dzieli się przez {dzielnik - 1}).");
            }

            if (czyPierwsza)
                Console.WriteLine($"Liczba {n} jest pierwsza.");
            else
                Console.WriteLine($"Liczba {n} nie jest pierwsza (dzieli się przez {dzielnik}).");

            Console.ReadKey(true);
        }
    }
}
