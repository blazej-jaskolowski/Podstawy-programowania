using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Zadanie_2
{
    //definicja struktury
    struct Uczen
    {
        public string imie, nazwisko;
        public byte[] oceny;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Uczen[] uczniowie; //deklaruję zmienną typu strukturalnego
            int ilu_uczniow, ile_ocen, i, j; //zmienne pomocnicze

            //wczytywanie liczby uczniów
            Console.Write("Podaj liczbę uczniów w klasie: ");
            ilu_uczniow = Convert.ToInt32(Console.ReadLine());

            //przydzielam pamięć dla tablicy struktur
            uczniowie = new Uczen[ilu_uczniow];

            //wczytuje dane uczniów od użytkownika
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write($"Podaj imię ucznia {i}: ");
                uczniowie[i].imie = Console.ReadLine();
                Console.Write($"Podaj nazwisko ucznia {i}: ");
                uczniowie[i].nazwisko = Console.ReadLine();

                //wczytuje liczbę ocen ucznia
                Console.Write($"Ile ocen ma {uczniowie[i].imie} {uczniowie[i].nazwisko}: ");
                ile_ocen = Convert.ToInt32(Console.ReadLine());

                //przydzialam pamięć dla tablicy ocen
                uczniowie[i].oceny = new byte[ile_ocen];

                //wczytuje oceny ucznia
                for (j = 0; j < ile_ocen; j++)
                {
                    Console.Write($"Podaj ocenę numer {j}: ");
                    uczniowie[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine(); //wypisanie pustej linii
            }

            //wypisuje dane uczniów na ekranie
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write($"{i}. {uczniowie[i].imie} {uczniowie[i].nazwisko}: ");
                //wypisuje oceny ucznia
                foreach (byte ocena in uczniowie[i].oceny)
                    Console.Write($"{ocena}, ");
                Console.WriteLine(); //przejście do nowego wiersza
            }
            Console.ReadKey(true); //pauza
        }
    }
}
