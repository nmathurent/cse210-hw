// System.IO is used to find the StreamWriter class
// using System.IO; 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string menuOption = "0";
        // int dayToday = DateTime.Now.Day;
        // int monthToday = DateTime.Now.Month;
        // int yearToday = DateTime.Now.Year;

        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        string question = "";
        string answer = "";
        string dateString = "";
        string fileName = "";
        DateTime theCurrentTime = DateTime.Now;

        // dateString = $"{monthToday}/{dayToday}/{yearToday}";
        dateString = theCurrentTime.ToShortDateString();
        
        while (menuOption != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuOption = Console.ReadLine();

            switch (menuOption)
            {
                case "1":
                    question = promptGen.GetPrompt(journal);
                    Console.WriteLine($"{question}");
                    answer = Console.ReadLine();
                    if (question != "All questions have been asked!  Press Enter to continue...")
                    {
                        // Add line extracted from
                        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.insert?view=net-7.0
                        journal.Add(new JournalEntry() { _date = dateString, _prompt = question, _response = answer });
                    }
                    break;
                case "2":
                    journal.Display();
                    break;
                case "4":
                    Console.WriteLine("What is the filename? ");
                    fileName = Console.ReadLine();
                    journal.Save(fileName);
                    break;
                case "5":
                    break;
            }

            if (menuOption == "5")
            {
                break;
            }
            
        }

    }

}