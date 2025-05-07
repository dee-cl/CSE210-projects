using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string input = "null";
        int number = 1;
        int total = 0;
        int count = 0;
        int largest = 0;
        while (number != 0)
        {
            Console.Write("Enter a number input 0 when complete: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
                total += number;
                count += 1;
                if (number > largest)
                {
                    largest = number;
                }

            }
            else
            {
                break;
            }
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);

        }
        Console.WriteLine($"your total is {total}");
        float average = ((float)total) / count;
        Console.WriteLine($"your average is {average}");
        Console.WriteLine($"The largest number is {largest}");
    } 
}