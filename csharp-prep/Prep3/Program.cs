using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

       int guess = 0;

        while (magicNumber != guess)
        {
            // Console.Write("Type a magic number: ");
            // string magicNumberInput = Console.ReadLine();
            // magicNumber = int.Parse(magicNumberInput);


            Console.Write("Enter a guess: ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if(magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}