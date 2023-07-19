using System.IO;
class GoalManager
{

List<SimpleGoal> simpleGoals;

public GoalManager()
{
    
    simpleGoals = new List<SimpleGoal>();
}

public void AddGoal(SimpleGoal newGoal)
{
    simpleGoals.Add(newGoal);
}


public void DisplayAll()
{
    foreach (SimpleGoal goal in simpleGoals)
    {
        goal.Display();
        Console.WriteLine();
    }
}

}