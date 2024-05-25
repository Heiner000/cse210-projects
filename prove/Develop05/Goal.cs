public class Goal
{
    public string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
    }

    public void RecordEvent()
    {
    }

    public bool IsComplete()
    {
        return false;
    }

    public string GetDetailsString()
    {
        return $"{_description}";
    }

    public string GetStringRepresentation()
    {
        return "";
    }
}