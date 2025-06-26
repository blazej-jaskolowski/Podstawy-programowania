using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący 
 * na ekranie informację ile liczb jest dodatnich, ujemnych i równych zero.*/

namespace F.Zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i;
            int n;
            int dodatnie = 0, ujemne = 0, zero = 0; //liczniki wystąpień


            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write($"Podaj tab[{i}]=");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            //zliczanie liczb dodatnich, ujemnych i zer
            for (i = 0; i < n; i++)
            {
                if (tab[i] > 0)
                    dodatnie++;
                else if (tab[i] < 0)
                    ujemne++;
                else
                    zero++;
            }

            Console.WriteLine("\nStatystyki:");
            Console.WriteLine($"Liczb dodatnich: {dodatnie}");
            Console.WriteLine($"Liczb ujemnych: {ujemne}");
            Console.WriteLine($"Zer: {zero}");

            Console.ReadKey(true);
        }
    }
}
