using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Wczytaj liczbę naturalną n>0 i oblicz n^n. Nie można używać funkcji matematycznych.

namespace E.Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            long wynik = 1;

            // podaj n
            do
            {
                Console.Write("Podaj liczbę naturalną n > 0: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Błąd! Liczba musi być większa od 0.");
                }
            } while (n <= 0);

            // obliczanie n^n poprzez mnożenie
            for (int i = 1; i <= n; i++)
            {
                wynik *= n;
            }

            Console.WriteLine($"{n} do potęgi {n} = {wynik}");
            Console.ReadKey(true);
        }
    }
}
