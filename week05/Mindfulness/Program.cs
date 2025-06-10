using System;

class Program
{
    static void Main(string[] args)
    {
        Activity newActivity = new Activity();
        BreathingActivity newBreath = new BreathingActivity();
        ReflectingActivity newReflect = new ReflectingActivity();
        ListingActivity newList = new ListingActivity();
        int i = 0;

        while (i == 0)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                //Breathing Activity
                newBreath.Run();
            }
            else if (input == 2)
            {
                //Reflecting Activity
                newReflect.Run();
            }
            else if (input == 3)
            {
                //Listing Activity
                newList.Run();
            }
            else if (input == 4)
            {
                //End program
                i = 1;
            }
        }
    }
}