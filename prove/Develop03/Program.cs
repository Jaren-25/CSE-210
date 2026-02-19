using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Reference reference = new Reference();

        Console.WriteLine($"{reference.GetReference()}");

        Console.WriteLine("Press enter to continue or type 'quit' to end: ");
         string userInput = Console.ReadLine();

         while (userInput != "quit")
        {

        }


    }
}