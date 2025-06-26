using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program wczytujący współrzędne punktu P=(x,y) i wypisujący na ekranie informację, 
 * do której ćwiartki ten punkt należy, czy też informację, że leży on na osi OX i/lub osi OY.*/

namespace E.Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            int cwiartka = 0;

            // podanie współrzędnych
            Console.Write("Podaj współrzędną x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współrzędną y: ");
            y = Convert.ToDouble(Console.ReadLine());

            // określenie ćwiartki
            if (x > 0 && y > 0) cwiartka = 1;
            else if (x < 0 && y > 0) cwiartka = 2;
            else if (x < 0 && y < 0) cwiartka = 3;
            else if (x > 0 && y < 0) cwiartka = 4;

            // wynik
            switch (cwiartka)
            {
                case 0:
                    if (x == 0 && y == 0)
                        Console.WriteLine($"Punkt P({x},{y}) leży na początku układu współrzędnych");
                    else if (x == 0)
                        Console.WriteLine($"Punkt P({x},{y}) leży na osi OY");
                    else
                        Console.WriteLine($"Punkt P({x},{y}) leży na osi OX");
                    break;
                case 1:
                    Console.WriteLine($"Punkt P({x},{y}) leży w I ćwiartce");
                    break;
                case 2:
                    Console.WriteLine($"Punkt P({x},{y}) leży w II ćwiartce");
                    break;
                case 3:
                    Console.WriteLine($"Punkt P({x},{y}) leży w III ćwiartce");
                    break;
                case 4:
                    Console.WriteLine($"Punkt P({x},{y}) leży w IV ćwiartce");
                    break;
            }

            Console.ReadKey(true);  
        }
    }
}
