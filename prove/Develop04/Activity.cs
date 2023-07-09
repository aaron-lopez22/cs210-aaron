class Activity
{
    private string description, name;

    static int spinnerCounter, duration;

    public Activity()
    {
        spinnerCounter = duration = 0;
    }

    public void SetActivityName(string _activityName)
    {
        name = _activityName;
    }

    public void SetDescription(string _description)
    {
        description = _description;
    }
    public int GetDuration()
    {
        return duration;
    }

    public void DisplayStartingMessage()
    {

    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int numSecondsToRun)
    {

    }


}