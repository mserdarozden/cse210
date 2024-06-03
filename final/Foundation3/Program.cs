using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

         // Create an Address object for the lecture
        Address address = new Address("123 Main St", "New York", "NY", "USA");

        // Create a Lectures object
        Lectures lecture = new Lectures(
            "Science Symposium",
            "An insightful discussion on science.",
            "2024-07-01",
            "10:00 AM",
            address,
            "Dr. Smith",
            100
        );

        Console.WriteLine("Standart Details:");
        Console.WriteLine("---------------------------");
        lecture.DisplayStandartDetails();
        Console.WriteLine("");
        Console.WriteLine("Full Details:");
        Console.WriteLine("---------------------------");
        lecture.DisplayFullDetails();
        Console.WriteLine("");
        Console.WriteLine("Short Description:");
        Console.WriteLine("---------------------------");
        lecture.DisplayShortDescription();

        // Create an Address object for the Reception
        Address receptionAddress = new Address("456 Elm St", "Los Angeles", "CA", "USA");

        // Create a Receptions object
        Receptions reception = new Receptions(
            "Company Gala",
            "An elegant evening of networking.",
            "2024-08-15",
            "7:00 PM",
            receptionAddress,
            "rsvp@company.com"
        );
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Standart Details:");
        Console.WriteLine("---------------------------");
        reception.DisplayStandartDetails();
        Console.WriteLine("");
        Console.WriteLine("Full Details:");
        Console.WriteLine("---------------------------");
        reception.DisplayFullDetails();
        Console.WriteLine("");
        Console.WriteLine("Short Description:");
        Console.WriteLine("---------------------------");
        reception.DisplayShortDescription();

        // Create an Address object for the outdoor gathering
        Address outdoorAddress = new Address("101 Maple St", "Houston", "TX", "USA");

        // Create an OutdoorGatherings object
        OutdoorGatherings outdoorGathering = new OutdoorGatherings(
            "Community Picnic",
            "A fun day at the park with activities for all ages.",
            "2024-10-05",
            "12:00 PM",
            outdoorAddress,
            "Sunny"
        );

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Standart Details:");
        Console.WriteLine("---------------------------");
        outdoorGathering.DisplayStandartDetails();
        Console.WriteLine("");
        Console.WriteLine("Full Details:");
        Console.WriteLine("---------------------------");
        outdoorGathering.DisplayFullDetails();
        Console.WriteLine("");
        Console.WriteLine("Short Description:");
        Console.WriteLine("---------------------------");
        outdoorGathering.DisplayShortDescription();
    }
}