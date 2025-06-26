using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, nazwa = @"c:\tmp\liczby2.txt";
            double suma = 0;
            FileStream plik = new FileStream(nazwa,
                FileMode.Open, FileAccess.Read, FileShare.None);
            System.IO.StreamReader odczyt = new StreamReader(plik);

            while ((s = odczyt.ReadLine()) != null) //odczyt z pliku
            {
                suma += Convert.ToDouble(s);
            }
            odczyt.Close();
            plik.Close();

            Console.WriteLine("Suma liczb w pliku wynosi {0}", suma);
            Console.ReadKey(true); //pauza
        }
    }
}
