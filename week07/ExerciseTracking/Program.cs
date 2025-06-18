using System;

class Program
{
    static void Main(string[] args)
    {
        Running runningExercise = new Running(40, 10);
        Cycling cyclingExercsie = new Cycling(30, 25);
        Swimming swimmingExercise = new Swimming(30, 60);

        List<Exercise> exercises = new List<Exercise>();
        exercises.Add(runningExercise);
        exercises.Add(cyclingExercsie);
        exercises.Add(swimmingExercise);

        foreach (Exercise exercise in exercises)
        {
            exercise.GetSummary($"{exercise}");    
        }
    }
}