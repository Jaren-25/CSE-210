public class BreathingActivity : Activity
{
    private string _breathMessage;

    public BreathingActivity()
    {
        _breathMessage = "";
        _duration = 0;
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public BreathingActivity(string breathMessage, int duration, string description, string startMessage, string finishMessage): base(duration, description, startMessage, finishMessage)
    {
        _breathMessage = breathMessage;
        _duration = duration;
        _description = description;
    }

    Activity activity = new Activity();

    private void delay()
    {
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
    }
    public void Breathe()
    {
        DateTime endtime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endtime){
            int currentLine = Console.CursorTop;
            Console.Write("Breathe in");
            delay();
            Console.Write("Hold");
            delay();
            Console.Write("Breath out");
            delay();
            Console.Write("Hold");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLine);

            Console.WriteLine(_duration);
        }
    }
}

