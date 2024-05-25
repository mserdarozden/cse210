public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        string menu = @"Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: ";

    while (true)
    {
        Console.WriteLine("");
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.Write(menu);
        string userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            CreateGoal();
        }
        else if (userChoice == "2")
        {
            ListGoalDetails();
        }
        else if (userChoice == "3")
        {
            SaveGoals();
        }
        else if (userChoice == "4")
        {
            LoadGoals();
        }
        else if (userChoice == "5")
        {
            RecordEvent();
        }
        else if (userChoice == "6")
        {
            break;
        }
        else 
        {
            Console.WriteLine("Wrong input! Please enter a number from the menu");
        }
    }
    }

    private void DisplayPlayerInfo()
    {
        string playerScore = $"You have {_score} points";
        Console.WriteLine(playerScore);
        Console.WriteLine("");

        string playerLevel = CalculateLevel();
        Console.WriteLine(playerLevel);
    }

    private void ListGoalNames()
    {
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            counter++;
            string goalNames = counter + ". " + goal.getGoalName();
            Console.WriteLine(goalNames);
        }
    }

    private void ListGoalDetails()
    {
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            counter++;
            string detailsString = counter + ". " + goal.GetDetailsString();
            Console.WriteLine(detailsString);
        }
    }

    private void CreateGoal()
    {
        string goalMenu = @"The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create? "; 

        Console.Write(goalMenu);
        string userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            
            Console.Write("What is amount of points associated with this goal? ");
            string points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (userChoice == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            
            Console.Write("What is amount of points associated with this goal? ");
            string points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (userChoice == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            
            Console.Write("What is amount of points associated with this goal? ");
            string points = Console.ReadLine();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string targetString = Console.ReadLine();
            int target = int.Parse(targetString);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusString = Console.ReadLine();
            int bonus = int.Parse(bonusString);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Wrong input! PLease enter a number from the menu");
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string userInput = Console.ReadLine();
        int accomplishedGoal = int.Parse(userInput);
        if (accomplishedGoal > 0 && accomplishedGoal <= _goals.Count)
        {
            _goals[accomplishedGoal-1].RecordEvent();
            Console.WriteLine("");
            _score = _score + _goals[accomplishedGoal-1].getPoints();
            Console.WriteLine($"You now have {_score} points.");
            
        }
        else 
        {
            Console.WriteLine("Wrong input");
        }
    }

    private void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);

        for (int i = 1; i<lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            if (parts[0] == "SimpleGoal")
            {
                string[] elements = parts[1].Split("|");
                SimpleGoal simpleGoal = new SimpleGoal(elements[0], elements[1], elements[2]);
                simpleGoal.setComplate(bool.Parse(elements[3]));
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                string[] elements = parts[1].Split("|");
                EternalGoal eternalGoal = new EternalGoal(elements[0], elements[1], elements[2]);
                _goals.Add(eternalGoal);
            } 
            else if (parts[0] == "ChecklistGoal")
            {
                string[] elements = parts[1].Split("|");
                ChecklistGoal checklistGoal = new ChecklistGoal(elements[0], elements[1], elements[2], int.Parse(elements[3]), int.Parse(elements[4]));
                checklistGoal.SetAmountComplete(int.Parse(elements[5]));
                _goals.Add(checklistGoal);
            } 
        }
    }

    private string CalculateLevel()
    {
        if (_score < 50)
        {
            return "Level 1";
        }
        else if (_score < 150)
        {
            return "Level 2";
        }
        else if (_score < 300)
        { 
            return "Level 3";
        }
        else if (_score < 500)
        {
            return "Level 4";
        }
        else if (_score < 750)
        {
            return "Level 5";
        }
        else if (_score < 1050)
        {
            return "Level 6";
        }
        else if (_score < 1400)
        {
            return "Level 7";
        }
        else if (_score < 1800)
        {
            return "Level 8";
        }
        else if (_score < 2250)
        {
            return "Level 9";
        }
        else 
        {
            return "Level 10";
        }
        
      
    }
}