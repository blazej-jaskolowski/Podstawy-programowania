using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Zadanie_4
{
    struct Samochod
    {
        public string marka;
        public string typ;
        public int rok_produkcji;
        public int przebieg;
        public string kolor;
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100; //maksymalna liczba aut (przepełnienie)
            Samochod[] samochody = new Samochod[MAX];
            int ile = 0; //startowa liczba aut w programie
            int wybor, nr;

            do
            {
                //menu
                Console.WriteLine("\nMenu Główne:");
                Console.WriteLine("1. Dodaj samochód");
                Console.WriteLine("2. Usuń samochód");
                Console.WriteLine("3. Modyfikuj dane samochodu");
                Console.WriteLine("4. Wyświetl informacje o samochodzie");
                Console.WriteLine("5. Wyświetl listę wszystkich samochodów");
                Console.WriteLine("0. Zakończ program");
                Console.Write("\nWybierz opcję: ");

                wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 1: //dodawanie auta
                        if (ile < MAX)
                        {
                            Console.Write("\nPodaj markę: ");
                            samochody[ile].marka = Console.ReadLine();
                            Console.Write("Podaj typ: ");
                            samochody[ile].typ = Console.ReadLine();
                            Console.Write("Podaj rok produkcji: ");
                            samochody[ile].rok_produkcji = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Podaj przebieg: ");
                            samochody[ile].przebieg = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Podaj kolor: ");
                            samochody[ile].kolor = Console.ReadLine();
                            ile++;
                            Console.WriteLine("Dodano samochód!");
                        }
                        else Console.WriteLine("Brak miejsca na nowy samochód!");
                        break;

                    case 2: //usuwanie samochodu
                        if (ile > 0)
                        {
                            Console.Write("\nPodaj numer samochodu do usunięcia (1-" + ile + "): ");
                            nr = Convert.ToInt32(Console.ReadLine()) - 1;
                            if (nr >= 0 && nr < ile)
                            {
                                for (int i = nr; i < ile - 1; i++)
                                    samochody[i] = samochody[i + 1];
                                ile--;
                                Console.WriteLine("Usunięto samochód!");
                            }
                            else Console.WriteLine("Nieprawidłowy numer!");
                        }
                        else Console.WriteLine("Brak samochodów w bazie!");
                        break;

                    case 3: //modyfikacja danych
                        if (ile > 0)
                        {
                            Console.Write("\nPodaj numer samochodu do modyfikacji (1-" + ile + "): ");
                            nr = Convert.ToInt32(Console.ReadLine()) - 1;
                            if (nr >= 0 && nr < ile)
                            {
                                Console.Write("Podaj markę: ");
                                samochody[nr].marka = Console.ReadLine();
                                Console.Write("Podaj typ: ");
                                samochody[nr].typ = Console.ReadLine();
                                Console.Write("Podaj rok produkcji: ");
                                samochody[nr].rok_produkcji = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Podaj przebieg: ");
                                samochody[nr].przebieg = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Podaj kolor: ");
                                samochody[nr].kolor = Console.ReadLine();
                                Console.WriteLine("Zmodyfikowano dane!");
                            }
                            else Console.WriteLine("Nieprawidłowy numer!");
                        }
                        else Console.WriteLine("Brak samochodów w bazie!");
                        break;

                    case 4: //wyświetlanie informacji
                        if (ile > 0)
                        {
                            Console.Write("\nPodaj numer samochodu (1-" + ile + "): ");
                            nr = Convert.ToInt32(Console.ReadLine()) - 1;
                            if (nr >= 0 && nr < ile)
                            {
                                Console.WriteLine("\nInformacje o samochodzie:");
                                Console.WriteLine("Marka: " + samochody[nr].marka);
                                Console.WriteLine("Typ: " + samochody[nr].typ);
                                Console.WriteLine("Rok produkcji: " + samochody[nr].rok_produkcji);
                                Console.WriteLine("Przebieg: " + samochody[nr].przebieg);
                                Console.WriteLine("Kolor: " + samochody[nr].kolor);
                            }
                            else Console.WriteLine("Nieprawidłowy numer!");
                        }
                        else Console.WriteLine("Brak samochodów w bazie!");
                        break;

                    case 5: //wyświetlanie wszystkich aut
                        if (ile > 0)
                        {
                            Console.WriteLine("\nLista wszystkich samochodów:");
                            for (int i = 0; i < ile; i++)
                            {
                                Console.WriteLine($"\nSamochód {i + 1}:");
                                Console.WriteLine("Marka: " + samochody[i].marka);
                                Console.WriteLine("Typ: " + samochody[i].typ);
                                Console.WriteLine("Rok produkcji: " + samochody[i].rok_produkcji);
                                Console.WriteLine("Przebieg: " + samochody[i].przebieg);
                                Console.WriteLine("Kolor: " + samochody[i].kolor);
                            }
                        }
                        else Console.WriteLine("Brak samochodów w bazie!");
                        break;

                    case 0: //zakończenie programu
                        Console.WriteLine("\nBywaj!");
                        break;

                    default:
                        Console.WriteLine("\nNieprawidłowy wybór!");
                        break;
                }

            } while (wybor != 0);

            Console.ReadKey(true);
        }
    }
}