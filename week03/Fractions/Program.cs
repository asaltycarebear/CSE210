using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(4);
        Fraction f3 = new Fraction(3, 8);
        Fraction f4 = new Fraction(1, 16);

        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f1.GetDecimal());

        Console.WriteLine(f2.GetFraction());
        Console.WriteLine(f2.GetDecimal());

        Console.WriteLine(f3.GetFraction());
        Console.WriteLine(f3.GetDecimal());

        Console.WriteLine(f4.GetFraction());
        Console.WriteLine(f4.GetDecimal());
    }
}