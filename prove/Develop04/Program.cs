using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        int user = 0;

        while (user != 5)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Load listing activity");
            Console.WriteLine(" 5. Quit");

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            user = int.Parse(userInput);

            int duration =0;

            Activity activity = new Activity();

            switch (user)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    Console.WriteLine(activity.getStartMessage());
                    activity.Animation();
                    Console.WriteLine(breathing.getDescription());
                    duration = activity.UserDuration();
                    breathing.setDuration(duration);
                    breathing.Breathe();
                    Console.WriteLine(activity.getFinishMessage());
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    Console.WriteLine(activity.getStartMessage());
                    activity.Animation();
                    Console.WriteLine(reflectingActivity.getDescription());
                    duration = activity.UserDuration();
                    reflectingActivity.setDuration(duration);
                    Console.WriteLine(reflectingActivity.RandomPrompt(reflectingActivity.GetPrompts()));
                    DateTime endtime = DateTime.Now.AddSeconds(reflectingActivity.getDuration());

                    while (DateTime.Now < endtime)
                    {
                        Console.WriteLine(reflectingActivity.RandomQuestion(reflectingActivity.GetQuestions()));
                        Thread.Sleep(2000);
                    }

                    reflectingActivity.getFinishMessage();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    Console.WriteLine(listingActivity.getStartMessage());
                    activity.Animation();
                    Console.WriteLine(listingActivity.getDescription());
                    duration = activity.UserDuration();
                    listingActivity.setDuration(duration);
                    Console.WriteLine(listingActivity.RandomPrompt(listingActivity.GetPrompts()));
                    listingActivity.countdown();
                    endtime = DateTime.Now.AddSeconds(listingActivity.getDuration());

                    while (DateTime.Now < endtime)
                    {
                        listingActivity.RecordResponses();
                    }

                    Console.WriteLine(listingActivity.countResponses());
                    listingActivity.getFinishMessage();
                    break;

                case 4:
                    string[] lines = System.IO.File.ReadAllLines("Responses.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("|");
                        Console.WriteLine(line);
                    }
                    
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    break;
            }

        }
    }
}