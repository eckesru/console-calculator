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
            decimal wert1 = WertEinlesen("Bitte gib den ersten Wert ein: ");
            
            // Einlesen des zweiten Werts
            decimal wert2 = WertEinlesen("Bitte gib den zweiten Wert ein: ");

            // Ergebnis berechnen
            decimal ergebnis = Addieren(wert1, wert2);

            // Ausgeben der Summe beider Werte
            Console.WriteLine("Ergebnis: {0}", ergebnis);
            WarteAufEingabe();
           }

        static decimal WertEinlesen(string ausgabeText)
        {
            // Textausgabe des übergebenen Strings auf der Konsole
            Console.Write(ausgabeText);

            // Einlesen der Benutzereingabe auf der Konsole und Konvertieren des Strings in eine Gleitkommazahl
            decimal eingabe = Convert.ToDecimal(Console.ReadLine());

            return eingabe;
        }

        static void WarteAufEingabe()
        {
            // Textausgabe mit Anweisung zum Beenden der Konsole
            Console.Write("Zum Beenden Enter drücken...");
            Console.ReadLine();
        }

        static decimal Addieren(decimal summand1, decimal summand2)
        {
            // Addition beider übergebenen Werte
            decimal summe = summand1 + summand2;

            return summe;

        }
        
        static decimal Subtrahieren(decimal minuend, decimal subtrahend)
        {
            // Subtraktion beider übergebenen Werte
            decimal summe = minuend - subtrahend;

            return summe;
        }
    }
}
