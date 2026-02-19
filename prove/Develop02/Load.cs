using System.Data;

public class Load
{
    public void LoadFile(List<Entry> entries){

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
}