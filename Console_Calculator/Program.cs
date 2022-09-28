using System;
using System.Data;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe zu berechnen

            // Einlesen des ersten Werts
            string wert1_string = WertEinlesen("Bitte gib den ersten Wert ein: ");

            // Einlesen des Rechenoperators
            string rechenoperator = WertEinlesen("Bitte gib den Rechenoperator ein (+, -, *, /, oder %): ");

            // Einlesen des zweiten Werts
            string wert2_string = WertEinlesen("Bitte gib den zweiten Wert ein: ");

            // Konvertierung der Eingabewerte in Gleitkommazahlen
            // TODO: Auslagern in Methode
            decimal wert1 = Convert.ToDecimal(wert1_string);
            decimal wert2 = Convert.ToDecimal(wert2_string);

            // Ergebnis berechnen
            BerechneErgebnis(wert1, rechenoperator, wert2);

            // Ende des Programms
            WertEinlesen("Zum Beenden Enter drücken...");
           }

        static void ErgebnisAusgabe(decimal wert1, string rechenoperator, decimal wert2, decimal ergebnis)
        {
            // String-Ausgabe der Berechnung und des Ergebnisses
            Console.WriteLine("Ergebnis: " + wert1 + " " + rechenoperator + " " + wert2 + " = {0}", ergebnis);
        }

        static string WertEinlesen(string ausgabeText)
        {
            // Textausgabe des übergebenen Strings auf der Konsole
            Console.Write(ausgabeText);

            // Einlesen der Eingabe auf der Konsole
            string eingabe = Console.ReadLine()!;

            return eingabe;
        }

        static decimal Addieren(decimal summand1, decimal summand2)
        {
            // Addition beider übergebenen Werte
            decimal summe = summand1 + summand2;

            return summe;

        }
        
        static decimal Subtrahieren(decimal minuend, decimal subtrahend)
        {
            // Subtraktion beider übergebenen Werte
            decimal differenz = minuend - subtrahend;

            return differenz;
        }

        static decimal Multiplizieren(decimal faktor1, decimal faktor2)
        {
            // Multikpkation beider übergebenen Werte
            decimal produkt = faktor1 * faktor2;

            return produkt;
        }

        static decimal Dividieren(decimal dividend, decimal divisor)
        {
            // Division beider übergebenen Werte
            decimal quotient = dividend / divisor;

            return quotient;
        }

        static decimal Modulo(decimal dividend, decimal divisor)
        {
            // Modulo beider übergeben Werte
            decimal rest = dividend % divisor;

            return rest;
        }

        static void BerechneErgebnis(decimal wert1, string rechenoperator, decimal wert2)
        {
            // Ergebnis entsprechend dem Rechenoperator berechnen
            decimal ergebnis = 0;
            switch (rechenoperator)
            {
                case "+":
                    ergebnis = Addieren(wert1, wert2);
                    ErgebnisAusgabe(wert1, rechenoperator, wert2, ergebnis);
                    break;

                case "-":
                    ergebnis = Subtrahieren(wert1, wert2);
                    ErgebnisAusgabe(wert1, rechenoperator, wert2, ergebnis);
                    break;

                case "*":
                    ergebnis = Multiplizieren(wert1, wert2);
                    ErgebnisAusgabe(wert1, rechenoperator, wert2, ergebnis);
                    break;

                case "/":
                    ergebnis = Dividieren(wert1, wert2);
                    ErgebnisAusgabe(wert1, rechenoperator, wert2, ergebnis);
                    break;

                case "%":
                    ergebnis = Modulo(wert1, wert2);
                    ErgebnisAusgabe(wert1, rechenoperator, wert2, ergebnis);
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe des Rechenoperators.");
                    break;
            }
        }
    }
}
