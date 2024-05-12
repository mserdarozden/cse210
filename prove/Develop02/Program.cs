using System;
using System.Data;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        while (true)
        {
            Console.Write(@"Please select one of the fallowing choices: 
1-Write
2-Display
3-Load
4-Save
5-Quit
What would you like to do? ");
            string userInput = Console.ReadLine();
            int userChoice = int.Parse(userInput);

            if (userChoice == 1)
            {
                Console.WriteLine(@"Select your wish? 
1-Give me a random prompt
2-I would like to select one form the list");
                string userInput2 = Console.ReadLine();
                int userChoice2 = int.Parse(userInput2);

                string prompt = "";
                if (userChoice2 == 1)
                {
                    prompt = promptGenerator.GetRandomPrompt();
                } 
                else if (userChoice2 == 2)
                {
                    Console.WriteLine("");
                    promptGenerator.DisplayPrompts();
                    Console.WriteLine("");
                    Console.Write("which prompt you would like to use? ");
                    string userChoice3 = Console.ReadLine();
                    int userSelectedPrompt = int.Parse(userChoice3);

                    if (userSelectedPrompt >= 1 && userSelectedPrompt <= 15)
                    {
                        prompt = promptGenerator.GetPrompt(userSelectedPrompt-1);
                    }
                    else 
                    {
                        Console.WriteLine("Please enter a valid number!");
                    }
                }
                else 
                {
                    Console.WriteLine("Please enter a valid number!");
                }

                Console.WriteLine(prompt);
                string userAnswer = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry entry = new Entry();
                entry._date = dateText;
                entry._entryText = userAnswer;
                entry._promptText = prompt;

                journal.AddEntry(entry);
            }
            else if (userChoice == 2)
            {
                journal.Display();
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("What is the filename");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("What is the filename");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (userChoice == 5)
            {
                break;
            }
            else 
            {
                Console.WriteLine("Invalid choice");
                Console.WriteLine("Please enter a number from 1-5");
                Console.WriteLine("");
            }
    
        }
      


        

        string newPrompt = promptGenerator.GetRandomPrompt();
        
        //Console.WriteLine(newPrompt);


    }
}