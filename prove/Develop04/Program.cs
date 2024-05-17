class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        Console.WriteLine("Let's Practice Mindfulness!!");

        while (true)
        {
            Console.WriteLine("\nSelect an activity: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string userInput = Console.ReadLine();
            Activity activity = null;

            if (userInput == "1")
            {
                activity = new BreathingActivity();
                // break;
            }
            else if (userInput == "2")
            {
                activity = new ReflectingActivity();
                // break;
            }
            else if (userInput == "3")
            {
                activity = new ListingActivity();
                // break;
            }
            else if (userInput == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
                continue;
            }

            activity.Run();
        }
    }
}