using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Library library = new Library();
        
        Reference reference = library.getRandomReference();
        string scriptureText = library.GetRandomText();

        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            string displayText = scripture.GetDisplayText();

            Console.WriteLine(displayText);
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string userInput = Console.ReadLine();

            if (userInput == "quit" || scripture.IsComplatelyHidden())
            {
                break;
            }
            else 
            {
                scripture.HideRandomWords(3);
            }


        }
        




    }
}