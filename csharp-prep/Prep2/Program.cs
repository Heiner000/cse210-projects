using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int userGrade = int.Parse(valueFromUser);

        if (userGrade >= 90)
        {
            Console.WriteLine("You have an A. ");
        }
        else if (userGrade >= 80)
        {
            Console.WriteLine("You have a B. ");
        }
        else if (userGrade >= 70)
        {
            Console.WriteLine("You have a C. ");
        }
        else if (userGrade >= 60)
        {
            Console.WriteLine("You have a D. ");
        }
        else
        {
            Console.WriteLine("You have an F. ");
        }

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