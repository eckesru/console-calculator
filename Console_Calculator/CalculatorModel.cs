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
            Rechenoperator = "?";
        }

        public decimal Wert1 { get; set; }
        public string Rechenoperator { get; set; }
        public decimal Wert2 { get; set; }
        public decimal Ergebnis { get; private set; }

        public void Berechne()
        {
            try
            {
                // Ergebnis entsprechend dem Rechenoperator berechnen
                switch (Rechenoperator)
                {
                    case "+":
                        Ergebnis = Addieren(Wert1, Wert2);
                        break;

                    case "-":
                        Ergebnis = Subtrahieren(Wert1, Wert2);
                        break;

                    case "*":
                        Ergebnis = Multiplizieren(Wert1, Wert2);
                        break;

                    case "/":
                        Ergebnis = Dividieren(Wert1, Wert2);
                        break;

                    case "%":
                        Ergebnis = Modulo(Wert1, Wert2);
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fehler: Division durch 0 nicht möglich.");
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
