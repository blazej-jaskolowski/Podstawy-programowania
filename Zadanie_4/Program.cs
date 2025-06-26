using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Podaj długość prostokąta (cm): ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Podaj szerokość prostokąta: (cm): ");
            y = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Pole prostokąta wynosi: {x*y}cm^2");
            Console.WriteLine($"Obwód prostokąta wynosi: {2*x+2*y}cm");

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
