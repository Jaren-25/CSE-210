using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        int numbers = -1;

        while (numbers != 0)
        {
            Console.Write("Input a number: ");
            string numbersInput = Console.ReadLine();
            numbers = int.Parse(numbersInput);

            if (numbers != 0)
            {
                numbersList.Add(numbers);
            }


        }
        int total = 0;
        double average = 0;
        int large = 0;

        foreach (int number in numbersList)
        {
            //Console.WriteLine(number);
            total = total + number;
            average = (double)total / numbersList.Count;
            if (number > large)
            {
                large = number;
            }
        }
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {large}");

    }
}