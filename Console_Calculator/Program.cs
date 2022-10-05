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
            CalculatorController calculatorController = new CalculatorController(consoleView, calculatorModel);

            calculatorController.Ausfuehren();
        }


    }
}
