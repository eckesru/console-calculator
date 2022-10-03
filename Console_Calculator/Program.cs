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
            string rechenoperator = WertEinlesen("Bitte gib den Rechenoperator ein (+, -, *, /, oder %): ");

            // Einlesen des zweiten Werts
            string wert2_string = WertEinlesen("Bitte gib den zweiten Wert ein: ");

            // Konvertierung der Eingabewerte in Gleitkommazahlen
            // TODO: Auslagern in Methode
            decimal wert1 = Convert.ToDecimal(wert1_string);
            decimal wert2 = Convert.ToDecimal(wert2_string);

            // Ergebnis berechnen
            CalculatorModel calculatorModel = new CalculatorModel();
            calculatorModel.Berechne(wert1, rechenoperator, wert2);

            // Ergebnis ausgeben
            ErgebnisAusgabe(wert1, rechenoperator, wert2, calculatorModel.Ergebnis);

            // Ende des Programms
            WertEinlesen("Zum Beenden Enter drücken...");
        }

        static void ErgebnisAusgabe(decimal wert1, string rechenoperator, decimal wert2, decimal ergebnis)
        {
            switch (rechenoperator)
            {

                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                    // String-Ausgabe der Berechnung und des Ergebnisses
                    Console.WriteLine("Ergebnis: " + wert1 + " " + rechenoperator + " " + wert2 + " = {0}", ergebnis);
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe des Rechenoperators.");
                    break;
            }
        }

        static string WertEinlesen(string ausgabeText)
        {
            // Textausgabe des übergebenen Strings auf der Konsole
            Console.Write(ausgabeText);

            // Einlesen der Eingabe auf der Konsole
            string eingabe = Console.ReadLine()!;

            return eingabe;
        }


    }
}
