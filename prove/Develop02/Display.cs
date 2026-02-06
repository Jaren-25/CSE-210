public class Display
{
    public void ReadFile()
    {
        string filename = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string entry = parts[1];
        }
    }

    static void DisplayEntry()
    {
        Console.WriteLine();
    }
}