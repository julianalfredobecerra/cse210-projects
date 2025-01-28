using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
        static void Main(string[] args)
        {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} (Decimal: {fraction1.GetDecimalValue()})");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} (Decimal: {fraction2.GetDecimalValue()})");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} (Decimal: {fraction3.GetDecimalValue()})");
        }
}