public class ReflectingActivity : Activity
{

    private string _prompt;
    private List<string> _prompts;
    private List<string> _questions;



    public ReflectingActivity()
    {
        _prompt = "";
        _duration = 5;
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    }
    public ReflectingActivity(string prompt, int duration, string description, string startMessage, string finishMessage, List<string> prompts, List<string> questions): base(duration, description, startMessage, finishMessage)
    {
        _prompt = prompt;
        _duration = duration;
        _description = description;
        _prompts = prompts;
        _questions = questions;
    }

    public string RandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string randPrompt = prompts[index];

        return randPrompt;
    }

    public string RandomQuestion(List<string> questions)
    {
        Random random = new Random();
        int index = random.Next(questions.Count);
        string randQuestion = questions[index];

        return randQuestion;
    }

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public List<string> GetQuestions()
    {
        return _questions;
    }


}