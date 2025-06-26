using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie szesnastkowym. 
 * Wskazówka: 10-A, 11-B, 12-C, 13-D, 14-E, 15-F.*/

namespace F.Zadanie_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i = 0;
            int liczba;
            char[] hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' }; //znaki hex

 
            Console.Write("Podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            while (liczba > 0)
            {
                tab[i] = liczba % 16; // reszty z dzielenia
                liczba = liczba / 16;
                i++;
            }

            Console.Write("Liczba w systemie szesnastkowym: ");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(hex[tab[j]]);
            }

            Console.ReadKey(true);
        }
    }
}
