using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisać program sumujący kolejne liczby całkowite podawane przez użytkownika, 
 * aż do napotkania zera. Wypisz otrzymaną sumę na ekranie. Użyj pętli do-while. */

namespace D.Zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba, suma = 0;
            string proces = "";

            Console.WriteLine("Program sumujący liczby. Aby zakończyć, wpisz 0.");

            do
            {
                Console.Write("Podaj liczbę: ");
                liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba != 0)
                {
                    if (proces == "")
                        proces = liczba.ToString();
                    else
                        proces += " + " + liczba;
                }

                suma += liczba;

            } while (liczba != 0);

            Console.WriteLine($"\nProces sumowania:");
            Console.WriteLine($"{proces} = {suma}");
            Console.ReadKey(true);
        }
    }
}
