using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = @"Menu Options:
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. Quit
Select a choice from menu: ";
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(menu);
            string userChoice = Console.ReadLine();
            if (userChoice == "1" )
            {
                string activity = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                
                BreathingActivity breathingActivity = new BreathingActivity(activity, description);
                breathingActivity.DisplayStartingMessage();
                
                string userInput = Console.ReadLine();
                int duration = int.Parse(userInput);
                breathingActivity.SetDuration(duration);

                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }
            else if (userChoice == "2")
            {
                string activity = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                
                ReflectingActivity reflectingActivity = new ReflectingActivity(activity, description);
                reflectingActivity.DisplayStartingMessage();

                string userInput = Console.ReadLine();
                int duration = int.Parse(userInput);
                reflectingActivity.SetDuration(duration);

                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();

            }
            else if (userChoice == "3")
            {
                string activity = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                
                ListingActivity listingActivity = new ListingActivity(activity, description);
                listingActivity.DisplayStartingMessage();

                string userInput = Console.ReadLine();
                int duration = int.Parse(userInput);
                listingActivity.SetDuration(duration);

                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
            else if (userChoice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input, please select a choice from menu: ");

            }

        }
        
    }
}