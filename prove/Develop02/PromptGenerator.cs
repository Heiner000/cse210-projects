public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did I invest in my future today?",
        "What was the tastiest thing I ate today?",
        "How much money did I spend today?",
        "How much money did I earn today?",
        "Who did I reach out to today and how are they doing?"
    };

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int magicNumber = randomPrompt.Next(_prompts.Count);
        return _prompts[magicNumber];
    }
}