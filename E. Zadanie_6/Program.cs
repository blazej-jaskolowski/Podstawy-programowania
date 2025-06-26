using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Wczytaj liczbę naturalną n>0 i oblicz 1^1 + 2^2 + 3^3 + 4^4 + ⋯ + n^n. 
 * Nie można używać funkcji matematycznych. */

namespace E.Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            long suma = 0;

            do
            {
                Console.Write("Podaj liczbę naturalną n > 0: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Błąd! Liczba musi być większa od 0.");
                }
            } while (n <= 0);

            Console.Write($"\nObliczanie sumy: ");

            // suma potęg
            for (int i = 1; i <= n; i++)
            {
                long potega = 1;
                // i do potęgi i
                for (int j = 1; j <= i; j++)
                {
                    potega *= i;
                }

                suma += potega;

                Console.Write($"{i}^{i}");
                if (i < n) Console.Write(" + ");
            }

            Console.WriteLine($" = {suma}");
            Console.ReadKey(true);
        }
    }
}
