public class Cycling : Exercise
{
    private int _speed;

    public Cycling(int length, int speed) : base(length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double timeHours = GetLength() / 60.0;
        double distance = _speed * timeHours;
        return distance;
    }

    public override double GetPace()
    {
        double pace = GetLength() / GetDistance();
        return pace;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}