using System;
using System.Data;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Einlesen des ersten Werts
            ConsoleView consoleView = new ConsoleView();
            string wert1_string = consoleView.WertEinlesen("Bitte gib den ersten Wert ein: ");

            // Einlesen des Rechenoperators
            string rechenoperator = consoleView.WertEinlesen("Bitte gib den Rechenoperator ein (+, -, *, /, oder %): ");

            // Einlesen des zweiten Werts
            string wert2_string = consoleView.WertEinlesen("Bitte gib den zweiten Wert ein: ");

            // Konvertierung der Eingabewerte in Gleitkommazahlen
            // TODO: Auslagern in Methode
            decimal wert1 = Convert.ToDecimal(wert1_string);
            decimal wert2 = Convert.ToDecimal(wert2_string);

            // Ergebnis berechnen
            CalculatorModel calculatorModel = new CalculatorModel();
            calculatorModel.Berechne(wert1, rechenoperator, wert2);

            // Ergebnis ausgeben
            consoleView.ErgebnisAusgabe(wert1, rechenoperator, wert2, calculatorModel.Ergebnis);

            // Ende des Programms
            consoleView.WertEinlesen("Zum Beenden Enter drücken...");
        }


    }
}
