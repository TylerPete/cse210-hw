public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

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
        Console.Write("How long, in seconds, would you like for your session?  ");

        _duration = 0;

        while (_duration == 0)
        {
            try
            {
                _duration = int.Parse(Console.ReadLine());

                if (_duration < 0)
                {
                    _duration = 0;
                    Console.Write("Invalid entry. Please try again.");
                    Thread.Sleep(1750);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                                \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }
            }
            catch
            {
                _duration = 0;
                Console.Write("Invalid entry. Please try again.");
                Thread.Sleep(1750);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                                \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;

        List<string> loadingCharacters = new List<string> { "|", "/", "-", "\\" };
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
            Console.Write("\b \b");
        }
    }
}