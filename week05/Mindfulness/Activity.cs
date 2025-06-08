public class Activity()
{
    /*private string _name;
    private string _description;
    private string _duration;*/

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");
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