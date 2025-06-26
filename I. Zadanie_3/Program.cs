using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10; //maksymalna ilość elementów tablicy
            string[] owoc = new string[N];
            int ile = 0; //ilość elementów jest tablicy
            int w, nr, i; //wybor; numer elementu tablicy; licznik pętli

            do
            {
                Console.WriteLine("\nMENU:\n1-dodaj\n2-modyfikuj\n3-usuń");
                Console.Write("Wybierz (lub koniec=0): ");
                w = Convert.ToInt32(Console.ReadLine());

                switch (w)
                {
                    case 0: break;
                    case 1: //dodaj
                        Console.Write("Podaj nazwę owocu: ");
                        owoc[ile++] = Console.ReadLine();
                        break;
                    case 2: //modyfikuj nazwę owocu
                        Console.Write("Podaj numer owocu do modyfikacji: ");
                        nr = Convert.ToInt32(Console.ReadLine());
                        if ((nr < ile) && (nr >= 0))
                        {
                            Console.WriteLine($"Obecna nazwa owocu: {owoc[nr - 1]}");
                            Console.Write("Podaj nową nazwę owocu: ");
                            owoc[nr - 1] = Console.ReadLine();
                        }
                        else Console.WriteLine("Błędny numer !!!");
                        break;
                    case 3: //usuń owoc
                        if (ile == 0) Console.WriteLine("Brak elementów !!!");
                        else
                        {
                            Console.Write("Podaj numer owocu do usunięcia: ");
                            nr = Convert.ToInt32(Console.ReadLine());
                            if ((nr < ile) && (nr >= 0))
                            {
                                Console.WriteLine($"Usunięty owoc: {owoc[nr - 1]}");
                                if (ile == 1) ile = 0;
                                else
                                {
                                    for (i = nr - 1; i < ile - 1; i++) owoc[i] = owoc[i + 1];
                                    ile--;
                                }
                            }
                            else Console.WriteLine("Błędny numer !!!");
                        }
                        break;
                    case 4: //wypisz wszystkie owoce
                        Console.WriteLine("Dostępne owoce:");
                        for (i = 0; i < ile; i++)
                            Console.WriteLine($"{i}. {owoc[i]}");
                        break;
                    default: Console.WriteLine("Nieznany wybór !!!"); break;
                }
            } while (w != 0);

            Console.ReadKey(true); //pauza
        }
    }
}