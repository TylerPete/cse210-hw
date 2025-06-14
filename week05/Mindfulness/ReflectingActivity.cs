public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) : base(duration)
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        string thePrompt = _prompts[random.Next(0, _prompts.Count)];
        return thePrompt;
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        string theQuestion = _questions[random.Next(0, _questions.Count)];
        return theQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        List<int> numQuestionsAndQuestionDuration = CalculateNumQuestionsAndQuestionDuration();
        int numQuestions = numQuestionsAndQuestionDuration[0];
        int questionDuration = numQuestionsAndQuestionDuration[1];
        int remainder = numQuestionsAndQuestionDuration[2];

        for (int i = 0; i < numQuestions; i++)
        {
            if (i == numQuestions - 1)
            {
                questionDuration += remainder;
            }

            string question = GetRandomQuestion();
            Console.Write($" > {question} ");
            ShowSpinner(questionDuration);
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    private List<int> CalculateNumQuestionsAndQuestionDuration()
    {
        List<int> numQuestionsAndDurations = new List<int>();

        int numQuestions = _duration / 15;
        int remainder = _duration % 15;
        int durationOfQuestion = 15;

        if (numQuestions == 0)
        {
            numQuestions = 1;
            durationOfQuestion = remainder;
        }
        else
        {
            if (remainder <= 5)
            {
                durationOfQuestion += remainder / numQuestions;
                remainder = remainder % numQuestions;
            }
            else
            {
                numQuestions += 1;
                durationOfQuestion = _duration / numQuestions;
                remainder = _duration % numQuestions;
            }
        }

        numQuestionsAndDurations.Add(numQuestions);
        numQuestionsAndDurations.Add(durationOfQuestion);
        numQuestionsAndDurations.Add(remainder);

        return numQuestionsAndDurations;
    }
}