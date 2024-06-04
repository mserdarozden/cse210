public class OutdoorGatherings: Event
{
    private string _weather;

    public OutdoorGatherings(string eventTitle, string description, string date, string time, Address address, string weather): base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public void DisplayFullDetails()
    {
        string OutdoorSpecificDetails = $"\nEvent Type: Outdoor Gatherings \nWeather: {_weather}";
        DisplayStandartDetails();
        Console.WriteLine(OutdoorSpecificDetails);
    }

    public void DisplayShortDescription()
    {
        string title = GetEventTitle();
        string date = GetDate();
        string shortDescription = $"Event Type: Outdoor Gatherings \nTitle: {title} \nDate: {date}";
        Console.WriteLine(shortDescription);
    }
}