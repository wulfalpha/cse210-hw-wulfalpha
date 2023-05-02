using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction One = new Fraction();
        Console.WriteLine(One.GetFractionString());
        Console.WriteLine(One.GetDecimalValue());

        Fraction whole = new Fraction(6);
        Console.WriteLine(whole.GetFractionString());
        Console.WriteLine(whole.GetDecimalValue());

        Fraction frac = new Fraction(1, 2);
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

        Fraction doom = new Fraction(2, 8);
        Console.WriteLine(doom.GetFractionString());
        Console.WriteLine(doom.GetDecimalValue());
    }
}
