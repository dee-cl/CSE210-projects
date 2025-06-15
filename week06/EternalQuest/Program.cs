using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.IO;
using System.Linq.Expressions;

class Program
{
    public static int totalPoints = 0;
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                string p = goal.GetPoints();
                int point = int.Parse(p);
                totalPoints += point;
            }
        }
        string choice = "0";
        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine($"You Have {totalPoints} points \n\nMenu options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Events\n6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("The types of goal are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create?");
                string goaltype = Console.ReadLine();
                if (goaltype == "1")
                {
                    //create simple goal
                    Console.Clear();
                    Console.WriteLine("What is the name of the goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Give a short description of the goal.");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many points will this goal be worth?");
                    string points = Console.ReadLine();
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    _goals.Add(goal);
                }
                if (goaltype == "2")
                {
                    //create Eternal Goal
                    Console.Clear();
                    Console.WriteLine("What is the name of the goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Give a short description of the goal.");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many points will this goal be worth?");
                    string points = Console.ReadLine();
                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                if (goaltype == "3")
                {
                    //create Checklist Goal
                    Console.Clear();
                    Console.WriteLine("What is the name of the goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Give a short description of the goal.");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many points will this goal be worth?");
                    string points = Console.ReadLine();
                    Console.WriteLine("How many times do you need to meet this goal?");
                    int target = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing this goal?");
                    int bonus = int.Parse(Console.ReadLine());
                    int amountCompleted = 0;
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                    _goals.Add(goal);
                }
            }
            if (choice == "2")
            {
                //list goals
                if (_goals.Count == 0)
                {
                    Console.WriteLine("No goals to display. Please create a goal first.");
                }
                else
                {
                    foreach (Goal goal in _goals)
                    {
                        Console.WriteLine($"{goal.GetString()} ");
                    }
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            if (choice == "3")
            {
                //Save Goals list in text file
                Console.WriteLine("Please enter a filename to save your goals to. (ex: filename.txt)");
                string filename = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(Program.totalPoints);
                    foreach (Goal goal in _goals)
                    {
                        writer.WriteLine(goal.GetDetails());
                    }
                }
                Console.WriteLine("Save Complete");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            if (choice == "4")
            {
                //Load Goals from text file
                Console.WriteLine("Please enter the file your goals are saved in (ex: goals.txt):");
                string filename = Console.ReadLine();
                if (File.Exists(filename))
                {
                    string[] line = File.ReadAllLines(filename);
                    if (line.Length > 0)
                    {
                        Program.totalPoints = int.Parse(line[0]);
                        _goals.Clear();
                        for (int i = 1; i < line.Length; i++)
                        {
                            string linepart = line[i];
                            string[] part = linepart.Split("|");
                            if (linepart.StartsWith("SimpleGoal:"))
                            {
                                string[] type = part[0].Split(":");
                                bool isComplete = bool.Parse(type[1]);
                                string name = part[1];
                                string description = part[2];
                                string points = part[3];
                                var goal = new SimpleGoal(name, description, points);
                                if (isComplete)
                                    goal.SetIsComplete(true);
                                _goals.Add(goal);
                            }
                            else if (linepart.StartsWith("EternalGoal:"))
                            {
                                string[] type = part[0].Split(":");
                                bool isComplete = bool.Parse(type[1]);
                                string name = part[1];
                                string description = part[2];
                                string points = part[3];
                                var goal = new EternalGoal(name, description, points);
                                _goals.Add(goal);
                            }
                            else if (linepart.StartsWith("ChecklistGoal"))
                            {
                                string[] type = part[0].Split(":");
                                bool isComplete = bool.Parse(type[1]);
                                string name = part[1];
                                string description = part[2];
                                string points = part[3];
                                int amountCompleted = int.Parse(part[4]);
                                int target = int.Parse(part[5]);
                                int bonus = int.Parse(part[6]);
                                var goal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                                 if (isComplete)
                                    goal.SetIsComplete(true);
                                _goals.Add(goal);
                            }
                        }
                        Console.WriteLine("Loaded Successfully");
                    }
                    else
                    {
                        Console.WriteLine("File is empty");
                    }
                }
                else
                {
                    Console.WriteLine("Unable to find file");
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            if (choice == "5")
            {
                //record Events to later be saved
                if (_goals.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("No goals to record. Please create a goal first.");
                }
                else
                {
                    Console.WriteLine($"What goal would you like to record?");
                    int index = 1;
                    foreach (Goal goal in _goals)
                    {
                        Console.WriteLine($"{index}. {goal.GetName()}");
                        index += 1;
                    }
                    string selector = Console.ReadLine();
                    int num = int.Parse(selector);
                    if ((num - 1) >= 0 && (num - 1) < _goals.Count)
                    {
                        _goals[num - 1].RecordEvent();
                        Console.WriteLine($"You have {totalPoints} Points.");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                    }
                }
            }
            if (choice == "6")
            {
                //quit
            }


        }
    }
}