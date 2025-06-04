public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int duration) : base(duration)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        //code
    }

    private string GetRandomPrompt()
    {
        return "Meow";
    }

    public string GetRandomQuestion()
    {
        return "Meow";
    }

    public void DisplayPrompt()
    {
        //code
    }

    public List<string> GetListFromUser()
    {
        //REPLACE LATER
        List<string> list = new List<string>();
        return list;
    }
}