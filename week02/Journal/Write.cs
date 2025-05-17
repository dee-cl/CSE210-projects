using System;
using System.Collections.Generic;
using System.IO;

public class Write
{
    public static void WriteJournal(List<Journal> journals)
    {
        string prompt = Prompts.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Journal journal = new Journal();

        string date = DateTime.Now.ToString("MM/dd/yyyy");

        journal._date = date;
        journal._prompt = prompt;
        journal._response = response;

        journals.Add(journal);
    }
}
