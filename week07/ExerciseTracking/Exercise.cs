public class Exercise
{
    private string _date;
    private int _length; //In minutes

    public Exercise(int length)
    {
        _length = length;
    }

    protected virtual string GetDate()
    {
        string day = DateTime.Today.ToString("dd");
        string month = DateTime.Today.ToString("MMM").ToUpper();
        string year = DateTime.Today.ToString("yyyy");
        _date = $"{day} {month} {year}";
        return _date;
    }
    protected int GetLength()
    {
        return _length;
    }
    public virtual void GetSummary(string ExerciseType)
    {
       
        Console.WriteLine($"{GetDate()} {ExerciseType} ({GetLength()} min): Distance {GetDistance()} KM, Speed: {GetSpeed()} KM/H, Pace: {GetPace()} min per KM");
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetPace()
    { 
        return 0;
    }
    public virtual double GetSpeed()
    { 
        return 0;
    }
    //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
}