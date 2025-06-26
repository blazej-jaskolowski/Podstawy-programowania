using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
   największej z tych liczb. */

namespace B.Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, min, max;
            Console.Write("Podaj liczbę nr 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 4: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 5: ");
            e = Convert.ToDouble(Console.ReadLine());

            //szukamy liczby najmniejszej
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza.", min);

            //szukamy liczby największej
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Liczba {0} jest największa.", max);

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
