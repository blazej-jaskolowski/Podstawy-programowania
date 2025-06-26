using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Spośród liczb od 1 do 100 wypisz na ekranie wszystkie liczby podzielne przez 13.

namespace C.Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)         // Wydajniejsze rozwiązanie:
        {
            int i;                              // int i;
            for (i = 13; i <= 100; i += 13)     // for (i = 13; i <= 100; i+ = 13)
                                                // Console.Write("{0}, ", i);
                Console.Write("{0}, ", i);       
            
            Console.ReadKey(true);
        }
    }
}
