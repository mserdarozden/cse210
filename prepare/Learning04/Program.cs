using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "", "European History The Causes of World War II by Mary Waters");
    
        string atext = assignment.GetSummary();
        Console.WriteLine(atext);
        Console.WriteLine("");

        string b1text = mathAssignment.GetSummary();
        string b2text = mathAssignment.GetHomeworkList();
        Console.WriteLine(b1text);
        Console.WriteLine(b2text);
        Console.WriteLine("");

        string ctext = writingAssignment.GetWritingInformation();
        Console.WriteLine(ctext);
    
    
    }
}