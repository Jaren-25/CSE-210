public class Menu
{
    public List<Entry> entries = new List<Entry>();
    public void DisplayMenu()
    {
        int response = 0;
        // string today = "";
        // string entryResponse = "";
        // string prompt = "";

        while(response != 5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string responseInput = Console.ReadLine();
            response = int.Parse(responseInput);

            if (response == 1)
            {
                Entry entry = new Entry();
                (entry._date, entry._response, entry._prompt, entry._name) = entry.PromptGen();
                entries.Add(entry);
            }

            if (response == 2)
            {
                Display display = new Display();
                display.ReadFile(entries);
            }

            if (response == 3)
            {
                Load load = new Load();
                load.LoadFile(entries);
            }

            if (response == 4)
            {
                Save save = new Save();

                save.SaveFile(entries);
            }
        }
    }
}