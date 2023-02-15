using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignm1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignm1.GetSummary());
    }
}