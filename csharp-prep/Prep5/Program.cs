using System;

class Program
{
    static void Main(string[] args)
    {

        static void Main()
        {
            DisplayWelcome();
            
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);
        }
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            return number;
        }
 
        static int SquareNumber(int number)
        {
            int numberSquared = number * number;

            return numberSquared;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }


    Main();
    }
}