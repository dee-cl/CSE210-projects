using System.Reflection;
using System.IO; 

public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        base.RecordEvent();
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetString()
    {
        return base.GetString();
    }





}