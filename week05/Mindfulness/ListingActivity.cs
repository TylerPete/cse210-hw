public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int duration) : base(duration)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        List<string> responseList = GetListFromUser();
        _count = responseList.Count;
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        string thePrompt = _prompts[random.Next(0, _prompts.Count)];
        return thePrompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write(" > ");
            string response = Console.ReadLine();
            list.Add(response);

            currentTime = DateTime.Now;
        }

        return list;
    }
}