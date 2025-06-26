using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i iloraz.

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, suma, roznica, iloczyn, iloraz;
            Console.Write("Podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());

            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            
            Console.WriteLine("{0}+{1}={2}", a, b, suma);
            Console.WriteLine("{0}-{1}={2}", a, b, roznica);
            Console.WriteLine("{0}*{1}={2}", a, b, iloczyn);

            if (b!=0)
            {
                iloraz = a / b;
                Console.WriteLine("{0}/{1}={2}", a, b, iloraz);
            }

            else
            {
                Console.WriteLine("Nie można dzielić przez zero!");
            }

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { } //pauza
        }
    }
}
