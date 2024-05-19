using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private int _count;

    private List<String> _prompts = new List<string>();
    RandomNumberGenerator randomPromptNumberGenerator = new RandomNumberGenerator(4);


    public ListingActivity(string name, string description): base(name, description)
    {
        
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(4);

        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the fallowing prompt:");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        List<String> userEntries = GetListFromUser();
        _count = userEntries.Count();

        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");
    }

    private string GetRandomPrompt()
    {
        int randomNumber = randomPromptNumberGenerator.GetRandomNumber(4);
        
        string randomPrompt = _prompts[randomNumber];

        return randomPrompt;
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} ---");
    }

    private List<String> GetListFromUser()
    {
        List<string> userEntries = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string userEntry = Console.ReadLine();
            userEntries.Add(userEntry);
            
        }
        
        return userEntries;
    }

    

}