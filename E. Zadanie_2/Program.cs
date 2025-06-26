using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program wczytujący współrzędne dwóch punktów A=(x1,y1) i B=(x2,y2) oraz 
 * wypisujący na ekranie wzór funkcji liniowej przechodzącej przez te dwa punkty.*/

namespace E.Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            Console.WriteLine("Program oblicza wzór funkcji liniowej f(x) = ax + b przechodzącej przez dwa punkty A i B.");

            // wczytywanie współrzędnych
            x1 = WczytajWspolrzedna("x1", "A");
            y1 = WczytajWspolrzedna("y1", "A");
            x2 = WczytajWspolrzedna("x2", "B");
            y2 = WczytajWspolrzedna("y2", "B");

            Console.WriteLine($"Punkt A = ({x1}, {y1})");
            Console.WriteLine($"Punkt B = ({x2}, {y2})");

            // sprawdzenie czy punkty nie mają tych samych x-ów
            if (x1 == x2)
            {
                Console.WriteLine("BŁĄD: Przez te punkty nie można przeprowadzić funkcji liniowej!");
                Console.WriteLine("(Punkty leżą na prostej równoległej do osi OY)");
            }
            else
            {
                // obliczanie współczynników
                double a = (y2 - y1) / (x2 - x1);
                double b = y1 - a * x1;

                // Wyświetlanie wyniku
                Console.WriteLine("Wzór funkcji liniowej:");
                Console.Write("f(x) = ");

                // współczynnik kierunkowy
                if (a == 0)
                    Console.Write("0");
                else if (a == 1)
                    Console.Write("x");
                else if (a == -1)
                    Console.Write("-x");
                else
                    Console.Write($"{a:F2}x");

                // formatowanie wyników
                if (b > 0)
                    Console.WriteLine($" + {b:F2}");
                else if (b < 0)
                    Console.WriteLine($" - {Math.Abs(b):F2}");
                else if (a == 0)
                    Console.WriteLine($"{b:F2}");
                else
                    Console.WriteLine();
            }

            Console.WriteLine("Naciśnij dowolny klawisz...");
            Console.ReadKey(true);
        }

        static double WczytajWspolrzedna(string nazwa, string punkt)
        {
            double wartosc;
            do
            {
                Console.Write($"Podaj współrzędną {nazwa} punktu {punkt}: ");
                if (!double.TryParse(Console.ReadLine(), out wartosc))
                {
                    Console.WriteLine("Błąd, podaj poprawną liczbę.");
                }
                else
                {
                    break;
                }
            } while (true);
            return wartosc;
        }
    }
}
