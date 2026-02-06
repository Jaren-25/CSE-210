public class Menu
{
    public void DisplayMenu()
    {
        int response = 0;

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
                entry.PromptGen();
            }

            if (response == 2)
            {
                Display display = new Display();
                display.ReadFile();
            }

            if (response == 3)
            {
                Load load = new Load();
            }

            if (response == 4)
            {
                Save save = new Save();
                //save.SaveFile();
            }
        }
    }
}