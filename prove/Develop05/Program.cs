using System;

class Program
{
    static void Main(string[] args)
    {
        int userMenuInput = 0;
        bool status = false;
        GoalManager goalManager = new GoalManager();
        SimpleGoal goal = new SimpleGoal("", "", 0, status);
        goalManager.AddGoal(goal);

        List<string> menu = new List<string>
       {
            "You have 0 points",
            "",
            "Menu Options",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"

       };


        while (userMenuInput != 6)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenuInput)
            {
                case 1:

                    {

                        int userMenuInput1 = 0;


                        List<string> _goals = new List<string>
                    {
                            "The types of Goals are:",
        "1. Simple Goal",
        "2. Eternal Goal",
        "3. Checklist Goal"
    };


                        for (int i = 0; i < 1; i++)
                        {
                            Console.Clear();
                            foreach (string menuGoals in _goals)
                            {
                                Console.WriteLine(menuGoals);
                            }
                            Console.Write("Which type of goal would you like to create? ");
                            userMenuInput1 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (userMenuInput1)
                            {
                                case 1:
                                    Console.Write("What is the name of your goal? ");
                                    string name = Console.ReadLine();
                                    Console.Write("What is a short description of it? ");
                                    string description = Console.ReadLine();
                                    Console.Write("What is the amount of points associated with this goal? ");
                                    int points = int.Parse(Console.ReadLine());
                                    SimpleGoal goal1 = new SimpleGoal(name, description, points, status);
                                    goalManager.AddGoal(goal1);
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                            }

                        }
                    }
                    break;
                case 2:
                    goalManager.DisplayAll();
                    goal.Display();

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }


    }
}