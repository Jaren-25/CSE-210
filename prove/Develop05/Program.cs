using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        string filename = "goals.txt";

        int input = 0;
        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();

        GoalFileManager goalFileManager = new GoalFileManager(filename);
        List<Goal> goals = goalFileManager.Load();

        List<SimpleGoal> simpleGoals = new List<SimpleGoal>();
        List<EternalGoal> eternalGoals = new List<EternalGoal>();
        List<ChecklistGoal> checklistGoals = new List<ChecklistGoal>();




        while(input != 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create new goal");
            Console.WriteLine(" 2. List goals");
            Console.WriteLine(" 3. Save goals");
            Console.WriteLine(" 4. Load goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");


            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            input = int.Parse(userInput);



            switch (input)
            {
                case 1:
                    //main menu
                    int goalType = 0;

                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine(" 1. Simple Goal");
                    Console.WriteLine(" 2. Eternal Goal");
                    Console.WriteLine(" 3. Checklist Goal");

                    Console.Write("Select a goal type from the menu: ");
                    string goalInput = Console.ReadLine();
                    goalType = int.Parse(goalInput);

                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("Write a description of your goal ");
                    string description = Console.ReadLine();

                    Console.Write("How many points is it worth?: ");
                    string pointInput = Console.ReadLine();
                    int points = int.Parse(pointInput);

                    switch (goalType)
                    {
                        case 1:
                            //simple goal
                            simpleGoals = new List<SimpleGoal>
                            {
                                //bool isFinished, string name, string desription, int goalPoints
                                new SimpleGoal(false, name, description, points)
                            };
                            goals.AddRange(simpleGoals);

                            break;

                        case 2:
                            //eternal goal
                            eternalGoals = new List<EternalGoal>
                            {
                                //bool isFinished, string name, string description, int goalPoints
                                new EternalGoal(false, name, description, points)
                            };
                            goals.AddRange(eternalGoals);

                            break;

                        case 3:
                            //check list goal

                            Console.Write("How many times will you do it?: ");
                            string loopInput = Console.ReadLine();
                            int loop = int.Parse(loopInput);

                            Console.Write("How many bonus points: ");
                            string bonusInput = Console.ReadLine();
                            int bonus = int.Parse(bonusInput);

                            checklistGoals = new List<ChecklistGoal>
                            {
                                //int loopAmt, int amtLooped, int bonusPoint, bool isFinished, int totalPoints, string name, string desription
                                new ChecklistGoal(loop, 0, bonus, false, name, description, points)
                            };
                            break;

                        default:
                            Console.WriteLine("Enter a valid input ");
                            break;
                    }

                    break;
                case 2:
                    //list goals
                    int listnum = 1;
                    foreach(SimpleGoal goal in simpleGoals)
                    {
                        Console.Write($"{listnum}. ");
                        goal.Display();
                        listnum++;
                    }
                    foreach(EternalGoal goal in eternalGoals)
                    {
                        Console.Write($"{listnum}. ");
                        goal.Display();
                        listnum++;
                    }
                    foreach(ChecklistGoal goal in checklistGoals)
                    {
                        Console.Write($"{listnum}. ");
                        goal.Display();
                        listnum++;
                    }

                    break;

                case 3:
                    //save goals

                    goalFileManager.Save(goals);
                    break;

                case 4:
                    //load goals
                    int loadnum =  1;
                    foreach(Goal goal in goals)
                    {
                        Console.Write($"{loadnum}. ");
                        goal.Display();
                        loadnum++;
                    }
                    break;

                case 5:
                    //record event

                    break;

                case 6:
                    //quit
                    break;
            }
        }



    }
}