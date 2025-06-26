using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Dana jest funkcja kwadratowa f(x)=ax^2+bx+c. Napisać program wczytujący współczynniki funkcji 
 * kwadratowej (a, b, c) i wypisujący na ekranie jej miejsca zerowe lub informację o ich braku. */

namespace B.Zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.Write("Podaj współczynnik a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik c: ");
            c = Convert.ToDouble(Console.ReadLine());

            // Sprawdzenie czy to funkcja kwadratowa (a ≠ 0)
            if (a == 0)
            {
                Console.WriteLine("To nie jest funkcja kwadratowa!");
            }
            else
            {
                // Obliczenie delty
                delta = (b * b) - (4 * a * c);

                // Sprawdzenie przypadków delty
                if (delta > 0)
                {
                    // Dwa miejsca zerowe
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Funkcja ma dwa miejsca zerowe:");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else if (delta == 0)
                {
                    // Jedno miejsce zerowe
                    x1 = -b / (2 * a);
                    Console.WriteLine("Funkcja ma jedno miejsce zerowe:");
                    Console.WriteLine("x0 = {0}", x1);
                }
                else
                {
                    // Brak miejsc zerowych
                    Console.WriteLine("Funkcja nie ma miejsc zerowych");
                }
            }

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
