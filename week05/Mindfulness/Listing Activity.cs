public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _inputsList;

    public ListingActivity()
    {

    }

    public void Run()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("\nHow long, in seconds, would you like for your session?");
        string seconds = Console.ReadLine();
        SetDuration(int.Parse(seconds));
        int time = int.Parse(seconds);
        _inputsList = new List<string>();
        Console.Clear();
        Console.WriteLine("Get ready to begin");
        ShowSpinner(5);
        Console.WriteLine("List as many responsews as you can to the following prompt");
        GetRandomPrompt();
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        Console.WriteLine($"you listed {_inputsList.Count} items");




    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        int _num = _prompts.Count;
        int randomIndex = random.Next(0, _num);
        Console.WriteLine(_prompts[randomIndex] + "\n");
    }

    public List<string> GetListFromUser()
    {
        var inputsList = new List<string>();
        {
            string item = Console.ReadLine();
            _inputsList.Add(item);
        }
        ;
        return inputsList;
        
    }

}