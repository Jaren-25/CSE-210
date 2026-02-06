public class Entry
{
    public string PromptGen()
    {
        List<string> prompts = new List<string>() {"What is a good thing that happened today?", "A hard thing from today?", "Something someone did nice for you today?", "What was the strongest emotion I felt today?", "What was the best part of today?"};

        Random random = new Random();
        int randomPrompt = random.Next(0,5);

        string prompt = prompts[randomPrompt];

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        DateTime day = DateTime.Today;
        string today = day.ToString();


        Save.SaveFile(today, response);

        return response;
    }

    // public string Date()
    // {
    //     DateTime day = DateTime.Today;
    //     string today = day.ToString();

    //     return today;
    // }


}
