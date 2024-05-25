public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }
}