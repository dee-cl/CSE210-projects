using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Console.Clear();
        scripture.displayList();
        Console.WriteLine("Press Enter to Continue to Type 'Quit' to finish");
        string input = Console.ReadLine();
        while (input != "quit")
        {
            Console.Clear();
            scripture.HideWords();
            scripture.displayList();
            Console.WriteLine("Press Enter to Continue to Type 'Quit' to finish");
            input = Console.ReadLine();
            if (scripture.AllWordsHidden())
            {
                input="quit";
            }
        }
        
        
    }
}