using System;

class Program
{
    static void Main(string[] args)
    {
       List<Exercise> exercises = new List<Exercise>();

       Running running = new Running(10.5, "04 April 2026", 20);
       Cycling cycling = new Cycling(20,"06 April, 2026", 90);
       Swimming swimming = new Swimming(100, "07 April 2026", 100);

       exercises.AddRange(running);
       exercises.AddRange(cycling);
       exercises.AddRange(swimming);

       foreach(Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }




    }
}