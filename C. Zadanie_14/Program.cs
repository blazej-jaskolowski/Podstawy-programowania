using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program znajdujący wszystkie trójki liczb pitagorejskich z zadanego przedziału.
 * Np.: dla przedziału [3,5] mamy jedną trójkę: 3, 4, 5 (bo 3^2+4^2=5^2).*/

namespace C.Zadanie_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poczatek, koniec;
            bool brakTrojek = false;

            // Wczytanie zakresu
            Console.Write("Podaj początek przedziału: ");
            poczatek = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj koniec przedziału: ");
            koniec = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTrójki pitagorejskie w przedziale [{0},{1}]:", poczatek, koniec);

            // Sprawdzanie wszystkich możliwych kombinacji liczb
            for (int a = poczatek; a <= koniec; a++)
            {
                for (int b = a; b <= koniec; b++)
                {
                    for (int c = b; c <= koniec; c++)
                    {
                        // Sprawdzenie czy to trójka pitagorejska
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine($"{a}, {b}, {c} \t(bo {a}^2 + {b}^2 = {c}^2)");
                            brakTrojek = true;
                        }
                    }
                }
            }

            if (!brakTrojek)
            {
                Console.WriteLine("W podanym przedziale nie ma żadnej trójki pitagorejskiej.");
            }

            Console.ReadKey(true);
        }
    }
}
