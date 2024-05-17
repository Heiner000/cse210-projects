public class GratitudeActivity : Activity
{
    private int _count;
    private int _goal;
    
    public GratitudeActivity() : base("Gratitude", "\nThis activity will help you develop an attitude of gratitude by counting your blessings. List at least 3 different things you're grateful for.")
    {
        _count = 0;
        _goal = 3;
    }

    public override void Run()
    {
        DisplayStartingMessage();

        List<string> items = GetListFromUser();

        if (items.Count < _goal)
        {
            Console.WriteLine($"You only listed {items.Count} things you're grateful for. Try increasing the duration to think of at least {_goal} things.");
        }
        else 
        {
            Console.WriteLine($"You listed {items.Count} items. You're developing an attitude of gratitude! Next time see if you can list one or two more!");
        }

        DisplayEndingMessage();
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("List item: ");
            items.Add(Console.ReadLine());
            _count++;
        }
        return items;
    }
}