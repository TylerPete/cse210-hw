public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        int numCycles = _duration / 10;
        int remainder = _duration % 10;
        int firstBreatheInTime;

        if (remainder > 2)
        {
            firstBreatheInTime = remainder / 2;
            Console.Write("Breathe in...");
            ShowCountDown(firstBreatheInTime);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(remainder - firstBreatheInTime);
            Console.WriteLine();
            Console.WriteLine();
            firstBreatheInTime = 0;
        }
        else { firstBreatheInTime = remainder; }

        for (int i = 0; i < numCycles; i++)
        {
            Console.Write("Breathe in...");

            if (i == 0)
            {
                ShowCountDown(4 + firstBreatheInTime);
            }
            else { ShowCountDown(4); }

            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}