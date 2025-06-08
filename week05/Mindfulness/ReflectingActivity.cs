public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<String>();
    private List<string> _questions = new List<String>();

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session to be?");
        int duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();

        }
        Console.WriteLine($"You reflected for {duration} seconds!");
        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        _prompts.Add("-- Think of a time when you stood up for someone else. --");
        _prompts.Add("-- Think of a time when you did something really difficult. --");
        _prompts.Add("-- Think of a time when you helped someone in need. --");
        _prompts.Add("-- Think of a time when you did something truly selfless. --");
        return _prompts[random.Next(0, 3)];
    }
    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        return _questions[random.Next(0, 8)];
    }
    private void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
        ShowSpinner(6);
    }

}