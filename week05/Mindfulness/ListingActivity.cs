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
        //code
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        string thePrompt = _prompts[random.Next(0, _prompts.Count)];
        return thePrompt;
    }

    public List<string> GetListFromUser()
    {
        //REPLACE LATER
        List<string> list = new List<string>();
        return list;
    }
}