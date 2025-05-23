using System;

class Program
{
    static void Main(string[] args)
    {
        //Initializes variables required to run the program.
        Console.WriteLine("Program Start");
        Scripture newScripture = new Scripture();
        Reference newReference = new Reference();
        Random random = new Random();
        newScripture.ConstructList();
        bool active = true;

        while (active == true)
        {
            //Get ready to loop
            bool loop = true;
            Console.Clear();

            //Checks if it's all been hidden
            bool everythingHid = newScripture.IsCompletelyHidden();
            if (everythingHid)
            {
                active = false;
                loop = false;
            }

            //Displays scripture
            newScripture.GetDisplayText(newReference);
            Console.WriteLine();
            Console.WriteLine();

            //Loops until a shown word is found and hidden
            while (loop == true)
            {
                int randomNumber = random.Next(0, newScripture._words.Count);
                loop = newScripture.HideRandomWord(randomNumber, loop);
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string answer = Console.ReadLine();
            if (answer == "quit")
            {
                active = false;   
            }
        }
    }
}