public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
        return _amountCompleted >= _target ? _points + _bonus : _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} : {_description} - {_amountCompleted}/{_target} times completed";
    }

    public void SetAmountCompleted(int count)
    {
        _amountCompleted = count;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal | {_shortName} | {_description} | {_points} | {_amountCompleted} | {_target} | {_bonus}";
    }

}