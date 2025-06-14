using System;

class Program
{
    static void Main(string[] args)
    {
        //Exceeding requirements attempt: Earning 1000 xp will level you up. For every five levels until level 20, you will earn a title.
        Console.WriteLine("Welcome to the program! Set goals and keep them to earn points. For every 1000 points, you'll level up!");
        GoalManager goalManager = new GoalManager();
        int i = 1;
        while (i == 1)
        {
            goalManager.Start();
            
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                //Create a goal
                goalManager.CreateGoal();
            }
            else if (input == 2)
            {
                //Displays all goals
                goalManager.DisplayGoalInfo();
            }
            else if (input == 3)
            {
                //Save goals
                goalManager.SaveGoals();
            }
            else if (input == 4)
            {
                //Load goals
                goalManager.LoadGoals();
            }
            else if (input == 5)
            {
                //Records goal progress
                goalManager.RecordEvent();

            }
            else if (input == 6)
            {
                //Quit program
                i = 0;
            }
        }
    }
}