using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal class ConsoleView
    {
        private CalculatorModel calculatorModel;
        public ConsoleView(CalculatorModel calculatorModel)
        {
            this.calculatorModel = calculatorModel;
        }

        public void ErgebnisAusgabe(decimal wert1, string rechenoperator, decimal wert2)
        {
            switch (rechenoperator)
            {

                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                    // String-Ausgabe der Berechnung und des Ergebnisses
                    Console.WriteLine("Ergebnis: " + wert1 + " " + rechenoperator + " " + wert2 + " = {0}", calculatorModel.Ergebnis);
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe des Rechenoperators.");
                    break;
            }
        }

        public decimal ZahlEinlesen()
        {
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            // Einlesen der Zahl auf der Konsole und Konvertierung des Strings in Decimal
            return Convert.ToDecimal(Console.ReadLine());
        }

        public string OperatorEinlesen()
        {
            Console.Write("Bitte gib den Rechenoperator ein (+, -, *, /, oder %): ");
            //Einlesen des Operators auf der Konsole
            return Console.ReadLine()!;
        }

        public void Beenden()
        {
            Console.Write("Zum Beenden Enter drücken...");
            // Ende des Programms
            Console.ReadLine();
        }
    }
}
