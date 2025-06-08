using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {

    }

    public void Run()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("\nHow long, in seconds, would you like for your session?");
        string seconds = Console.ReadLine();
        SetDuration(int.Parse(seconds));
        Console.WriteLine("Get ready to begin");
        ShowSpinner(5);
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("When you have something in mind press enter");
        Console.ReadLine();
        Console.WriteLine("Ponder on each of the following questions as they relate to this experience.");
        ShowCountDown(5);
        int x = 0;
        while (x < GetDuration())
        {
            Console.Clear();
            GetRandomQuestion();
            ShowSpinner(5);
            x += 5;
        }

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        int _count = _prompts.Count;
        int randomIndex = random.Next(0, _count);
        Console.WriteLine(_prompts[randomIndex] + "\n");
    }
    public void GetRandomQuestion()
    {
        Random random = new Random();
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
           "How can you keep this experience in mind in the future?"
        };
        int count = _questions.Count;
        int randomIndex = random.Next(0, count);
        Console.WriteLine(_questions[randomIndex] + "\n");
    }

}