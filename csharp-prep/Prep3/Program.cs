using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);

        while (userGuess != magicNumber)
        {
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                userGuess = int.Parse(guess);

            }
            else
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                userGuess = int.Parse(guess);
            }
        }

        Console.Write("Congrats you guessed it!");
    }
}