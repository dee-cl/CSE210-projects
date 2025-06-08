using System;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start Reflecting Activity");
        Console.WriteLine("  3. Start Listing Activity");
        Console.WriteLine("  4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string Answer = Console.ReadLine();

        if (int.Parse(Answer) == 1)
        {
            Console.Clear();
            BreathingActivity activity = new BreathingActivity();
            activity.SetName("Breathing Activity");
            Console.WriteLine(activity.DisplayStartingMessage());
            activity.Run();
            activity.DisplayEndingMessage();
        }
        if (int.Parse(Answer) == 2)
        {
            Console.Clear();
            ReflectingActivity activity = new ReflectingActivity();
            activity.SetName("Reflecting Activity");
            Console.WriteLine(activity.DisplayStartingMessage());
            activity.Run();
            activity.DisplayEndingMessage();
        }
        if (int.Parse(Answer) == 3)
        {
            Console.Clear();
            ListingActivity activity = new ListingActivity();
            activity.SetName("Listing Activity");
            Console.WriteLine(activity.DisplayStartingMessage());
            activity.Run();
            activity.DisplayEndingMessage();
        }
    }
}