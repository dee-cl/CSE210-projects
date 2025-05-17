using System;

public class Display
{
    public static void DisplayJournal(List<Journal> journals)
    {
        foreach (var journal in journals)
        {
            Console.WriteLine($"Date: {journal._date}");
            Console.WriteLine($"Prompt: {journal._prompt}");
            Console.WriteLine($"Response: {journal._response}");
            Console.WriteLine();
        }
    }
}