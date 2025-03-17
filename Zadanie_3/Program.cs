using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, cube;
            Console.Write("Podaj x: ");
            x = Int32.Parse(Console.ReadLine());
            cube = x * x * x;
            Console.WriteLine($"Sześcian liczby wynosi: {cube}");

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
