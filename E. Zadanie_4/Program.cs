using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisz program wczytujący kwotę w złotych, a następnie przeliczający ją na taką 
 * walutę jaką wybierze użytkownik: funty, dolary, euro. Użyj instrukcji switch. */

namespace E.Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal ExEuro = 4.32M;
            const decimal ExDolar = 3.95M;
            const decimal ExFunt = 5.05M;

            CultureInfo pl = new CultureInfo("pl-PL");

            Console.WriteLine("PRZELICZNIK WALUT");
 
            Console.WriteLine($"1 EUR = {ExEuro.ToString("C2", pl)} PLN");
            Console.WriteLine($"1 USD = {ExDolar.ToString("C2", pl)} PLN");
            Console.WriteLine($"1 GBP = {ExFunt.ToString("C2", pl)} PLN");

            try
            {
                // podanie kwoty w złotówkach do konwersji
                decimal kwotaPLN;
                do
                {
                    Console.Write("Podaj kwotę w złotówkach: ");
                    if (!decimal.TryParse(Console.ReadLine(), out kwotaPLN) || kwotaPLN < 0)
                    {
                        Console.WriteLine("Błąd! Podaj prawidłową, nieujemną kwotę.");
                    }
                    else break;
                } while (true);

                // Menu wyboru waluty
                Console.WriteLine("\nWybierz walutę:");
                Console.WriteLine("1 - Euro (EUR)");
                Console.WriteLine("2 - Dolar amerykański (USD)");
                Console.WriteLine("3 - Funt brytyjski (GBP)");
                Console.WriteLine("0 - Zakończ program");

                int wybor;
                do
                {
                    Console.Write("\nTwój wybór (0-3): ");
                    if (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 0 || wybor > 3)
                    {
                        Console.WriteLine("Błąd! Wybierz liczbę od 0 do 3.");
                        continue;
                    }

                    // Przeliczenie waluty
                    switch (wybor)
                    {
                        case 0:
                            Console.WriteLine("Dziękujemy za skorzystanie z programu!");
                            break;
                        case 1:
                            decimal euro = kwotaPLN / ExEuro;
                            Console.WriteLine($"Przeliczenie na EUR:");
                            Console.WriteLine($"{kwotaPLN:F2} PLN = {euro:F2} EUR");
                            Console.WriteLine($"Kurs: 1 EUR = {ExEuro:F2} PLN");
                            break;
                        case 2:
                            decimal dolary = kwotaPLN / ExDolar;
                            Console.WriteLine($"\nPrzeliczenie na USD:");
                            Console.WriteLine($"{kwotaPLN:F2} PLN = {dolary:F2} USD");
                            Console.WriteLine($"Kurs: 1 USD = {ExDolar:F2} PLN");
                            break;
                        case 3:
                            decimal funty = kwotaPLN / ExFunt;
                            Console.WriteLine($"\nPrzeliczenie na GBP:");
                            Console.WriteLine($"{kwotaPLN:F2} PLN = {funty:F2} GBP");
                            Console.WriteLine($"Kurs: 1 GBP = {ExFunt:F2} PLN");
                            break;
                    }
                } while (wybor != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nWystąpił błąd: {e.Message}");
            }
            Console.ReadKey(true);
        }
    }
}
