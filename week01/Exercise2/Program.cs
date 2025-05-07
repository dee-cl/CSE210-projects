using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your final grade? ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);
        string passFail = "null";
        string letter = "null";
        if (grade >= 90)
        {
            letter = "A";
            if (grade >= 70)
            {
                passFail = "Pass";
            }
            else
            {
                passFail = "Fail";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";
            if (grade >= 70)
            {
                passFail = "Pass";
            }
            else
            {
                passFail = "Fail";
            }
        }
        else if (grade >= 70)
        {
            letter = "C";
            if (grade >= 70)
            {
                passFail = "Pass";
            }
            else
            {
                passFail = "Fail";
            }
        }
        else if (grade >= 60)
        {
            letter = "d";
            if (grade >= 70)
            {
                passFail = "Pass";
            }
            else
            {
                passFail = "Fail";
            }
        }
        else if (grade < 60)
        {
            letter = "F";
            if (grade >= 70)
            {
                passFail = "Pass";
            }
            else
            {
                passFail = "Fail";
            }
        }
        if (passFail == "Pass")
        {
            Console.WriteLine("Congradulations! You passed the Course!");
        }
        if (passFail == "Fail")
        {
            Console.WriteLine("Sorry, You did not pass the course but keep studying!");
        }
        Console.WriteLine($"With a grade of {grade}%, you get a letter grade of {letter}.");
    }
}