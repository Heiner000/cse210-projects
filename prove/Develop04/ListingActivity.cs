public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {

    };

    public ListingActivity() : base("Listing", "Reflect on good things.")
    {
        _count = 0;
    }

    public void Run()
    {

    }

    private string GetRandomPrompt()
    {
        return "";
    }

    private List<string> GetListFromUser()
    {
        return new List<string>();
    }
}