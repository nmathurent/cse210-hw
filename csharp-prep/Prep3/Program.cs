using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber, userGuess;
        string userInput;

        // Asking the user for a guess
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // magicNumber = int.Parse(userInput);

        // Generating a random number from 1 to 100.
        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 101);


        // Adding a loop that keeps looping as long as the guess does not 
        // match the magic number.
        do
        {
            // Asking the user for a guess.
            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            // Determining if the user needs to guess higher or lower
            if (magicNumber == userGuess)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lower");
            }
        } while (magicNumber != userGuess);
    }
}