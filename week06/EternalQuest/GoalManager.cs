public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string selection = "";

        while (selection != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            selection = Console.ReadLine();

            if (selection == "1")
            {
                CreateGoal();
            }
            else if (selection == "2")
            {
                ListGoalDetails();
            }
            else if (selection == "3")
            {
                SaveGoals();
            }
            else if (selection == "4")
            {
                LoadGoals();
            }
            else if (selection == "5")
            {
                ListGoalNames();
                Console.Write("Which goal did you accomplish? ");
                int theSelection = int.Parse(Console.ReadLine());

                _goals[theSelection - 1].RecordEvent();

                Console.WriteLine($"You now have {_score} points.");
                Console.WriteLine();
            }
            else if (selection == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Your selection is invalid. Please try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int selection = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int pointValue = int.Parse(Console.ReadLine());

        Goal goal = null;

        if (selection == 1)
        {
            goal = new SimpleGoal(goalName, description, pointValue);
        }
        else if (selection == 2)
        {
            goal = new EternalGoal(goalName, description, pointValue);
        }
        else if (selection == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(goalName, description, pointValue, target, bonus);
        }

        _goals.Add(goal);
        Console.WriteLine();
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int selection = int.Parse(Console.ReadLine());

        int newPoints = _goals[selection - 1].GetPointValue();
        _score += newPoints;
        Console.WriteLine($"Congratulations! You have earned {newPoints} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter streamwriter = new StreamWriter(filename))
        {
            streamwriter.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                streamwriter.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamReader streamreader = new StreamReader(filename))
        {
            _score = int.Parse(streamreader.ReadLine());
            string nextLine;

            while ((nextLine = streamreader.ReadLine()) != null)
            {
                string[] attributes = nextLine.Split("~");
                Goal newGoal = null;

                switch (attributes[0])
                {
                    case "Simple":
                        newGoal = new SimpleGoal(attributes[1], attributes[2], int.Parse(attributes[3]));
                        break;
                    case "Eternal":
                        newGoal = new EternalGoal(attributes[1], attributes[2], int.Parse(attributes[3]));
                        break;
                    case "Checklist":
                        newGoal = new ChecklistGoal(attributes[1], attributes[2], int.Parse(attributes[3]), int.Parse(attributes[4]), int.Parse(attributes[5]));
                        break;
                }
                _goals.Add(newGoal);
            }
        }


    }
}