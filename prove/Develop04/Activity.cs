// Inheritance Learning Activity    Week 07-08
// Author : Nelson Mathurent
// Date:    Feb 18, 2023

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public int GetDuration() {
        return _duration;
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
        Boolean isNumerical = false;

        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.\n");
        Console.WriteLine($"{_description}\n");
         
        // Validate the user enter a  numeric value
        while (!isNumerical) {
            Console.Write("How long, in seconds, would you like for your session? ");  
            isNumerical = int.TryParse(Console.ReadLine(), out _duration); 
        }
        Console.Clear();
        Console.WriteLine($"Get Ready...");
        PausingShowingSpinner();
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

    // Method to run the breathing activity
    public void PausingShowingAnimation(int numberOfSeconds)
    {
        
            for (int i = numberOfSeconds; i > 0; i--) 
            {
                Console.Write(i.ToString());
                Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the number character
            }

    }

    // Returns a random prompt fron the list of prompts
    public string GetRandomPrompt(List<string> prompts, List<string> promptSelected,
                                  out List<string> promptsOut, out List<string> promptSelectedOut)
    {
        // Instantiate random number generator
        // Found in https://www.geeksforgeeks.org/c-sharp-random-next-method/
        Random rand = new Random();
        string prompt;

        // Choose a ramdom number 
        int randPrompt = rand.Next(prompts.Count);
        prompt = prompts[randPrompt];
        foreach (var item in promptSelected)
        {
            Console.WriteLine(item); 
        }
        // Next Loop is used to check if the prompt was already selected
        while (promptSelected[randPrompt] == "Y") {

                randPrompt = rand.Next(prompts.Count);
                prompt = prompts[randPrompt];
                // If all prompts were already selected, unselected them all to use them again
                if (promptSelected.Contains("N") == false) {
                   for (int i = 0; i < promptSelected.Count; i++) {
                        promptSelected[i] = "N";
                    }
                }
        }
        promptSelected[randPrompt] = "Y";
        promptsOut = prompts;
        promptSelectedOut = promptSelected;

        return prompt;
    }

}