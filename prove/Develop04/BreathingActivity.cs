public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description): base(name, description)
    {

    }

    public void Run() 
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(4);

        Console.WriteLine("");
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in..."); 
            ShowCountDown(4);
            Console.WriteLine("");

            Console.Write("Now breathe out..."); 
            ShowCountDown(6);
            Console.WriteLine("");
            Console.WriteLine("");

        }

    
    }
}