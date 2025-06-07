using System.Runtime.CompilerServices;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public string GetSection()
    {
        return _textbookSection;
    }
    public void SetSection(string section)
    {
        _textbookSection = section;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public MathAssignment() : base()
    {

    }
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    } 

    public string GetMathInfo()
    {
        return $"Name: {_studentName} \nAssignment topic: {_topic} \nSection: {_textbookSection}\nProblems: {_problems}";
    }

}

    