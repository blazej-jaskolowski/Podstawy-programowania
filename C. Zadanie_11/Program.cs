using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać od użytkownika. 
 * Przykładowo dla n=3 należy obliczyć sumę 1+3+5. */

namespace C.Zadanie_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0;

            Console.Write("Podaj ilość liczb nieparzystych do zsumowania (n): ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int liczba = 2 * i + 1; // generuje kolejne liczby nieparzyste: 1, 3, 5, 7...
                suma += liczba;

                // wyświetlenie procesu
                Console.Write(liczba);
                if (i < n - 1)
                    Console.Write("+");
            }

            Console.WriteLine($"={suma}");
            Console.ReadKey(true);
        }
    }
}
