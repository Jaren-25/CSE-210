public class Display
{
    public void ReadFile(List<Entry> entries)
    {
        //no other path would work
        string filename = "C:/Users/Jaren/OneDrive - BYU-Idaho/CSE-210/prove/Develop02/Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (Entry entry in entries)
        {
            // string[] parts = line.Split("|");

            // string prompt = parts[0];
            // string date = parts[1];
            // string entry = parts[2];

            Console.WriteLine($"Date: {entry._date} Name: {entry._name}- Prompt: {entry._prompt}");
            Console.WriteLine($"Entry: {entry._response}");

        }
    }
}