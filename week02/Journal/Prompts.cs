using System;
using System.Collections.Generic;
public class Prompts
{
    private static List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What was the worst part of your day?",
        "What did you learn today?",
        "What are you grateful for?",
        "What is something you want to improve on?",
        "What is a goal you want to achieve?",
        "What is something you are proud of?",
        "What is something you want to remember?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    private Random _random = new Random();
    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}