using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program drukujący na ekranie kolejne liczby naturalne podzielne przez 7. 
 * Ilość liczb wczytaj z klawiatury. Użyj pętli for. Oto wydruk dla ile=6:
 * 0, 7, 14, 21, 28, 35 */

namespace C.Zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile;
            Console.Write("Podaj ile liczb podzielnych przez 7 chcesz wyświetlić: ");
            ile = Convert.ToInt32(Console.ReadLine());

            int liczba = 0;
            for (int i = 0; i < ile; i++)
            {
                Console.Write(liczba);
                if (i < ile - 1)
                    Console.Write(", ");
                liczba += 7;
            }

            Console.ReadKey(true);
        }
    }
}
