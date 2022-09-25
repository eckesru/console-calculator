using System;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen
            Console.Write("Bitte gib den ersten Summanden ein: ");
            int summand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            int summand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ergebnis: {0}", (summand1 + summand2));
            Console.ReadLine();
           }
    }
}
