using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNum = SquareNumber(number);
        DisplayResult(name, squareNum);
    }
    /*DisplayWelcome - Displays the message, "Welcome to the Program!"*/
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    /*PromptUserName - Asks for and returns the user's name (as a string)*/
    static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            return userName;
        }    
    /*PromptUserNumber - Asks for and returns the user's favorite number (as an integer) */
    static int PromptUserNumber()
        {   
            Console.WriteLine("What is your favorite number?");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }

    /*SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)*/
    static int SquareNumber(int number)
        {   
            int square = number * number;
            return square;
        }

    /*DisplayResult - Accepts the user's name and the squared number and displays them.*/
    static void DisplayResult(string name, int squareNum)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {squareNum}.");
        }
}