using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override string GetStringRepresentation()
    {
        string completeStatus;
        if (_isComplete)
        {
            completeStatus = "[X]";
        }
        else
        {
            completeStatus = "[ ]";
        }
        string stringRepresentation = $"{completeStatus} {_shortName} ({_description})";
        return stringRepresentation;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }
    public override string GetSaveString()
    {
        return $"{_shortName},{_description},{_points},{_isComplete}";
    }
}