public class Receptions: Event
{
    private string _email;

    public Receptions(string eventTitle, string description, string date, string time, Address address, string email): base(eventTitle, description, date, time, address)
    {
        _email = email;
    }

    public void DisplayFullDetails()
    {
        string RecepitonSpecificDetails = $"\nEvent Type: Receptions \nE-mail: {_email}";
        DisplayStandartDetails();
        Console.WriteLine(RecepitonSpecificDetails);
    }

    public void DisplayShortDescription()
    {
        string title = GetEventTitle();
        string date = GetDate();
        string shortDescription = $"Event Type: Receptions \nTitle: {title} \nDate: {date}";
        Console.WriteLine(shortDescription);
    }
}