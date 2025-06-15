using System.IO; 
public class Goal
{
    protected string _name;
    protected string _description;
    protected string _points;

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }

    public string GetPoints()
    {
        return _points;
    }


    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public virtual void RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            Console.WriteLine($"Congradulations! You have earned {_points} points!");
            int points = int.Parse(_points);
            Program.totalPoints += points;
        }
        else
        {
            Console.WriteLine("That goal has already been completed");
        }
    }
    protected bool _isComplete = false;
    public bool SetIsComplete(bool input)
    {
        _isComplete = input;
        return _isComplete;
    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public virtual bool IsComplete()
    {
        return _isComplete;

    }
    public virtual string GetDetails()
    {
        return $"{GetType().Name}:{_isComplete}|{_name}|{_description}|{_points}";
    }

    public virtual string GetString()
    {
        string complete = _isComplete ? "X" : " ";
        return $"[{complete}] {_name} ({_description})";
    }



}