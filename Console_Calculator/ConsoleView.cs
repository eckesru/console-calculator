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
            BenutzerWunsch = "Neu";
            endeWunsch = false;

        }

        public bool endeWunsch { get; private set; }
        public string BenutzerWunsch { get; private set; }

        public void ErgebnisAusgabe()
        {
            switch (calculatorModel.Rechenoperator)
            {

                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                    // String-Ausgabe der Berechnung und des Ergebnisses
                    Console.WriteLine("Ergebnis: " + calculatorModel.Wert1 + " " + calculatorModel.Rechenoperator + " " + calculatorModel.Wert2 + " = {0}", calculatorModel.Ergebnis);
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe des Rechenoperators.");
                    break;
            }
        }

        public void EingabenEinlesen()
        {
            if (BenutzerWunsch == "Neu")
            {
                calculatorModel.Wert1 = ZahlEinlesen();
            }
            else if (BenutzerWunsch == "Weiter")
            {
                calculatorModel.Wert1 = calculatorModel.Ergebnis;
                Console.WriteLine("Ergebnis der vorherigen Berechnung: {0}", calculatorModel.Wert1);
            }
            calculatorModel.Rechenoperator = OperatorEinlesen();
            calculatorModel.Wert2 = ZahlEinlesen();
        }

        private decimal ZahlEinlesen()
        {
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            // Einlesen der Zahl auf der Konsole und Konvertierung des Strings in Decimal
            return Convert.ToDecimal(Console.ReadLine());
        }

        private string OperatorEinlesen()
        {
            Console.Write("Bitte gib den Rechenoperator ein (+, -, *, /, oder %): ");
            //Einlesen des Operators auf der Konsole
            return Console.ReadLine()!;
        }

        public void BenutzerWunschAbfragen()
        {
            // Fügt einen Zeilenumbruch ein
            Console.Write(Environment.NewLine);

            // Einlesen der gewünschten Option
            Console.Write("Bitte Option eingeben [ Neu | Weiter | Ende ]: ");
            BenutzerWunsch = Console.ReadLine()!;
            BenutzerWunschAuswerten();

        }

        private void BenutzerWunschAuswerten()
        {
            switch(BenutzerWunsch)
            {
                case "Neu":
                case "Weiter":
                    endeWunsch = false;
                    Console.Write(Environment.NewLine);
                    break;

                case "Ende":
                    endeWunsch = true;
                    Console.Write(Environment.NewLine);
                    break;


                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    BenutzerWunschAbfragen();
                    break;
            }
        }

        public void Beenden()
        {
            Console.Write("Zum Beenden Enter drücken...");
            // Ende des Programms
            Console.ReadLine();
        }
    }
}
