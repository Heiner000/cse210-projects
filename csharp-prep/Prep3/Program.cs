using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        
    }
}