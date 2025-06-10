public class Activity()
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session to be?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animation[index]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index++;

            if (index >= animation.Count)
            {
                index = 0;
            }
        }
        ;
    }
    public void ShowCountdown(int countdown)
    {
        while (countdown > 0)
        { 
            Console.Write(countdown);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            countdown--;
        }
    }
}