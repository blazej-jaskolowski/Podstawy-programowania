using B.Zadanie_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy da się z tych 
 * odcinków zbudować trójkąt, czy też nie. */

namespace B.Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Podaj długość pierwszego odcinka: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj długość drugiego odcinka: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj długość trzeciego odcinka: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Z podanych odcinków można zbudować trójkąt.");
            }
            else
            {
                Console.WriteLine("Z podanych odcinków nie można zbudować trójkąta.");
            }

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
