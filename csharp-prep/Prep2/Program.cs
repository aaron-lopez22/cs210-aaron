using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage in the class? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        int gradeA = 90;
        int gradeB = 80;
        int gradeC = 70;
        int gradeD = 60;
        string letter= "";
        string message = "";

        if (number >= gradeA)
        {
           letter = "A";
        }
        else if (number >= gradeB)
        {
            letter = "B";
        }
        else if (number >= gradeC)
        {
            letter = "C";
        }
        else if (number >= gradeD)
        {
           letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (number < gradeC)
        {
            message = "Sorry you did not pass the class.";
        }
        else
        {
            message = "Congrats you passed the class";
        }

        Console.WriteLine($"Your grade is {letter}. {message}");
    }
}