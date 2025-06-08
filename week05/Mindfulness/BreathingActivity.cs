public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        
    }
    public void Run()
    {
        Console.WriteLine("\nThis activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("\nHow long, in seconds, would you like for your session?");
        string seconds = Console.ReadLine();
        ShowSpinner(5);
        SetDuration(int.Parse(seconds));
        Console.WriteLine("Get ready to begin in");
        ShowCountDown(5);
        int x = 0;
        while (x < GetDuration())
        {
            Console.WriteLine("Breathe in ");
            ShowCountDown(4);
            Console.WriteLine("Breathe out");
            ShowCountDown(6);
            x += 10;
        }
    }
}