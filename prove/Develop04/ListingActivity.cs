using System.Net;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _responses;
    public ListingActivity()
    {
        _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        _responses = new List<string>{};
        _duration = 0;
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public ListingActivity(List<string> prompts, int duration, string description, string startMessage, string finishMessage): base(duration, description, startMessage, finishMessage)
    {
        _prompts = prompts;
        _duration = duration;
        _description = description;
    }

    public string RandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string randPrompt = prompts[index];

        return randPrompt;
    }

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public void countdown()
    {
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("1");

    }
    public void RecordResponses()
    {
        Console.Write("write your answers: ");
        string responses = Console.ReadLine();
        _responses.Add(responses);
        string filename = "Responses.txt";
        using(StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach(string r in _responses)
            {
                outputfile.WriteLine($"{r} |");
            }
        }
    }

    public int countResponses()
    {
        return _responses.Count;
    }

}