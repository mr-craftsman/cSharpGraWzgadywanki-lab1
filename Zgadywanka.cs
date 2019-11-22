using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace GraZgadywanka
{
    class Program
    {
        static void Main(string[] args)
        {   
            Random losowa = new Random();
            int liczLosowa;
            liczLosowa = losowa.Next(1,101);
            int liczUsera = 0;
            int liczProby = 0;
            Console.WriteLine("Witaj!");
            Console.WriteLine("Podaj swoje imię:  ");
            string imie = Console.ReadLine();
            Console.WriteLine($"Witaj {imie}! Zagrajmy w gre!");
            Console.WriteLine("Gra polega na odgadnieciu liczby od 1 do 100.");
            while (liczUsera != liczLosowa)
            {
                liczProby++;
                Console.WriteLine("Podaj liczbe:  ");
                int.TryParse(Console.ReadLine(), out liczUsera);
                if(liczUsera > liczLosowa)
                {
                    Console.WriteLine("Liczba {0} jest za duza!", liczUsera);
                }
                else if (liczUsera < liczLosowa)
                {
                    Console.WriteLine("Liczba {0} jest za mala!", liczUsera);
                }
                else
                {
                     Console.WriteLine("Gratulacje, liczba {0} to wlasciwa odpowiedz!", liczUsera);
                     Console.WriteLine("Udalo sie zgadnac za {0} razem", liczProby);
                }
            }
            
            
        }
    }
}
