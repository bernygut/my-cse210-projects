using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction FractionOne = new Fraction();
        Console.WriteLine(FractionOne.GetFractionString());
        Console.WriteLine(FractionOne.GetDecimalValue());

        int whole = 5;
        Fraction FractionTwo = new Fraction(whole);
        Console.WriteLine(FractionTwo.GetFractionString());
        Console.WriteLine(FractionTwo.GetDecimalValue());

        int top1 = 3;
        int bottom1 = 4;
        Fraction FractionThree = new Fraction(top1, bottom1);
        Console.WriteLine(FractionThree.GetFractionString());
        Console.WriteLine(FractionThree.GetDecimalValue());

        int top2 = 1;
        int bottom2 = 3;
        Fraction FractionFour = new Fraction(top2, bottom2);
        Console.WriteLine(FractionFour.GetFractionString());
        Console.WriteLine(FractionFour.GetDecimalValue());

    }
}