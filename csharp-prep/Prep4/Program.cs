using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int num;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            num = int.Parse(userInput);
            if (num != 0)
            {
                numbers.Add(num);
            }

        } while (num != 0);

        // Console.WriteLine(numbers.Count);

        int sum = 0;
        float average = 0;
        int biggest = 0;

        foreach (int item in numbers)
        {
            // Console.WriteLine(num);
            sum += item;

            if (item > biggest)
            {
                biggest = item;
            }
        }

        average = ((float)sum / numbers.Count);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggest}");

    }
}