using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Wczytaj liczbę naturalną n (n>4). Narysuj na ekranie ze znaków X kontur trójkąta prostokątnego jak na 
 * poniższym przykładzie. Użyj pętli for. Dla n=5 powinien zostać narysowany trójkąt:
 *       X
 *      XX
 *     X X
 *    X  X
 *   XXXXX */

namespace C.Zadanie_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            for (n = 0; n <= 4;)   // zamknięty obieg programu
            {
                Console.Write("Podaj liczbę naturalną n (n>4): ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 4)
                {
                    Console.WriteLine("Niepoprawna liczba. Liczba musi być większa od 4.");
                }
            }

            // wierzchołek
            for (int i = 1; i <= n - 1; i++)
                Console.Write(" ");
            Console.WriteLine("X");

            // środek trójkąta
            for (int i = 2; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)    // spacje przed pierwszym X
                    Console.Write(" ");

                Console.Write("X");

                for (int j = 1; j <= i - 2; j++)    // spacje między 'X'ami
                    Console.Write(" ");

                Console.WriteLine("X");
            }

            // podstawa
            for (int i = 1; i <= n; i++)
                Console.Write("X");

            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
