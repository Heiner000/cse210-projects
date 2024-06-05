using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine("\nLet's Get Physical! Physical!\n");

        Running running = new Running("06-06-2023", 15, 2.0);
        Cycling cycling = new Cycling("07-04-2023", 55, 17.0);
        Swimming swimming = new Swimming("05-08-2024", 20, 10);

        List<Activity> activities =  new List<Activity> { running, cycling, swimming };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}