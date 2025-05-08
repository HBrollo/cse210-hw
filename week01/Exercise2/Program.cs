using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());
        string gradeLetter;

        if (gradePercentage >= 90) 
        {
            gradeLetter = "A";
        }
        
        else if (gradePercentage < 90 && gradePercentage >= 80) 
        {
            gradeLetter = "B";
        }
        
        else if (gradePercentage < 80 && gradePercentage >= 70) 
        {
            gradeLetter = "C";
        }
        
        else if (gradePercentage < 70 && gradePercentage >= 60) 
        {
            gradeLetter = "D";
        }
        
        else 
        {
            gradeLetter = "F";
        }
        /*Determine if it is a + or - grade*/
        string symbol;
        int gradeSymbol = gradePercentage % 10;
        if (gradeSymbol >= 7 && gradePercentage < 99 && gradePercentage > 60)
        {
            symbol = "+";
        } 
        else if (gradeSymbol < 4 && gradePercentage > 60)
        {
            symbol = "-";
        }
        else 
        {
            symbol = "";
        }
        
        Console.WriteLine($"Your grade is: {gradeLetter}{symbol}");

        /* Determine if the user passed or not; print out an appropiate message.*/
        if (gradePercentage >= 70) 
        {
            Console.WriteLine("You have passed the class. Congratulations!");
        }
        else 
        {
            Console.WriteLine("You have failed to pass the class. Don't give up!");
        }

    }
}