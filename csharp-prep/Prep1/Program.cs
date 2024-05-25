using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is your first name? ");
        //string firstName = Console.ReadLine();
       // Console.Write("What is your last name? ");
       // string lastName = Console.ReadLine();

        //Console.WriteLine("");
        //Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
        Console.Clear();
        string name = "Tuna";
        Console.WriteLine($"Benim ismim {name}");

        int age = 11;
        Console.WriteLine($"Benim yaşım {age}");

        Console.WriteLine("Senin ismin ne? ");
        string yourName = Console.ReadLine();

        Console.WriteLine($"Tanıştığımıza memnun oldum {yourName}");

        Console.WriteLine("Senin yaşın kaç? ");
        string userEntry = Console.ReadLine();

        int yourAge = int.Parse(userEntry);

        int ageDifference = age - yourAge;

        //
        if (ageDifference < 0)
        {
            Console.WriteLine($"Sen benden {-ageDifference} yaş büyüksün");
        }
        else if (ageDifference == 0)
        {
            Console.WriteLine("Yaşlarımız eşit!");
        }
        else if (ageDifference > 0)
        {
            Console.WriteLine($"Sen benden {ageDifference} yaş küçüksün");
        }


    }
}