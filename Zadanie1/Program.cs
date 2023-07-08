using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad 1

            //string imieNazwisko = "Szymon" + "Kaput";
            //int wiek = 30;
            //char plec = 'm';
            //long pesel = 12340987135;
            //long numerPracownika = 2509324094;

            //Zad 2

            //char litera1 = 'A';
            //char litera2 = 'B';
            //char litera3 = 'C';

            //Console.WriteLine($"{litera3}, {litera2}, {litera1}"); 
            

            //Zad 3

            // Nie potrafie zrobic samodzielnie a nie chce sie wspomagac czym kolwiek...

            //Zad 4

            //int zmiennaLiczbowa1;
            //double zmiennaLiczbowa2;
            //string zmiennaTekstowa;

            //zmiennaLiczbowa1 = 10;
            //zmiennaTekstowa = "Szkola Dotneta";
            //zmiennaLiczbowa2 = 12.5;

            //zad 5

            Console.WriteLine("Podaj swoje dane personalne");

            Console.WriteLine("Podaj swoje imie");
            string imię = Console.ReadLine();

            Console.WriteLine("Podaj swoje nazwisko");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj swoj wiek");
            string wiek = Console.ReadLine();

            Console.WriteLine("Podaj swoj numer telefonu");
            string numerTelefonu = Console.ReadLine();

            Console.WriteLine("Podaj swoj email");
            string adresEmail = Console.ReadLine();

            Console.Write("Waga:");
            string wagaTekst = Console.ReadLine();
            double waga = double.Parse(wagaTekst);

            Console.WriteLine("Podaj swoj wzrost");
            string wzrostTekst = Console.ReadLine();
            int wzrost = int.Parse(wzrostTekst);

            Console.WriteLine();
            Console.WriteLine("Podane dane personalne:");
            Console.WriteLine("Imię: " + imię);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Wiek: " + wiek);
            Console.WriteLine("Numer telefonu: " + numerTelefonu);
            Console.WriteLine("Adres email: " + adresEmail);
            Console.WriteLine("Waga: " + waga + " cm");
            Console.WriteLine("Wzrost: " + wzrost + " kg");



            Console.ReadKey();
        }
    }
}
