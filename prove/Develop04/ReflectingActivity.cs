public class ReflectingActivity : Activity
{
    private List<String> _prompts = new List<string>();
    private List<String> _questions = new List<string>();
    RandomNumberGenerator randomPromptNumberGenerator = new RandomNumberGenerator(4);
    RandomNumberGenerator randomQuestionNumberGenerator = new RandomNumberGenerator(9);


    public ReflectingActivity(string name, string description): base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("How can you keep this experience in mind in the future? ");
    }
    
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(4);

        Console.WriteLine("");
        Console.WriteLine("Consider the fallowing prompt:");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the fallowing questions as they relate to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions(); 
            ShowSpinner(10);
            Console.WriteLine();
        }
        Console.WriteLine("");
    }

    private string GetRandomPrompt()
    {
        int randomNumber = randomPromptNumberGenerator.GetRandomNumber(4);
        string randomPrompt = _prompts[randomNumber];
        
        return randomPrompt;
    }

    private string GetRandomQuestion()
    {
        int randomNumber = randomQuestionNumberGenerator.GetRandomNumber(9);
        string randomQuestion = _questions[randomNumber];
        
        return randomQuestion;
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} ---");
    }

    private void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write(question);
    }
    }