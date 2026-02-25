using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");

        Assignment a1 = new Assignment("hehe", "calc");
        Console.WriteLine(a1.GetSummary());


        MathAssignment assignment = new MathAssignment("bob", "Adding", "7.3", "8-19");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeWorkList());


        WritingAssignment a3 = new WritingAssignment("linda","topic", "title");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetwritingInformation());
    }
}