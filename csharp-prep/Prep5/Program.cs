using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayMessage();
        string name = PromptUserName();
        int number=  PromptUserNumber();
        double square = SquareNumber(number);
        DisplayResult(name, square);
    

        static void DisplayMessage()
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
            string num = Console.ReadLine();
            int userNumber = int.Parse(num);
            return userNumber;
        }

        static double SquareNumber(double number)
        {
            double square = number * number;
            return square;
        }

        static void DisplayResult(string name, double number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
    }
}