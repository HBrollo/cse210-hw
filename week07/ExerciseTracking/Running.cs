public class Running : Exercise
{
    private double _distance;

    public Running(int length, double distance) : base(length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        double pace = GetLength() / _distance;
        return pace;
    }
    
    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetLength()) * 60;
        return speed;
    }

}