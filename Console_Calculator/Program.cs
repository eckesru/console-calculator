using System;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe zu berechnen

            //Einlesen und Konvertieren des ersten Werts
            Console.Write("Bitte gib den ersten Summanden ein: ");
            decimal summand1 = Convert.ToDecimal(Console.ReadLine());
            
            //Einlesen und Konvertieren des zweiten Werts
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            decimal summand2 = Convert.ToDecimal(Console.ReadLine());

            //Ausgeben der Summe beider Werte
            decimal summe = summand1 + summand2;
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();
           }
    }
}
