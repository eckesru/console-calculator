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

            // Einlesen des Rechenoperators
            string rechenoperator = WertEinlesen("Bitte gib den Rechenoperator ein (+ oder -): ");

            // Einlesen des zweiten Werts
            string wert2_string = WertEinlesen("Bitte gib den zweiten Wert ein: ");

            // Konvertierung der Eingabewerte in Gleitkommazahlen
            // TODO: Auslagern in Methode
            decimal wert1 = Convert.ToDecimal(wert1_string);
            decimal wert2 = Convert.ToDecimal(wert2_string);

            // Ergebnis entsprechend dem Rechenoperator berechnen
            decimal ergebnis = 0;
            switch(rechenoperator)
            {
                case "+":
                    ergebnis = Addieren(wert1, wert2);
                    ErgebnisAusgabe(wert1, wert2, rechenoperator, ergebnis);
                    break;

                case "-":
                    ergebnis = Subtrahieren(wert1, wert2);
                    ErgebnisAusgabe(wert1, wert2, rechenoperator, ergebnis);
                    break;

                case "*":
                case "/":
                case "%":
                    Console.WriteLine("Dieser Rechenoperator wird derzeit noch nicht unterstützt.");
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe des Rechenoperators.");
                    break;
            }

            // Ende des Programms
            WertEinlesen("Zum Beenden Enter drücken...");
           }

        static void ErgebnisAusgabe(decimal wert1, decimal wert2, string rechenoperator, decimal ergebnis)
        {
            // String-Ausgabe der Berechnung und des Ergebnisses
            Console.WriteLine("Ergebnis: " + wert1 + " " + rechenoperator + " " + wert2 + " = {0}", ergebnis);
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
