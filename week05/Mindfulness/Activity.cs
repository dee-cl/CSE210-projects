using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string startingMesage;
    public string DisplayStartingMessage()
    {
        return $"Welcome to the {_name}";
    }
    public string endingMessage;
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
    }

    public void ShowSpinner(int seconds)
    {
        int x = 0;
        int i = 0;
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        while (x < seconds)
        {
            x++;
            Console.Write(spinner[i]);
            Thread.Sleep(1000);
            Console.Write("\b");
            i++;
            if (i >= 4)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        int countDown = seconds;
        int y = 0;
        while (y < countDown)
        {
            
            Console.Write($"{countDown}...");
            Thread.Sleep(1000);
            countDown--;
            Console.Write("\b\b\b\b");
        }
    }


}