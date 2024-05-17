public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        int duration = _duration;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in. . . ");
            ShowCountdown(3);
            Console.WriteLine("Breathe out. . . ");
            ShowCountdown(3);
        }
        DisplayEndingMessage();
    }    
}