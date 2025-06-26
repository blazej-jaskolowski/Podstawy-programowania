using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program obliczający sumę cyfr dla wczytanej z klawiatury liczby naturalnej. 
 * Użyj pętli while. Np.: Dla liczby=1342 trzeba obliczyć sumę 1+3+4+2. */

namespace D.Zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba, suma = 0;

            Console.Write("Podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            int orgLiczba = liczba;

            while (liczba > 0)
            {
                suma += liczba % 10;    // pobranie i dodanie cyfry do sumy
                liczba = liczba / 10;   // usunięcie cyfry z liczby 
            }

            Console.WriteLine($"Suma cyfr liczby {orgLiczba} wynosi: {suma}");
            Console.ReadKey(true);
        }
    }
}