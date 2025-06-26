using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program, który będzie umożliwiał użytkownikowi obliczanie objętości różnych brył. 
 * Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia objętości kuli, 
 * dla 2 – objętości stożka, dla 3 – objętości walca, dla 4 – objętości prostopadłościanu, 
 * a dla 5 – objętości sześcianu. Program powinien pytać użytkownika, którą objętość chce 
 * obliczyć aż do momentu, kiedy użytkownik wpisze 0 (zero). Użyj pętli do-while.*/

namespace D.Zadanie_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double r, h, a, b;
            const double PI = Math.PI;

            do
            {
                Console.WriteLine("Obliczanie objętości brył:");
                Console.WriteLine("1 - Kula");
                Console.WriteLine("2 - Stożek");
                Console.WriteLine("3 - Walec");
                Console.WriteLine("4 - Prostopadłościan");
                Console.WriteLine("5 - Sześcian");
                Console.WriteLine("0 - Koniec programu");
                Console.Write("\nWybierz bryłę (0-5): ");

                while (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 0 || wybor > 5)
                {
                    Console.Write("Wybór spoza zakresu. Wybierz liczbę od 0 do 5: ");
                }

                switch (wybor)
                {
                    case 1: // Kula: V = 4/3 × π × r³
                        Console.Write("Podaj promień kuli (r): ");
                        r = czyLiczbaDodatnia();
                        double objetoscKuli = (4.0 / 3.0) * PI * Math.Pow(r, 3);
                        Console.WriteLine($"Objętość kuli: {objetoscKuli:F2}");
                        break;

                    case 2: // Stożek: V = 1/3 × π × r² × h
                        Console.Write("Podaj promień podstawy stożka (r): ");
                        r = czyLiczbaDodatnia();
                        Console.Write("Podaj wysokość stożka (h): ");
                        h = czyLiczbaDodatnia();
                        double objetoscStozka = (1.0 / 3.0) * PI * Math.Pow(r, 2) * h;
                        Console.WriteLine($"Objętość stożka: {objetoscStozka:F2}");
                        break;

                    case 3: // Walec: V = π × r² × h
                        Console.Write("Podaj promień podstawy walca (r): ");
                        r = czyLiczbaDodatnia();
                        Console.Write("Podaj wysokość walca (h): ");
                        h = czyLiczbaDodatnia();
                        double objetoscWalca = PI * Math.Pow(r, 2) * h;
                        Console.WriteLine($"Objętość walca: {objetoscWalca:F2}");
                        break;

                    case 4: // Prostopadłościan: V = a × b × h
                        Console.Write("Podaj długość prostopadłościanu (a): ");
                        a = czyLiczbaDodatnia();
                        Console.Write("Podaj szerokość prostopadłościanu (b): ");
                        b = czyLiczbaDodatnia();
                        Console.Write("Podaj wysokość prostopadłościanu (h): ");
                        h = czyLiczbaDodatnia();
                        double objetoscProstopadloscianu = a * b * h;
                        Console.WriteLine($"Objętość prostopadłościanu: {objetoscProstopadloscianu:F2}");
                        break;

                    case 5: // Sześcian: V = a³
                        Console.Write("Podaj długość krawędzi sześcianu (a): ");
                        a = czyLiczbaDodatnia();
                        double objetoscSzescianu = Math.Pow(a, 3);
                        Console.WriteLine($"Objętość sześcianu: {objetoscSzescianu:F2}");
                        break;
                }

                if (wybor != 0)
                {
                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
                    Console.ReadKey(true);
                    Console.Clear();
                }

            } while (wybor != 0);

            Console.WriteLine("Do zobaczenia.");
            Console.ReadKey(true);
        }

        // Metoda pomocnicza do wczytywania liczb dodatnich
        static double czyLiczbaDodatnia()
        {
            double liczba;
            while (!double.TryParse(Console.ReadLine(), out liczba) || liczba <= 0)
            {
                Console.Write("Błędna wartość. Podaj liczbę dodatnią: ");
            }
            return liczba;
        }
    }
}
