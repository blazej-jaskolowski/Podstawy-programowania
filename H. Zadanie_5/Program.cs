using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Zadanie_5
{
    internal class Program
    {
        static int NWD(int a, int b)
        {
            if (b == 0) return a;
            return NWD(b, a % b);
        }

        //test
        static void Main(string[] args)
        {
            Console.Write("Podaj a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("NWD({0}, {1}) = {2}", a, b, NWD(a, b));
            Console.ReadKey(true);
        }
    }
}
