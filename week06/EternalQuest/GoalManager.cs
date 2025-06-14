using System.IO;
using System.Reflection.Metadata;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _level = 0;
    private int _score;
    public void Start()
    {
        LevelManager();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create a new goal:");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a choice from the menu:");
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple goals");
        Console.WriteLine("2. Eternal goals");
        Console.WriteLine("3. Checklist goals");
        Console.WriteLine("Which type of goal would you like to create?");
        int goalType = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the name of the goal?");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());
        if (goalType == 1)
        {
            //Simple goals
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, points, false);
            _goals.Add(simpleGoal);
        }
        else if (goalType == 2)
        {
            //Eternal goals
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, points);
            _goals.Add(eternalGoal);
        }
        else if (goalType == 3)
        {
            //checklist goals
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int pointBonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, points, goalTarget, pointBonus, 0);
            _goals.Add(checklistGoal);

        }
    }
    public void DisplayGoalInfo()
    {
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {

            Console.WriteLine($"{count}. {goal.GetStringRepresentation()}");
            count++;
        }
    }
    public void RecordEvent()
    {
        DisplayGoalInfo();
        Console.WriteLine("Which goal did you accomplish?");
        int input = int.Parse(Console.ReadLine()) - 1;
        _score += _goals[input].RecordEvent();

    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal}:{goal.GetSaveString()}");
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        string[] parts;
        string goalType;
        string[] goalInfo;

        foreach (string line in lines)
        {
            //erase the first line(points)
            if (line == lines[0])
            {
                _score += int.Parse(line);
            }
            //distinguish what type of goal it is
            //"Create" a new goal of that type with that info provided.
            else
            {
                parts = line.Split(":");
                goalType = parts[0];
                goalInfo = parts[1].Split(",");

                if (goalType == "SimpleGoal")
                {
                    SimpleGoal newSimpleGoal = new SimpleGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), bool.Parse(goalInfo[3]));
                    _goals.Add(newSimpleGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    EternalGoal newEternalGoal = new EternalGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]));
                    _goals.Add(newEternalGoal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    ChecklistGoal newChecklistGoal = new ChecklistGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), int.Parse(goalInfo[3]), int.Parse(goalInfo[4]), int.Parse(goalInfo[5]));
                    _goals.Add(newChecklistGoal);
                }
            }




        }
    }
    private void LevelManager()
    {
        string title;
        int levelXp = _score / 1000;
        if (levelXp > _level)
        {
            _level = levelXp;
            Console.WriteLine("Congratulations! You leveled up!");
        }
        if (_level < 5)
        {
            title = "Goal Novice";
        }
        else if (_level >= 5 && _level < 10)
        {
            title = "Goal Apprentice";
        }
        else if (_level >= 10 && _level < 15)
        {
            title = "Goal Master";
        }
        else if (_level >= 15 && _level < 20)
        {
            title = "Goal Ninja";
        }
        else
        {
            title = "Goal Master Jedi";
        }
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"You are a level {_level} {title}.\n");
    }
}