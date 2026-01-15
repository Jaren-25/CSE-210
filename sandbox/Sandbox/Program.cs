using System;

namespace Sandbox
{
    public class Program
    {
        public static void Main()
        {
            //Console.WriteLine("Hello World");

            // int x = 5;
            // // int, string, bool, double
            // Console.WriteLine("value of x is " + x);

            // Console.Write("question");
            // string color = Console.ReadLine();

        Console.Write("Input weight: ");
        string userInput = Console.ReadLine();
        float weight = float.Parse(userInput);

        Console.Write("Input 'LBS' or 'KG'");
        string unit = Console.ReadLine();



        if (unit == "LBS")
            {
                float kilo = weight / 2.205f;
                Console.WriteLine(kilo);
            }
            else
            {
                float pound = weight * 2.205f;
                Console.WriteLine(pound);
            }
        }
    }
}