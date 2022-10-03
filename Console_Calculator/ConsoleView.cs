using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal class ConsoleView
    {
        public ConsoleView() { }

        public void ErgebnisAusgabe(decimal wert1, string rechenoperator, decimal wert2, decimal ergebnis)
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

        public string WertEinlesen(string ausgabeText)
        {
            // Textausgabe des übergebenen Strings auf der Konsole
            Console.Write(ausgabeText);

            // Einlesen der Eingabe auf der Konsole
            string eingabe = Console.ReadLine()!;

            return eingabe;
        }

    }
}
