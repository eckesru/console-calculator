using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal class CalculatorModel

    {
        public CalculatorModel()
        {
            Ergebnis = 0;
        }
        public decimal Ergebnis { get; private set; }

        public void Berechne(decimal wert1, string rechenoperator, decimal wert2)
        {
            // Ergebnis entsprechend dem Rechenoperator berechnen
            switch (rechenoperator)
            {
                case "+":
                    Ergebnis = Addieren(wert1, wert2);
                    break;

                case "-":
                    Ergebnis = Subtrahieren(wert1, wert2);
                    break;

                case "*":
                    Ergebnis = Multiplizieren(wert1, wert2);
                    break;

                case "/":
                    Ergebnis = Dividieren(wert1, wert2);
                    break;

                case "%":
                    Ergebnis = Modulo(wert1, wert2);
                    break;
            }
        }

        private decimal Addieren(decimal summand1, decimal summand2)
        {
            // Addition beider übergebenen Werte
            decimal summe = summand1 + summand2;

            return summe;

        }

        private decimal Subtrahieren(decimal minuend, decimal subtrahend)
        {
            // Subtraktion beider übergebenen Werte
            decimal differenz = minuend - subtrahend;

            return differenz;
        }

        private decimal Multiplizieren(decimal faktor1, decimal faktor2)
        {
            // Multikpkation beider übergebenen Werte
            decimal produkt = faktor1 * faktor2;

            return produkt;
        }

        private decimal Dividieren(decimal dividend, decimal divisor)
        {
            // Division beider übergebenen Werte
            decimal quotient = dividend / divisor;

            return quotient;
        }

        private decimal Modulo(decimal dividend, decimal divisor)
        {
            // Modulo beider übergeben Werte
            decimal rest = dividend % divisor;

            return rest;
        }

    }
}
