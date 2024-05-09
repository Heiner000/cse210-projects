using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("S C R I P T U R E   M E M O R I Z E R");

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text1 = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text1);

        Console.WriteLine($"{scripture.GetDisplayText()}");

        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        Console.ReadLine();
    }
}