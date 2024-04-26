using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {


        Console.Write("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        
        ///Getting the user numbers
        int userNumber = -1;
        while (userNumber != 0)
        {
        Console.WriteLine("Enter number: ");   
        string userInput = Console.ReadLine();
        userNumber = int.Parse(userInput);

            if (userNumber != 0 )
            {
                numbers.Add(userNumber);
            }

        }

        ///Finding the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        ///Finding the Max Number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}