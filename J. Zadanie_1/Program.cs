using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pobranie n i obliczenie sumy
            int i, n, suma = 0;
            Console.Write("Podaj n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) suma += i;

            //zapis do pliku
            string nazwa = @"c:\tmp\wyniki1.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Create,
                FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);
            zapis.WriteLine(suma);
            zapis.Close();
            plik.Close();

            Console.ReadKey(true); //pauza
        }
    }
}
