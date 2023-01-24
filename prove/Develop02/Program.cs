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
        string fileName = "";
        string dateString = "";
        string timeString = "";

        DateTime theCurrentTime = DateTime.Now;

        // dateString = $"{monthToday}/{dayToday}/{yearToday}";
        
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
                        // Time format extracted from the following link
                        // https://josipmisko.com/posts/c-sharp-get-time-from-datetime
                        theCurrentTime = DateTime.Now;
                        dateString = theCurrentTime.ToShortDateString();
                        timeString = theCurrentTime.ToString("HH:mm tt");
                        // Add line extracted from
                        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.insert?view=net-7.0
                        journal.Add(new JournalEntry() { _date = dateString, 
                                                         _time = timeString,
                                                         _prompt = question, 
                                                         _response = answer });
                    }
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    Console.WriteLine("What is the filename? ");
                    fileName = Console.ReadLine();
                    journal.Load(fileName);
                    break;
                case "4":
                    Console.WriteLine("What is the filename? ");
                    fileName = Console.ReadLine();
                    journal.Save(fileName);
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid option. Press <Enter> to continue...");
                    answer = Console.ReadLine();
                    break;
            }

            if (menuOption == "5")
            {
                break;
            }
            
        }

    }

}