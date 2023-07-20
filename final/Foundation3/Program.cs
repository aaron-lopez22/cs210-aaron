using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("listing the first message for Lecture event");
        Console.WriteLine();

        Address addresslecture = new Address("5555 s 5555 w", "South Jordan", "Utah", "USA");
        Lectures lecture = new Lectures("TED talk", "Todays lecture is on the theory of Math", "5/6/24", "10 AM", 250, "The speaker will be Thomas Wayne", addresslecture);

        lecture.DisplayStandard();
        Console.WriteLine();
        lecture.ShortDescription();
        Console.WriteLine();
        lecture.FullDetails();

        Console.WriteLine("Listing the second messages for Reception Events");
        Console.WriteLine();

        Address addressReception = new Address("3232 w 8585 s", "Pleasant Grove", "Utah", "USA");
        Reception reception = new Reception("Wedding for Thomas and Ashley", "Today we will be gathering for the wedding of these two", "12/12/24", "12 - 4 pm", addressReception, "Yes");

        reception.DisplayStandard();
        Console.WriteLine();
        reception.ShortDescription();
        Console.WriteLine();
        reception.FullDetails();

        Address addressOutdoor = new Address("56 Redwood Road", "Sandy", "Utah", "USA");
        Outdoor outdoor = new Outdoor("Great Camping Trip", "We will be fishing, making smores, hiking, and more", "5/2/24", "Saturday 10 AM until Monday 12 PM", "Weather will be mostly hot with some clouds", addressOutdoor);


        outdoor.DisplayStandard();
        Console.WriteLine();
        outdoor.ShortDescription();
        Console.WriteLine();
        outdoor.FullDetails();

    }
}