using System;

class Program
{
    static void Main(string[] args)
    {
        //Initialize Journal
        Journal newJournal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        int i = 0;
        while (i == 0)
        {
            int input;
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");

            //New Entry
            Entry newEntry = new Entry();

            input=int.Parse(Console.ReadLine());
            if (input == 1)
            {
                //Stores Time
                DateTime date = DateTime.Now;
                newEntry._date = $"Date: {date.ToShortDateString()}";

                //Generates prompt, stores it
                PromptGenerator promptCaller = new PromptGenerator();
                string prompt = promptCaller.GetRandomPrompt();
                newEntry._promptText = $" - Prompt: {prompt}";

                //Writing to console, user input begins here
                Console.WriteLine(prompt);
                Console.Write("> ");
                newEntry._entryText = $" - {Console.ReadLine()}";
                newJournal.AddEntry(newEntry);
            }
            else if (input == 2)
            {
                newJournal.DisplayAll();

            }
            else if (input == 3)
            {
                Console.WriteLine("What is the file name?");
                Console.Write("> ");
                newJournal.LoadFromFile(Console.ReadLine());
            }
            else if (input == 4)
            {
                Console.WriteLine("What is the file name?");
                Console.Write("> ");
                newJournal.SaveToValue(Console.ReadLine());
            }
            else if (input == 5)
            {
                i = 1;
            }
        }
    }
}