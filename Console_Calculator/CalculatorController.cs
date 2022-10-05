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
            // Einlesen des Benutzereingaben Wert1, Rechenoperator und Wert2
            consoleView.EingabenEinlesen();

            // Ergebnis berechnen
            calculatorModel.Berechne();

            // Ergebnis ausgeben
            consoleView.ErgebnisAusgabe();

            // Ende des Programms
            consoleView.Beenden();
        }
    }
}
