using System;

class Program
{

    static void Main(string[] args)
    {

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 11);


        int userGuess = -1;

        while (userGuess != magicNumber)
        {

            ///Converting the string guess to an interger
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);

            if (userGuess > magicNumber)
            {
                Console.WriteLine(" Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}