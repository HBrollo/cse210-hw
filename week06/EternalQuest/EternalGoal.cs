public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    { }
    public override string GetStringRepresentation()
    {
        string completeStatus = "[ ]";
        string stringRepresentation = $"{completeStatus} {_shortName} ({_description})";
        return stringRepresentation;
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }
    public override string GetSaveString()
    {
        return $"{_shortName},{_description},{_points}";
    }
}