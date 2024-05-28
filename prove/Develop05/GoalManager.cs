using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu: ");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Quit");
            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    Console.WriteLine();
                    break;
                case "2":
                    ListGoalNames();
                    Console.WriteLine();
                    break;
                case "3":
                    ListGoalDetails();
                    Console.WriteLine();
                    break;
                case "4":
                    CreateGoal();
                    Console.WriteLine();
                    break;
                case "5":
                    RecordEvent();
                    Console.WriteLine();
                    break;
                case "6":
                    SaveGoals();
                    Console.WriteLine();
                    break;
                case "7":
                    LoadGoals();
                    Console.WriteLine();
                    break;
                case "8":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetShortName()); 
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (1 - Simple, 2 - Eternal, 3 - Checklist): ");
        string type = Console.ReadLine();

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (type)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.WriteLine("Enter target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid option, try again.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter the name of the goal you accomplished: ");
        string name = Console.ReadLine();

        foreach (Goal goal in _goals)
        {
            if (goal.GetShortName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                _score += goal.RecordEvent();
                Console.WriteLine("Event recorded successfully.");
                return;
            }
        }

        Console.WriteLine("Goal not found.");
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

        Console.WriteLine("Goals saved successfully.");        
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name? ");
        string file = Console.ReadLine();

        // read file text
        string[] lines = System.IO.File.ReadAllLines(file);

        _goals.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split(" | ");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            Goal goal = null;

            switch (type)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[4]);
                    goal = new SimpleGoal(name, description, points);
                    ((SimpleGoal)goal).SetIsComplete(isComplete);
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(name, description, points);
                    break;
                case "ChecklistGoal":
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    goal = new ChecklistGoal(name, description, points, target, bonus);
                    ((ChecklistGoal)goal).SetAmountCompleted(amountCompleted);
                    break;
            }
            _goals.Add(goal);
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}