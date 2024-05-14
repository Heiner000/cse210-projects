using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment test1 = new Assignment("Samuel Bennet", "Multiplication");

        Console.WriteLine(test1.GetSummary());
        System.Console.WriteLine();

        MathAssignment test2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        System.Console.WriteLine(test2.GetSummary());
        System.Console.WriteLine(test2.GetHomeworkList());
        System.Console.WriteLine();

        WritingAssignment test3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        System.Console.WriteLine(test3.GetSummary());
        System.Console.WriteLine(test3.GetWritingInformation());
        System.Console.WriteLine();
    }
}