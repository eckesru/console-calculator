using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal class CalculatorController
    {

        private ConsoleView consoleView;
        private CalculatorModel calculatorModel;

        public CalculatorController(ConsoleView consoleView, CalculatorModel calculatorModel)
        {
            this.consoleView = consoleView;
            this.calculatorModel = calculatorModel;
        }

        public void Ausfuehren()
        {
            // Einlesen des ersten Werts
            decimal wert1 = consoleView.ZahlEinlesen();

            // Einlesen des Rechenoperators
            string rechenoperator = consoleView.OperatorEinlesen();

            // Einlesen des zweiten Werts
            decimal wert2 = consoleView.ZahlEinlesen();

            // Ergebnis berechnen
            calculatorModel.Berechne(wert1, rechenoperator, wert2);

            // Ergebnis ausgeben
            consoleView.ErgebnisAusgabe();

            // Ende des Programms
            consoleView.Beenden();
        }
    }
}
