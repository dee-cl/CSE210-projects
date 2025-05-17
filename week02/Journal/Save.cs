using System;
using System.Collections.Generic;
using System.IO;

public class Save
{
    public static void SaveJournal(List<Journal> journals)
    {
        Console.WriteLine("What is the name of the file you want to save to?");
        string filepath = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            Console.WriteLine("Saving journal entries...");
            foreach (Journal journal in journals)
            {
                writer.WriteLine($"Date: {journal._date} | Prompt: {journal._prompt} | Response: {journal._response}");
            }
            
        }
    }
}