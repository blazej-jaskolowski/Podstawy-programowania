using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program, który pozwoli wybrać użytkownikowi: ostrosłup (podstawa kwadrat)
   walec lub sześcian, poprosi o jego wymiary i następnie obliczy: objętość, pole podstawy,
   wysokości, pole powierzchni bocznej, pole powierzchni całkowitej. */

namespace Zadanie_10___11
{
    internal class Program
    {
		static void Main(string[] args)
		{

			Console.WriteLine("Wybierz bryle by obliczyc pole");
			Console.WriteLine("1. Ostroslup o podstawie kwadratowej");
			Console.WriteLine("2. Walec");
			Console.WriteLine("3. Szescian");

			int wybor = int.Parse(Console.ReadLine());
			double Pp;
			double H;
			double V;
			double Ppb;
			double Ppc;
			const double PI = 3.1415926535897931;


			switch (wybor)
			{
				case 1:
					Console.WriteLine("Podaj wymiar boku podstawy 'a'");
					double a = double.Parse(Console.ReadLine());
					Console.WriteLine("Podaj wysokosc trojkata powierzchni bocznej 'h'");
					double h = double.Parse(Console.ReadLine());

					Pp = Math.Pow(a, 2);
					Console.WriteLine("Pole podstawy ostroslupa = " + Pp);

					H = Math.Sqrt(Math.Pow(h, 2) - Math.Pow(a, 2) * 1 / 2);
					Console.WriteLine("Wysokosc ostroslupa = " + H);

					V = Pp * H * 1 / 3;
					Console.WriteLine("Objetosc ostroslupa = " + V);

					Ppb = 4 * 1 / 2 * a * H;
					Console.WriteLine("Pole powierzchni bocznej ostroslupa = " + Ppb);

					Ppc = Pp + Ppb;
					Console.WriteLine("Pole powierzchni calkowitej ostroslupa = " + Ppc);

					break;

				case 2:
					Console.WriteLine("Podaj wymiar promienia 'r'");
					double r = double.Parse(Console.ReadLine());
					Console.WriteLine("Podaj długosc 'x' od krawedzi podstawy dolnej do środka koła tworzącego podstawę górną");
					double x = double.Parse(Console.ReadLine());

					Pp = PI * Math.Pow(r, 2);
					Console.WriteLine("Pole podstawy walca = " + Pp);

					H = Math.Sqrt(Math.Pow(x, 2) - Math.Pow(r, 2));
					Console.WriteLine("Wysokosc walca = " + H);

					V = PI * Math.Pow(r, 2) * H;
					Console.WriteLine("Objetosc walca = " + V);

					Ppb = 2 * r * H * PI;
					Console.WriteLine("Pole powierzchni bocznej walca = " + Ppb);

					Ppc = Ppb + 2 * Pp;
					Console.WriteLine("Pole powierzchni calkowitej walca = " + Ppc);

					break;

				case 3:
					Console.WriteLine("Podaj wymiar boku 'y'");
					double y = double.Parse(Console.ReadLine());

					Pp = Math.Pow(y, 2);
					Console.WriteLine("Pole podstawy szescianu = " + Pp);

					H = y;
					Console.WriteLine("Wysokosc szescianu = " + H);

					V = Math.Pow(y, 3);
					Console.WriteLine("Objetosc szescianu = " + V);

					Ppb = Math.Pow(y, 2);
					Console.WriteLine("Pole powierzchni bocznej szescianu = " + Ppb);

					Ppc = 6 * Math.Pow(y, 2);
					Console.WriteLine("Pole powierzchni calkowitej szescianu = " + Ppc);

					break;
			}

            Console.WriteLine("Naciśnij <Enter> by opuścić program... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
