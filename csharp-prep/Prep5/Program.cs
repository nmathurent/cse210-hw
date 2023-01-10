using System;


class Program
{
    // Function that Displays the message, "Welcome to the Program!"
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function that Asks for and returns the user's name (as a string)
    static string PromptUserName ()
    {
        Console.Write("Please enter your name: ");
        string userN = Console.ReadLine();
        return userN;
    }

    // Function that Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        return int.Parse(userInput);
    }

    // Function that Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int numberParam)
    {
        return numberParam * numberParam;
    }

    // Function that Accepts the user's name and the squared number and displays them.
    static void DisplayResult (string userName, int numberParam)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberParam}");
    }

    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }
}

