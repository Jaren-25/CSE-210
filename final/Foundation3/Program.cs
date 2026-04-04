class Program
{
    static void Main(string[] args)
    {
        //totally real addresses
        Address lectureAddress = new Address("Main St.", "Rexburg", "Hawaii", "Canada");
        Address receptionsAddress = new Address("2nd Dr.", "Queens", "Montana", "USA");
        Address outdoorAddress = new Address("5th Ct.", "Crystal cove", "Colorado", "Mexico");

        Lectures lectures = new Lectures("Alvin Meridith", "1300\u03C0/3", "Calculus", "Calc 1", "2-31-28", "12:57", lectureAddress);

        Receptions receptions = new Receptions("RSVP@email", "Welders unite", "Welders come together", "13-31-27", "13:65", receptionsAddress);

        Outdoor outdoor = new Outdoor(true, "Tornado watchers", "Watch tornados together", "4-9-26", "00:00", outdoorAddress);


        lectures.StandardDisplay();
        Console.WriteLine();

        lectures.FullDisplay();
        Console.WriteLine();

        lectures.ShortDisplay();

        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine();

        receptions.StandardDisplay();
        Console.WriteLine();

        receptions.FullDisplay();
        Console.WriteLine();

        receptions.ShortDisplay();

        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine();

        outdoor.StandardDisplay();
        Console.WriteLine();

        outdoor.FullDisplay();
        Console.WriteLine();

        outdoor.ShortDisplay();

    }
}