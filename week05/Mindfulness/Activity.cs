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


// Any more to do here? vvv
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");

        //...?
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;

        List<string> loadingCharacters = new List<string> {"|", "/", "-", "\\"};
        while (currentTime < futureTime)
        {
            foreach (string character in loadingCharacters)
            {
                Console.Write(character);
                Thread.Sleep(300);

                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b");
        }
    }
}