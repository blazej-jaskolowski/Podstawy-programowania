using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym.

namespace F.Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; //tablica 1000 liczb typu int
            int i = 0, j, liczba;

            //wczytuje liczbę naturalną
            Console.Write("Podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            //zapisuję do tablicy reszty z dzielenia przez 2
            while ((liczba / 2 != 0) || ((liczba / 2 == 0) && (liczba % 2 != 0)))
            {
                tab[i++] = liczba % 2;
                liczba /= 2;
            }

            //wypisuje elementy tablicy w odwrotnej kolejności
            for (j = i - 1; j >= 0; j--) Console.Write(tab[j]);
            Console.ReadKey(true);
        }
    }
}
