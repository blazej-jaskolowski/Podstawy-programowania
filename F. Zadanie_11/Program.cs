using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie ósemkowym.

namespace F.Zadanie_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i = 0;
            int liczba;

            Console.Write("Podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            while (liczba > 0)
            {
                tab[i] = liczba % 8;
                liczba = liczba / 8;
                i++;
            }

            Console.Write("Liczba w systemie ósemkowym: ");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(tab[j]);
            }

            Console.ReadKey(true);
        }
    }
}
