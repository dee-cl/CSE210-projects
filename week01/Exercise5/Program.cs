using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("welcome to the program!");
        
    }
    static string PromptUserName()
    {
        Console.Write("What is your username? ");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string username, int number, int squared)
    {
        Console.WriteLine($"Hello {username}, your favorite number is {number} and its square is {squared}.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(username, number, squared);
    }
}