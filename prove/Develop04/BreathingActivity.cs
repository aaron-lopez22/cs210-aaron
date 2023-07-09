class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        this.SetActivityName("Breathing Activity");
        this.SetDescription("This activity will help you relax by walking you" + "through breathing in and out slowly. " + "Clear your mind and focus on your breathing");
    }

    public void Run()
    {
        DisplayStartingMessage();
    }
}