using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Zaimplementuj funkcję rekurencyjną zadaną wzorem:
n dla n < 1
f(n) = 1 dla n = 1
2 ∗ f(n - 1) + 1 dla n > 1
Napisz program testowy pobierający od użytkownika wartość liczby całkowitej n i wypisujący
na ekranie wartość funkcji f(n). */

namespace H.Zadanie_3
{
    internal class Program
    {
        static int f(int n)
        {
            if (n < 1) return n;
            if (n == 1) return 1;
            return 2 * f(n - 1) + 1;
        }

        //test
        static void Main(string[] args)
        {
            Console.Write("Podaj n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("f({0}) = {1}", n, f(n));

            //f(3)
            Console.WriteLine("f(3) = {0}", f(3));

            //f(f(3))
            Console.WriteLine("f(f(3)) = {0}", f(f(3)));

            Console.ReadKey(true);
        }
    }
}
