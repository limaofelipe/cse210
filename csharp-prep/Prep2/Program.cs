using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade percentage? ");
        string studentGrade = Console.ReadLine();
        int studentGradeNumber = int.Parse(studentGrade);

        string gradeLetter = "";

        if (studentGradeNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if (studentGradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (studentGradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (studentGradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is {gradeLetter}");

        if (studentGradeNumber >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("Sorry, Try again!");
        }

    }
}