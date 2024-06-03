using System.Reflection;

public class Lectures: Event
{
    private string _speakerName;
    private int _capacity;

    public Lectures(string eventTitle, string description, string date, string time, Address address, string speakerName, int capacity): base(eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    
    public void DisplayFullDetails()
    {
        string LectureSpecificDetails = $"\nEvent Type: Lectures \nSpeaker Name: {_speakerName} \nCapacity: {_capacity}";
        DisplayStandartDetails();
        Console.WriteLine(LectureSpecificDetails);
    }

    public void DisplayShortDescription()
    {
        string title = GetEventTitile();
        string date = GetDate();
        string shortDescription = $"Event Type: Lectures \nTitle: {title} \nDate: {date}";
        Console.WriteLine(shortDescription);
    }
}