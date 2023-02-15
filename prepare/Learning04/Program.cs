using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignm1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignm1.GetSummary());
        MathAssignment assignm2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assignm2.GetSummary());
        Console.WriteLine(assignm2.GetHomeworkList());
        WritingAssignment assignm3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignm3.GetSummary());
        Console.WriteLine(assignm3.GetWritingInformation());
    }
}