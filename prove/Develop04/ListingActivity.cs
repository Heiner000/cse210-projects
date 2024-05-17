public class ListingActivity : Activity
{
    // private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity() : base("Listing", "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetRandomPrompt());
        ShowCountdown(3);

        List<string> items = GetListFromUser();

        Console.WriteLine($"You listed {items.Count} items.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // private List<string> GetListFromUser()
    // {
    //     List<string> items = new List<string>();
    //     DateTime endTime = DateTime.Now.AddSeconds(_duration);
    //     while (DateTime.Now < endTime)
    //     {
    //         Console.Write("List item: ");
    //         items.Add(Console.ReadLine());
    //         _count++;
    //     }
    //     return items;
    // }
}