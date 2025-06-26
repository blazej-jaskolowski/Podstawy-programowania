using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Dany jest trójkąt o współrzędnych A=(-4,-4), B=(4,-2), C=(6,6). Wczytaj od użytkownika współrzędne punktu P=(x,y). 
 * Wypisz na ekranie informację czy punkt P leży wewnątrz, na zewnątrz, czy też na boku trójkąta ABC.*/

namespace E.Zdanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // współrzędne trójkąta ABC
            double xA = -4, yA = -4;
            double xB = 4, yB = -2;
            double xC = 6, yC = 6;

            // współrzędne punktu P
            Console.WriteLine("Podaj współrzędne punktu P:");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            // położenie punktu względem prostych
            double AB = PolozeniePunktu(x, y, xA, yA, xB, yB);
            double BC = PolozeniePunktu(x, y, xB, yB, xC, yC);
            double CA = PolozeniePunktu(x, y, xC, yC, xA, yA);

            // czy punkt leży na którejś z prostych?
            if (Math.Abs(AB) < 0.0001 || Math.Abs(BC) < 0.0001 || Math.Abs(CA) < 0.0001)
            {
                Console.WriteLine($"\nPunkt P({x},{y}) leży na boku trójkąta ABC");
            }
            // Czy punkt leży wewnątrz trójkąta?
            else if ((AB > 0 && BC > 0 && CA > 0) || (AB < 0 && BC < 0 && CA < 0))
            {
                Console.WriteLine($"\nPunkt P({x},{y}) leży wewnątrz trójkąta ABC");
            }
            else
            {
                Console.WriteLine($"\nPunkt P({x},{y}) leży na zewnątrz trójkąta ABC");
            }

            Console.ReadKey(true);
        }
        static double PolozeniePunktu(double x, double y, double x1, double y1, double x2, double y2)
        {
            return (y2 - y1) * (x - x1) - (x2 - x1) * (y - y1);
        }
    }
}
