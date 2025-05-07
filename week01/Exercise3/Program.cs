using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = 0;
        while (guessNumber != magicNumber)
        {
            Console.Write("What... Is the Magic Number?? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            if (guessNumber == magicNumber)
            {
                Console.WriteLine("Yes, That is the magic number!");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("No, thats too low!");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("No, thats too high!");
            }
        }    
    }
}