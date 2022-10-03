using System;
using System.Data;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorModel calculatorModel = new CalculatorModel();
            ConsoleView consoleView = new ConsoleView(calculatorModel);

            // Einlesen des ersten Werts
            string wert1_string = consoleView.ZahlEinlesen();

            // Einlesen des Rechenoperators
            string rechenoperator = consoleView.OperatorEinlesen();

            // Einlesen des zweiten Werts
            string wert2_string = consoleView.ZahlEinlesen();

            // Konvertierung der Eingabewerte in Gleitkommazahlen
            // TODO: Auslagern in Methode
            decimal wert1 = Convert.ToDecimal(wert1_string);
            decimal wert2 = Convert.ToDecimal(wert2_string);

            // Ergebnis berechnen
            calculatorModel.Berechne(wert1, rechenoperator, wert2);

            // Ergebnis ausgeben
            consoleView.ErgebnisAusgabe(wert1, rechenoperator, wert2);

            // Ende des Programms
            consoleView.Beenden();
        }


    }
}
