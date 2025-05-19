public class Fraction
{
    private int _bottomNumber;
    private int _topNumber;
    public Fraction()
    {
        _bottomNumber = 1;
        _topNumber = 1;
    }
    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }
    public Fraction(int top, int bottom)
    {
        _bottomNumber = bottom;
        _topNumber = top;
    }

    public void GetFractionString()
    {
        Console.WriteLine($"{_topNumber}/{_bottomNumber}");
    }
    public void GetDecimalValue()
    {
        double result = (double)_topNumber / (double)_bottomNumber;
        Console.WriteLine(result);
    }

    /*Individual getters and setters, currently not in use*/
    public void GetTop()
    {
        Console.WriteLine($"{_topNumber}");
    }
    public void SetTop(int top)
    {
        _topNumber = top;
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottomNumber);
    }
    public void SetBottom(int bottom)
    {
        _bottomNumber = bottom;
    }
    
}