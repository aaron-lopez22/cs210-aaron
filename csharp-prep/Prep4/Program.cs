using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            int userNumbers = -1;
            int sum = 0;
            double average = 0;
        do 
        {
            Console.Write("Enter Number: ");
            string number = Console.ReadLine();
            userNumbers = int.Parse(number);
            numbers.Add(userNumbers);

        } while  (userNumbers != 0);

        int maxNum = numbers[0];

        foreach (int numb in numbers)
        {
            if (numb > maxNum)
            {
                maxNum = numb;
            }
            sum += numb;
        }

        Console.WriteLine($"The sum is: {sum}");
        double countL = numbers.Count - 1;
        average = ((float)sum) / countL;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNum}");

    }
}