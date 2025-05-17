using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        List<Journal> journals = new List<Journal>();
        int selection = 0;
        while (selection != 5)
        {



            if (selection == 1) // Write
            {
                Write.WriteJournal(journals);
            }
            if (selection == 2) { // Display
                Display.DisplayJournal(journals);
            }
            if (selection == 3) { // Load
                journals = Load.LoadFile();
            }
            if (selection == 4) { // Save
                Save.SaveJournal(journals);
            }
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");      
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string input = Console.ReadLine();
            selection = int.Parse(input);

        }
    }
}