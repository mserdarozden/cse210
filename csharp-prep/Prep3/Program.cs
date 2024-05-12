using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        bool answerIsWrong = true;

        Console.WriteLine("Welcome to magic number game");
        Console.WriteLine("The magic number is a number from 1 to 100");
        Console.WriteLine("");
        
        do
        {

            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int magicNumber = int.Parse(userInput);

            if (magicNumber == number)
            {
                answerIsWrong = false;
                Console.WriteLine("You guessed it!");
            }
            else if (magicNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lower");
            }
        } while (answerIsWrong);
        
    }
}