using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Reference reference = new Reference();
        Word word = new Word();

        string userInput = "";

        int count = 0;

        Console.Clear();
        Console.Write($"{reference.GetReference()} ");
        Console.WriteLine($"{word.GetVerse()} ");
        Console.WriteLine();


        while (userInput != "quit" /*| word.GetRandWordList().Count < word.SplitWords(word.GetVerse()).Length*/)
        {

            Console.WriteLine($"location count: {word.GetRandWordList().Count}");
            Console.WriteLine($"string length: {word.SplitWords(word.GetVerse()).Length}");

            Console.WriteLine("Press enter to continue or type 'quit' to end: ");
            userInput = Console.ReadLine();


            Console.Clear();

            Console.Write($"{reference.GetReference()} ");


            count = word.SplitWords(word.GetVerse()).Length;

            for( int i = 0; i < count; i++)
            {

                if(word.GetRandWordSpot(i) == true)
                {
                    Console.Write($"{word.Getmask(word.GetSplitWords(i).Length)} ");
                }

                else
                {
                    Console.Write($"{word.GetSplitWords(i)} ");
                }
            }
            //word.GetRandWordList();

            if(word.GetRandWordList().Count >= word.SplitWords(word.GetVerse()).Length)
            {
                userInput = "quit";
            }
        }

        Console.Clear();

        Console.Write($"{reference.GetReference()} ");

        count = word.SplitWords(word.GetVerse()).Length;

        for( int i = 0; i < count; i++)
        {

            if(word.GetRandWordSpot(i) == true)
            {
                Console.Write($"{word.Getmask(word.GetSplitWords(i).Length)} ");
            }

            else
            {
                Console.Write($"{word.GetSplitWords(i)} ");

            }
        }
    }
}