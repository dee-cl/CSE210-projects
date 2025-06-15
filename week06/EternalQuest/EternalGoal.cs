using System.IO; 
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congradulations! You have earned {GetPoints()} points!");
        int points = int.Parse(GetPoints());
        Program.totalPoints += points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
}
