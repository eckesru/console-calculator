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
            string wert1_string = WertEinlesen("Bitte gib den ersten Wert ein: ");
            
            // Einlesen des zweiten Werts
            string wert2_string = WertEinlesen("Bitte gib den zweiten Wert ein: ");

            // Einlesen des Rechenoperators
            string rechenoperator = WertEinlesen("Bitte gibt den Rechenoperator ein: ");

            // Konvertierung der Eingabewerte in Gleitkommazahlen
            // TODO: Auslagern in Methode
            decimal wert1 = Convert.ToDecimal(wert1_string);
            decimal wert2 = Convert.ToDecimal(wert2_string);

            // Ergebnis berechnen
            decimal ergebnis = Addieren(wert1, wert2);

            // Ausgeben der Summe beider Werte
            Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
            WertEinlesen("Zum Beenden Enter drücken...");
           }


        static string WertEinlesen(string ausgabeText)
        {
            // Textausgabe des übergebenen Strings auf der Konsole
            Console.Write(ausgabeText);

            // Einlesen der Eingabe auf der Konsole
            string eingabe = Console.ReadLine()!;

            return eingabe;
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
