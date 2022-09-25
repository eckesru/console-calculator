using System;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen

            //Einlesen und Konvertieren des ersten Werts
            Console.Write("Bitte gib den ersten Summanden ein: ");
            int summand1 = Convert.ToInt32(Console.ReadLine());
            
            //Einlesen und Konvertieren des zweiten Werts
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            int summand2 = Convert.ToInt32(Console.ReadLine());

            //Ausgeben der Summe beider Werte
            Console.WriteLine("Die Summe ist: {0}", (summand1 + summand2));
            Console.ReadLine();
           }
    }
}
