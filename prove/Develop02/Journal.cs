public class Journal
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

    public void ReadFile(List<Journal> entries)
    {
        //no other path would work
        string filename = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (Journal entry in entries)
        {
            // string[] parts = line.Split("|");

            // string prompt = parts[0];
            // string date = parts[1];
            // string entry = parts[2];

            Console.WriteLine($"Date: {entry._date} Name: {entry._name}- Prompt: {entry._prompt}");
            Console.WriteLine($"Entry: {entry._response}");

        }
    }

    public void LoadFile(List<Journal> entries){

        Console.WriteLine("Enter a file name");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            // string prompt = parts[0];
            // string date = parts[1];
            // string entry = parts[2];
            Console.WriteLine(line);

        }
    }

    public void SaveFile(List<Journal> entries)
    {
        //no other path would work
        string filename = "Journal.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Journal entry in entries)
            {
                outputfile.Write($"Date: {entry._date} Name: {entry._name} Prompt: {entry._prompt}");
                outputfile.WriteLine($" Entry: {entry._response} |");
            }
        }
    }
}