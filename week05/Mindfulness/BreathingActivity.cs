public class BreathingActivity : Activity
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine();
        Console.WriteLine("This Activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on breathing.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowCountdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

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
        Console.WriteLine($"You have completed another {duration} seconds of the Breathing Activity.");
        DisplayEndingMessage();
    }
}