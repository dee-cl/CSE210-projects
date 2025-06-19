using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling c1 = new Cycling(5, .5, "3/12/21");
        Console.WriteLine($"{c1.GetSummary()}");
        Swimming s1 = new Swimming(10, 10, "3/12/21");
        Console.WriteLine($"{s1.GetSummary()}");
        Running r1 = new Running(10, 120, "3/12/21");
        Console.WriteLine($"{r1.GetSummary()}");
    }
}