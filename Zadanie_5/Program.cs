using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, h, l, V, Pc;
            Console.Write("Podaj promień podstawy stożka (cm): ");
            r = Double.Parse(Console.ReadLine());
            Console.Write("Podaj wysokość stożka (cm): ");
            h = Double.Parse(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            V = 1.0 / 3 * Math.PI * r * r * h;
            Pc = Math.PI * r * (r + l);

            Console.WriteLine($"Objętość stożka wynosi {V}cm^3");
            Console.WriteLine($"Pole powierzchni całkowitej stożka wynosi {Pc}cm^2");

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
