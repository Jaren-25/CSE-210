public class Entry
{

    public string _prompt;
    public string _date;
    public string _response;
    public string _name;
    public (string today, string response, string prompt, string name) PromptGen()
    {
        List<string> prompts = new List<string>() {"What is a good thing that happened today?", "A hard thing from today?", "Something someone did nice for you today?", "What was the strongest emotion I felt today?", "What was the best part of today?"};

        Random random = new Random();
        int randomPrompt = random.Next(0,5);

        string prompt = prompts[randomPrompt];

        Console.WriteLine("Enter your Name: ");
        string name = Console.ReadLine();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        DateTime day = DateTime.Now;
        string today = day.ToString();

        return (today, response, prompt, name);
    }
}
