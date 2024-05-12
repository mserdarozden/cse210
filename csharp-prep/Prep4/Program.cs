using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);
        
        int sum = 0;
        int largestNumber = 0 ;
        
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            sum = num + sum;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}