using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba1, liczba2;

            // Wczytanie liczba1 
            Console.Write("Podaj pierwszą liczbę całkowitą: ");
            while (!int.TryParse(Console.ReadLine(), out liczba1))
            {
                Console.Write("Błędne dane! Podaj liczbę całkowitą: ");
            }

            // Wczytanie liczba2
            Console.Write("Podaj drugą liczbę całkowitą: ");
            while (!int.TryParse(Console.ReadLine(), out liczba2))
            {
                Console.Write("Błędne dane! Podaj liczbę całkowitą: ");
            }

            // Sumy kwadratów
            int sumaKwadratow = (liczba1 * liczba1) + (liczba2 * liczba2);

            // Wynik + obliczenia
            Console.WriteLine($"Suma kwadratów liczb {liczba1} i {liczba2} wynosi: {sumaKwadratow}");
            Console.WriteLine($"{liczba1}² + {liczba2}² = {liczba1 * liczba1} + {liczba2 * liczba2} = {sumaKwadratow}");

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
