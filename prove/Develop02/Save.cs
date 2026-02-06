using System.IO;
public class Save
{
    public static void SaveFile(string today, string response)
    {
        string filename = "Journal.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine("AAAAAAAA");
            outputfile.WriteLine(today);
            outputfile.WriteLine(response);
        }
    }
}