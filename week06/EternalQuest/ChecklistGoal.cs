using System.IO; 
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public void SetComplete(int stage)
    {
        _amountCompleted = stage;
    }
    public int GetComplete()
    {
        return _amountCompleted;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    public int GetTarget()
    {
        return _target;
    }

    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent()
    {
        if (_isComplete == false)
        {
            if (_amountCompleted < _target)
            {
                _amountCompleted += 1;
                Console.WriteLine($"Congradulations! You have earned {GetPoints()} points!");
                int points = int.Parse(GetPoints());
                Program.totalPoints += points;
            }
            if (_amountCompleted == _target)
            {
                _isComplete = true;
                Console.WriteLine($"Congradulations! You have earned {_bonus} Bonus points for completing a goal!");
                Program.totalPoints += _bonus;
            }
        }
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string GetDetails()
    {
        return $"{GetType().Name}:{_isComplete}|{_name}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetString()
    {
        string complete = _isComplete ? "X" : " ";
        return $"[{complete}] {_name} ({_description} ({_amountCompleted}/{_target}))";
    }
}