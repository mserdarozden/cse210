public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What am I most grateful for today?");
        _prompts.Add("What did I learn about myself today?");
        _prompts.Add("What challenge did I overcome today?");
        _prompts.Add("Who made a positive impact on my day and how?");
        _prompts.Add("What was the most surprising moment of my day?");
        _prompts.Add("How did I contribute to someone else’s happiness today?");
        _prompts.Add("What progress did I make on my personal goals today?");
        _prompts.Add("What am I looking forward to tomorrow?");
        _prompts.Add("How can I improve my interactions with others?");
        _prompts.Add("What moment today would I like to remember?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 16);

        return _prompts[randomNumber];
    }

    public string GetPrompt(int index)
    {
        return _prompts[index];
    }

    public void DisplayPrompts()
    {
        int counter = 1;
        foreach (string prompt in _prompts)
        {
            Console.WriteLine($"{counter}-{prompt}");
            counter += 1;
        }
    }
}