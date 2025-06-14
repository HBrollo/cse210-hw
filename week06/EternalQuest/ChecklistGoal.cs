public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override string GetStringRepresentation()
    {
        string completeStatus;
        if (_amountCompleted == _target)
        {
            completeStatus = "[X]";
        }
        else
        {
            completeStatus = "[ ]";
        }

        string stringRepresentation = $"{completeStatus} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        return stringRepresentation;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You have earned {_bonus + _points} points!");
            return _bonus + _points;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }

    }
    public override string GetSaveString()
    {
        return $"{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}