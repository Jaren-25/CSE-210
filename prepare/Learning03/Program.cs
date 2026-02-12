using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
         Console.Write("Enter a top number ");
        string topInput = Console.ReadLine();
        int top = int.Parse(topInput);

        Console.Write("Enter a bottom number ");
        string bottomInput = Console.ReadLine();
        int bottom = int.Parse(bottomInput);

        Fraction fraction = new Fraction();
        fraction.SetTop(top);
        fraction.SetBottom(bottom);
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        Fraction fraction1 = new Fraction(6);
        fraction1.SetTop(top);
        fraction1.SetBottom(bottom);
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());
        fraction1.GetFractionString();
        fraction1.GetDecimalValue();

        Fraction fraction2 = new Fraction(6, 7);
        fraction2.SetTop(top);
        fraction2.SetBottom(bottom);
        Console.WriteLine(fraction2.GetTop());
        Console.WriteLine(fraction2.GetBottom());
        fraction2.GetFractionString();
        fraction2.GetDecimalValue();

        int i = 0;
        while(i < 21)
        {
            Random random = new Random();
            top = random.Next(1,100);
            fraction.SetTop(top);

            bottom = random.Next(1,100);
            fraction.SetBottom(bottom);

            Console.WriteLine($"Fraction {i}: string: {fraction.GetFractionString()} Number: {fraction.GetDecimalValue()}");

            i++;
        }

    }
}