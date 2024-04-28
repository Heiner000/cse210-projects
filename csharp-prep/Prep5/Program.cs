using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");


        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int favNum = int.Parse(userInput);
            return favNum;
        }
        
        // SquareNumber - Accepts an integer as a parameter and returns that number squared(as an integer)
        static int SquareNumber(int num)
        {
            int numSquared = num * num;
            return numSquared;
        }

        // DisplayResult - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string userName, int numSquared)
        {
            Console.WriteLine($"{userName}, the square of your number is {numSquared}");
        }

        DisplayWelcome();
        string user = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(user, squared);

    }
}