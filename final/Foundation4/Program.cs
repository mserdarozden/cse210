using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("2024-06-3", 30, 3.0),
            new Cycling("2024-06-3", 45, 12.0),
            new Swimming("2024-06-3", 30, 20)
        };
    
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}