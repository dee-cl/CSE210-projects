using System;
using System.Collections.Generic;
using System.IO;

public class Load
{
    public static List<Journal> LoadFile()
    {
        List<Journal> journals = new List<Journal>();
        Console.WriteLine("What is the name of the file you want to load?");
        string filepath = Console.ReadLine();
        if (File.Exists(filepath))
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                Console.WriteLine("Loading Journal Entries...");
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    if (parts.Length == 3)
                    {
                        Journal journal = new Journal();
                        journal._date = parts[0].Split(":")[1].Trim();
                        journal._prompt = parts[1].Split(":")[1].Trim();
                        journal._response = parts[2].Split(":")[1].Trim();
                        journals.Add(journal);
                    }
                }

            }
            Console.WriteLine("Journal entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        return journals;
    }
}