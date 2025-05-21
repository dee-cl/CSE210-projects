using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(2);
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 1: {fraction1.GetFraction()}");
        Console.WriteLine($"Decimal 1: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFraction()}");
        Console.WriteLine($"Decimal 2: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFraction()}");
        Console.WriteLine($"Decimal 3: {fraction3.GetDecimalValue()}");
    }
}