using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!");
        ShowSpinner(4);
        Console.WriteLine("");
        Console.WriteLine($"You have complated another {_duration} seconds of the {_name} Activity");
        ShowSpinner(4);
    }

    protected void ShowSpinner(int seconds)
    {
        List<String> animationStrings = new List<String>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        { 
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
  
        }
    }

    publi