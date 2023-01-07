using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        // Printing out the appropriate letter grade
        string letterGrade = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}.");

        // Determining if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulation you have passed the course!");
        }
        else 
        {
            Console.WriteLine("You did not pass the course but keep studying hard for next time!");
        }
    }
}