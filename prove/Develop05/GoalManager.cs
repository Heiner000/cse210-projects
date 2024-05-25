using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;

    private int _score;

    public GoalManager()
    {
    }

    public void Start()
    {
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal._shortName);
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            // list goal details
        }
    }

    public void CreateGoal()
    {
    }

    public void RecordEvent()
    {
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name? ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name? ");
        string file = Console.ReadLine();

        // read file text
        // string[] lines = System.IO.File.ReadAllLines(file);

        // save into Goal list?

    }
}