using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");

        int input = 0;

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

            string filename = "goals.txt";
            SimpleGoal simpleGoal = new SimpleGoal();
            EternalGoal eternalGoal = new EternalGoal();
            ChecklistGoal checklistGoal = new ChecklistGoal();

            GoalFileManager goalFileManager = new GoalFileManager(filename);
            List<Goal> goals = goalFileManager.Load();



            switch (input)
            {
                case 1:
                    //main menu
                    int goalType = 0;

                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine(" 1. Simple Goal");
                    Console.WriteLine(" 2. Eternal Goal");
                    Console.WriteLine(" 3. Checklist Goal");

                    Console.Write("Select a goal type the menu: ");
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
                            List<SimpleGoal> simpleGoals = new List<SimpleGoal>
                            {
                                //bool isFinished, string name, string desription, int goalPoints
                                new SimpleGoal(false, name, description, points)
                            };

                            goals.AddRange(simpleGoals);

                            break;

                        case 2:
                            //eternal goal
                            List<EternalGoal> eternalGoals = new List<EternalGoal>
                            {
                                new EternalGoal()
                            };

                            goals.AddRange(eternalGoals);

                            break;

                        case 3:
                            //check list goal
                            List<ChecklistGoal> checklistGoals = new List<ChecklistGoal>
                            {
                                new ChecklistGoal()
                            };
                            break;

                        default:
                            Console.WriteLine("Enter a valid input ");
                            break;
                    }

                    break;
                case 2:
                    //list goals

                    break;

                case 3:
                    //save goals
                    goalFileManager.Save(goals);
                    break;

                case 4:
                    //load goals
                    foreach(Goal goal in goals)
                    {
                        goal.Display();
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