using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program obliczający wartość n! (n silnia, n!=1*2*…*n) dla wczytanej z klawiatury
 * liczby naturalnej n. Użyj pętli while. Np.: dla n=5 wypisz wynik 5!=120. */

namespace D.Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            long silnia = 1; // ten typ danych pozwoli na obliczanie silni nie większych niż silnia z 20


            do
            {
                Console.Write("Podaj liczbę naturalną n (1-20): ");
                if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 20)
                {
                    Console.WriteLine("Liczba spoza podanego zakresu. Podaj liczbę od 1 do 20.");
                }
            } while (n < 1 || n > 20);

            int i = 1;                  // inicjalizacja silni wartością 1
            Console.Write($"{n}! = ");

            while (i <= n)    // pętla wymnoży kolejne liczby dopóki nie zrównają się z wartością podaną przez użytkownika (n)
            {
                silnia *= i;
                Console.Write(i);
                if (i < n)
                    Console.Write(" * ");
                i++;
            }
            Console.WriteLine($" = {silnia}");

            Console.ReadKey(true);
        }
    }
}
