using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich. 
 * Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta, 
 * dla 2 – pola kwadratu, a dla 3 – pola trójkąta. Program powinien pytać użytkownika, 
 * które pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0 (zero). */

namespace D.Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double a, b;
            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - oblicz pole prostokąta");
                Console.WriteLine("2 - oblicz pole kwadratu");
                Console.WriteLine("3 - oblicz pole trójkąta");
                Console.WriteLine("0 - koniec");
                Console.Write("Twój wybór: ");
                wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Podaj długość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość boku b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole prostokąta wynosi = {0}", a * b);
                        break;
                    case 2:
                        Console.Write("Podaj długość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole kwadratu wynosi = {0}", a * a);
                        break;
                    case 3:
                        Console.Write("Podaj długość podstawy a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość wysokości h = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole trójkąta wynosi = {0}", a * b / 2.0);
                        break;
                    default:
                        Console.WriteLine("Błąd: Nieznany wybór!");
                        break;
                }
            } while (wybor != 0);
        }
    }
}
