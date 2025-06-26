using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący wartość liczby naturalnej n (n>=0), obliczający wartość 2^n (2 do potęgi n) 
 * i wypisujący wynik na ekranie w formacie (np. dla n=10) : 2^10=1024. */

namespace C.Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, wynik = 1, n;
            Console.Write("Podaj liczbę naturalną n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                wynik *= 2;
            Console.WriteLine("2^{0}={1}", n, wynik);
            Console.ReadKey(true);
        }
    }
}
