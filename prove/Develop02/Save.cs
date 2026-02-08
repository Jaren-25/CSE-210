using System.IO;
public class Save
{

    public void SaveFile(List<Entry> entries)
    {
        //no other path would work
        string filename = "C:/Users/Jaren/OneDrive - BYU-Idaho/CSE-210/prove/Develop02/Journal.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputfile.Write($"Date: {entry._date} Name: {entry._name} Prompt: {entry._prompt}");
                outputfile.WriteLine($" Entry: {entry._response} |");
            }
        }
    }
}