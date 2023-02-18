// Inheritance Learning Activity    Week 07-08
// Author : Nelson Mathurent
// Date:    Feb 18, 2023

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public string GetActivityName() {
        return _activityName;
    }
    
    // Constructor that has two parameters, one for the activity name and one for the description.
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    // Method to display the starting message
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());
    }


 // Method to display the ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        PausingShowingSpinner();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName} Activity.");
        PausingShowingSpinner();
    }

 // Method to pause the program execution showing a spinner
    public void PausingShowingSpinner()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        // string dateFormat = "MM/dd/yyyy hh:mm:ss";
        // Console.WriteLine("Original date: {0} ({1:N0} ticks)\n",
        //                 startTime.ToString(dateFormat), startTime.Ticks);
        // Console.WriteLine("Original date: {0} ({1:N0} ticks)\n",
        //                 futureTime.ToString(dateFormat), futureTime.Ticks);
        //Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
           // Console.Clear();
            Console.Write("\\");
            Thread.Sleep(400);
            Console.Write("\b \b"); // Erase the \ character
            Console.Write("|");     // Replace it with the | character
            Thread.Sleep(400);
            Console.Write("\b \b"); // Erase the | character
            Console.Write("/");     // Replace it with the / character
            Thread.Sleep(400);
            Console.Write("\b \b"); // Erase the / character
            Console.Write("-");     // Replace it with the - character
            Thread.Sleep(400);
            Console.Write("\b \b"); // Erase the / character
        }
    }
}