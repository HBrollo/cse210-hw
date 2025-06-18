public class Swimming : Exercise
{
    private int _laps;

    public Swimming(int length, int laps) : base(length)
    {
        _laps = laps;
    }
    

    //Distance (km) = swimming laps * 50 / 1000
    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000.0;
        return distance;
    }
    public override double GetPace()
    {
        double pace = GetLength() / GetDistance();
        return pace;
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetLength()) * 60;
        return speed;
    }
    
}