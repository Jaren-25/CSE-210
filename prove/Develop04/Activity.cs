using System.Net.Http.Headers;

public class Activity
{
    protected int _duration;
    protected string _description;
    private  string _startMessage;
    private string _finishMessage;
    private bool _timer;


    public Activity(int duration,string description, string startMessage, string finishMessage){
        _duration = duration;
        _description = description;
        _startMessage = startMessage;
        _finishMessage = finishMessage;
    }

    public Activity(){
        _duration = 0;
        _startMessage = $"Get ready...";
        _finishMessage = "Well done!";
    }

    public string StartMessage(string startMessage)
    {
        _startMessage = startMessage;
        return _startMessage;
    }

    public void Animation()
    {   int i = 0;
        while (i < 5){
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
        }
        //return "";
    }

    public bool Duration(int _duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(1000);

        DateTime currentTime = DateTime.Now;

        // Console.WriteLine($"Start time: {startTime}");
        // Console.WriteLine($"Current time: {currentTime}");
        // Console.WriteLine($"Furture time: {futureTime}");

        if(currentTime < futureTime)
        {
            //Console.WriteLine("We have not arrived at our future time yet...");
            // _timer = false;
            // return _timer;
        }
        _timer = true;
        return _timer;
    }

    public int UserDuration()
    {
        //int duration = 0;
        Console.WriteLine("Input a duration: ");
        string durInput = Console.ReadLine();
        _duration = int.Parse(durInput);
        return _duration;

    }

    public string getStartMessage()
    {
        return _startMessage;
    }
    public string getDescription()
    {
        return _description;
    }
    public string getFinishMessage()
    {
        return _finishMessage;
    }
    public int getDuration()
    {
        //Console.WriteLine(_duration);
        return _duration;
    }

    public bool getTimer()
    {
        return _timer;
    }
    public void setDuration(int duration)
    {
        _duration = duration;
        Duration(_duration);
    }


}