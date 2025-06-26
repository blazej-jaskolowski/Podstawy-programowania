using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program wypisujący na ekranie tekst "Witaj Świecie".

namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj świecie");
            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
