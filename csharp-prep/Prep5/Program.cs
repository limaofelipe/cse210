using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);


    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());


            return favoriteNumber;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int squaredNumber = favoriteNumber * favoriteNumber;


            return squaredNumber;
        }
        
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.Write($"{userName}, the square of your number is {squaredNumber}");
        }
}