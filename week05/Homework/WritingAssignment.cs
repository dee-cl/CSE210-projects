public class WritingAssignment : Assignment
{
    protected string _title;

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public WritingAssignment() : base()
    {

    }

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"Name: {_studentName}\nTopic: {_topic}\nTitle: {_title}";
    }


}