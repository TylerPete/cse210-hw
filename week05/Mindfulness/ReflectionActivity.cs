public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) : base(duration)
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        //code
    }

    private string GetRandomPrompt()
    {
        return "Meow";
    }

    private string GetRandomQuestion()
    {
        return "Meow";
    }

    public void DisplayPrompt()
    {
        //code
    }

    public void DisplayQuestions()
    {
        //code
    }
}