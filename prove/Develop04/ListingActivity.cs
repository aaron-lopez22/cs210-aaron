class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _userInput;


    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }


    public string GetRandomPrompt()
    {
           _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        string randomPrompt = "";

        int randomIndex = new Random().Next(_prompts.Count);

        randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

    public List<string> GetListFromUser(string userInput)
    {
        _userInput = new List<string>();

        _userInput.Add(userInput);

        return _userInput;
    }

    public void Run()
    {
        DisplayStartingMessage();
        int interval = GetDuration() / 6;

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(GetDuration());
            Console.WriteLine();
            Console.WriteLine(GetRandomPrompt());
            Console.Write("You may begin in: ");
            ShowCountDown(interval);
            Console.WriteLine();
        while (DateTime.Now < endTime){
            string userInput = Console.ReadLine();
            GetListFromUser(userInput);
        }
            
            
            

            int _count = _userInput.Count();
            Console.WriteLine(_count);
            
        
        DisplayEndingMessage();

    }

}