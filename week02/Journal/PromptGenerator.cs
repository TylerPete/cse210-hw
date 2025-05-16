public class PromptGenerator()
{
    public List<string> _prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What was one act of service I did for someone, or that someone did for me today?", "What was the most surprising or unusual thing that happened today?" };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0, 7);

        return _prompts[index];
    }
}