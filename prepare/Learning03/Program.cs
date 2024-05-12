using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(2);
        Fraction fraction3 = new Fraction(3, 4);

        fraction1.SetBottom(4);
        fraction1.SetTop(1);

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        
    }
}