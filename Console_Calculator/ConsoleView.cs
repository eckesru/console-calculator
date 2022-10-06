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
            BenutzerWunsch = BenutzerWunschMoeglichkeiten.Neu;
            EndeWunsch = false;

        }

        public enum BenutzerWunschMoeglichkeiten
        {
            Neu,
            Weiter,
            Ende
        }
        public bool EndeWunsch { get; private set; }
        public BenutzerWunschMoeglichkeiten BenutzerWunsch { get; private set; }

        public void ErgebnisAusgabe()
        {
            // String-Ausgabe der Berechnung und des Ergebnisses
            Console.WriteLine("Ergebnis: " + calculatorModel.Wert1 + " " + calculatorModel.Rechenoperator + " " + calculatorModel.Wert2 + " = {0}", calculatorModel.Ergebnis);
        }

        public void EingabenEinlesen()
        {
            if (BenutzerWunsch == BenutzerWunschMoeglichkeiten.Neu)
            {
                calculatorModel.Wert1 = ZahlEinlesen();
            }
            else if (BenutzerWunsch == BenutzerWunschMoeglichkeiten.Weiter)
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

            try
            {
                // Einlesen der Zahl auf der Konsole und Konvertierung des Strings in Decimal
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Ungültige Eingabe der Zahl.");
                return ZahlEinlesen();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Fehler: Es können nur Zahlen zwischen " + Decimal.MinValue + " und " + Decimal.MaxValue + " berechnet werden.");
                return ZahlEinlesen();
            }


        }

        private string OperatorEinlesen()
        {
            Console.Write("Bitte gib den Rechenoperator ein (+, -, *, /, oder %): ");
            string operator_eingabe = Console.ReadLine()!;
            switch (operator_eingabe)
            {

                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                    //Einlesen des Operators auf der Konsole
                    return operator_eingabe;

                default:
                    Console.WriteLine("Fehler: Ungültige Eingabe des Rechenoperators.");
                    return OperatorEinlesen();
            }
        }

        public void BenutzerWunschAbfragen()
        {
            // Fügt einen Zeilenumbruch ein
            Console.Write(Environment.NewLine);

            // Einlesen der gewünschten Option
            Console.Write("Bitte Option eingeben [ Neu | Weiter | Ende ]: ");
            string benutzerWunsch = Console.ReadLine()!;
            BenutzerWunschAuswerten(benutzerWunsch);

        }

        private void BenutzerWunschAuswerten(string benutzerWunsch)
        {
            switch (benutzerWunsch)
            {
                case "Neu":
                    BenutzerWunsch = BenutzerWunschMoeglichkeiten.Neu;
                    EndeWunsch = false;
                    Console.Write(Environment.NewLine);
                    break;

                case "Weiter":
                    BenutzerWunsch = BenutzerWunschMoeglichkeiten.Weiter;
                    EndeWunsch = false;
                    Console.Write(Environment.NewLine);
                    break;

                case "Ende":
                    BenutzerWunsch = BenutzerWunschMoeglichkeiten.Ende;
                    EndeWunsch = true;
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
