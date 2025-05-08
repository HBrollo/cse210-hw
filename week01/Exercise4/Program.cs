using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        bool done = false;
        do {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            
        
            if (number != 0)
            {
                numbers.Add(number);
            }
            else 
            {
                done = true;
            }
        } while(done == false);

        int sum = 0;
        foreach (int item in numbers) 
        {
            sum = sum + item;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = 0;
        foreach (int item in numbers) 
        {
            if (item > largestNumber) 
            {
                largestNumber = item;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");

        int smallestNumber = int.MaxValue;
        foreach (int item in numbers) 
        {
            if (item > 0 && item < smallestNumber) 
            {
                smallestNumber = item;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}