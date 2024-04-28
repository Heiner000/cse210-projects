using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int userGrade = int.Parse(valueFromUser);
        string letterGrade;

        if (userGrade >= 90)
        {
            // Console.WriteLine("You have an A. ");
            letterGrade = "A";
        }
        else if (userGrade >= 80)
        {
            // Console.WriteLine("You have a B. ");
            letterGrade = "B";
        }
        else if (userGrade >= 70)
        {
            // Console.WriteLine("You have a C. ");
            letterGrade = "C";
        }
        else if (userGrade >= 60)
        {
            // Console.WriteLine("You have a D. ");
            letterGrade = "D";
        }
        else
        {
            // Console.WriteLine("You have an F. ");
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade: {letterGrade}");

        if (userGrade > 70)
        {
            Console.WriteLine("Congrats, you've passed the class! ");
        }
        else
        {
            Console.WriteLine("You didn't pass, you'll do better next semester.");
        }

    }
}