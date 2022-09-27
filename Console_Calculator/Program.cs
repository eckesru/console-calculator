using System;
using System.Data;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe zu berechnen

            // Einlesen des ersten Werts
            decimal summand1 = WertEinlesen("Bitte gib den ersten Wert ein: ");
            
            // Einlesen des zweiten Werts
            decimal summand2 = WertEinlesen("Bitte gib den zweiten Wert ein: ");

            // Ergebnis berechnen
            decimal ergebnis = Addieren(summand1, summand2);

            // Ausgeben der Summe beider Werte
            Console.WriteLine("Die Summe ist: {0}", ergebnis);
            WarteAufBenutzerEingabe();
           }

        static decimal WertEinlesen(string ausgabeText)
        {
            // Textausgabe des übergebenen Strings auf der Konsole
            Console.Write(ausgabeText);

            // Einlesen der Benutzereingabe auf der Konsole und Konvertieren des Werts
            decimal eingabe = Convert.ToDecimal(Console.ReadLine());

            return eingabe;
        }

        static void WarteAufBenutzerEingabe()
        {
            // Textausgabe mit Anweisung zum Beenden der Konsole
            Console.Write("Zum Beenden die Enter Taste drücken...");
            Console.ReadLine();
        }

        static decimal Addieren(decimal summand1, decimal summand2)
        {
            // Addition beider übergebenen Werte
            decimal summe = summand1 + summand2;

            return summe;
        }
    }
}
