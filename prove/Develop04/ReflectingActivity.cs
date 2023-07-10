class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;


    public ReflectingActivity()
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder in each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(GetDuration());
        Console.WriteLine();
          while (DateTime.Now < endTime){
            Console.Write(GetRandomQuestion());
            ShowSpinner(5);
            Console.WriteLine();
            }
         DisplayEndingMessage();
    }

    public string GetRandomQuestion()
      {
           _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        string randomQuestion = "";

        int randomIndex = new Random().Next(_questions.Count);

        randomQuestion = _questions[randomIndex];

        return randomQuestion;
    }

     public string GetRandomPrompt()
      {
           _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        string randomPrompt = "";

        int randomIndex = new Random().Next(_prompts.Count);

        randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

}