using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Delta", "classwork");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Dave", "Math", "1.3", "1-20");
        Console.WriteLine(math1.GetMathInfo());
        Console.WriteLine(math1.GetSummary());

        WritingAssignment w1 = new WritingAssignment("Thomas", "English", "The Long Road Ahead");
        Console.WriteLine(w1.GetWritingInformation());
        Console.WriteLine(w1.GetSummary());
    }
}