using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber;
        string userInput;
        List<int> numberList = new List<int>();

        // Asking the user for a series of numbers, and append each one to a list. 
        // Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        do
        {
            // Asking the user for a guess.
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numberList.Add(userNumber);
            }

        } while (userNumber != 0);

        // Computing the sum, or total, of the numbers in the list.
        int totalSum = 0;
        foreach (int number in numberList)
        {
            totalSum += number;
        }

        // Computing the average of the numbers in the list.
        float totalAvg = (float)totalSum / numberList.Count;

        // Finding the maximum, or largest, number in the list.
        int maxNumber = numberList[0];
        foreach (int number in numberList)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {totalAvg}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}