using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        System.Console.WriteLine(f1.GetFractionString());
        System.Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(6);
        System.Console.WriteLine(f2.GetFractionString());
        System.Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(6,7);
        System.Console.WriteLine(f3.GetFractionString());
        System.Console.WriteLine(f3.GetDecimalValue());

    }
}