public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowCountdown(5);

        GetRandomPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        _count = 0;

        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();

    }

    public List<String> GetListFromUser()
    {
        _prompts.Add("-- Who are people that you appreciate? --");
        _prompts.Add("-- What are personal strengths of yours? --");
        _prompts.Add("-- Who are people that you have helped this week? --");
        _prompts.Add("-- When have you felt the Holy Ghost this month? --");
        _prompts.Add("-- Who are some of your personal heroes? --");
        return _prompts;
    }
    public void GetRandomPrompt()
    {
        Random newRandom = new Random();
        List<String> promptList = GetListFromUser();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine();

        Console.WriteLine(promptList[newRandom.Next(0, 4)]);

        Console.WriteLine("You may begin in...");
        ShowCountdown(5);
    }
}