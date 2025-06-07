using System.Diagnostics;

public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public Assignment()
    {

    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string GetName()
    {
        return _studentName;
    }

    public void SetName(string name)
    {
        _studentName = name;
    }

    public String GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"Name: {_studentName} \nAssignment topic: {_topic}";
    }
}