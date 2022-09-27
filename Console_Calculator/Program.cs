using System;
using System.Data;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe zu berechnen

            //Einlesen und Konvertieren des ersten Werts
            Console.Write("Bitte gib den ersten Summanden ein: ");
            decimal summand1 = WertEinlesen();
            
            //Einlesen und Konvertieren des zweiten Werts
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            decimal summand2 = WertEinlesen();

            //Ergebnis berechnen
            decimal summe = Addieren(summand1, summand2);

            //Ausgeben der Summe beider Werte
            Console.WriteLine("Die Summe ist: {0}", summe);
            WarteAufBenutzerEingabe();
           }

        static decimal WertEinlesen()
        {
            decimal eingabe = Convert.ToDecimal(Console.ReadLine());

            return eingabe;
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.Write("Zum Beenden die Enter Taste drücken...");
            Console.ReadLine();
        }

        static decimal Addieren(decimal summand1, decimal summand2)
        {
            decimal summe = summand1 + summand2;

            return summe;
        }
    }
}
