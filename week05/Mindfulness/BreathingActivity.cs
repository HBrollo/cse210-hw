public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This Activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowCountdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown(6);

        }
        ;
        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.");
        DisplayEndingMessage();
    }
}