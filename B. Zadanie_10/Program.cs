using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program wczytujący liczbę arabską od 1 do 1 000 000 i wypisujący na ekranie 
 * słownie wczytaną liczbę. */

namespace B.Zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Podaj liczbę od 1 do 1000000: ");
                if (!int.TryParse(Console.ReadLine(), out int liczba) || liczba < 1 || liczba > 1000000)
                {
                    Console.WriteLine("Nieprawidłowa liczba. Podaj liczbę z zakresu 1–1 000 000.");
                    Console.ReadKey();
                    return;
                }

                if (liczba == 1000000)
                {
                    Console.WriteLine("milion");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine(LiczbaNaSlowa(liczba));
                Console.ReadKey();
            }

            string LiczbaNaSlowa(int liczba)
            {
                string[] jednosci = { "", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };
                string[] nascie = { "dziesięć", "jedenaście", "dwanaście", "trzynaście", "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewiętnaście" };
                string[] dziesiatki = { "", "dziesięć", "dwadzieścia", "trzydzieści", "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt" };
                string[] setki = { "", "sto", "dwieście", "trzysta", "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset" };

                string wynik = "";

                // Tysięce
                int tysiace = liczba / 1000;
                if (tysiace > 0)
                {
                    wynik += PrzetworzSetki(tysiace, jednosci, nascie, dziesiatki, setki);

                    // Odmiana "tysiąc | tysiące | tysięcy"
                    int ostatnie = tysiace % 100;
                    if (tysiace == 1) wynik += "tysiąc ";
                    else if (ostatnie >= 10 && ostatnie <= 20) wynik += "tysięcy ";
                    else
                    {
                        switch (tysiace % 10)
                        {
                            case 2:
                            case 3:
                            case 4:
                                wynik += "tysiące ";
                                break;
                            default:
                                wynik += "tysięcy ";
                                break;
                        }
                    }

                    liczba %= 1000;
                }

                // Jedności-setki
                wynik += PrzetworzSetki(liczba, jednosci, nascie, dziesiatki, setki);

                return wynik.Trim();
            }

            string PrzetworzSetki(int liczba, string[] jednosci, string[] nascie, string[] dziesiatki, string[] setki)
            {
                string tekst = "";

                if (liczba >= 100)
                {
                    tekst += setki[liczba / 100] + " ";
                    liczba %= 100;
                }

                if (liczba >= 10 && liczba <= 19)
                {
                    tekst += nascie[liczba - 10] + " ";
                }
                else
                {
                    if (liczba >= 20)
                    {
                        tekst += dziesiatki[liczba / 10] + " ";
                        liczba %= 10;
                    }

                    if (liczba > 0)
                    {
                        tekst += jednosci[liczba] + " ";
                    }
                }

                return tekst;
            }
        }
    }
}
