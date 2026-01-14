using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade? ");
        string input = Console.ReadLine();

        int grade = int.Parse(input);

        string letter = " ";

        if (grade >= 90)
        {
            //Console.WriteLine("A");
            letter = "A";
        }
        else if (grade >= 80)
        {
            //Console.WriteLine("B");
            letter = "B";
        }
        else if (grade >= 70)
        {
            //Console.WriteLine("C");
            letter = "C";
        }
        else if (grade >= 60)
        {
            //Console.WriteLine("D");
            letter = "D";
        }
        else if (grade < 60)
        {
            //Console.WriteLine("F");
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Yay! You passed!");
        }
        else
        {
            Console.WriteLine("You FAILED! Do better!");
        }
    }
}