using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string response;
        do {
            int magicNumber = randomGenerator.Next(1,100);
    
            bool success = false;
            int guessCount = 0;
            do {
                Console.WriteLine("What is your guess?");
                guessCount ++;
                int guess = int.Parse(Console.ReadLine());
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher.");
                }
                else if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} tries.");
                    success = true;
                }
            } while (success == false);
            Console.WriteLine("Do you want to continue?");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}