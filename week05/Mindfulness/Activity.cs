public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;

    public Activity(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
    }

    public void ShowSpinner(int seconds)
    {
        //code
    }

    public void ShowCountDown(int seconds)
    {
        //code
    }
}