// Inheritance Learning Activity    Week 07-08
// Author : Nelson Mathurent
// Date:    Feb 21, 2023

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {"Who are people that you appreciate?",
                                                      "What are personal strengths of yours?",
                                                      "Who are people that you have helped this week?",
                                                      "When have you felt the Holy Ghost this month?",
                                                      "Who are some of your personal heroes?"};
    private List<string> _promptSelected = new List<string> {"N", "N", "N", "N", "N"};

    // Constructor that has two parameters, the activity name and the description.
    public ListingActivity(string activityName, string description): base(activityName, description)
    {

    }

    // Method to run the listing activity
    public void RunListingActivity()
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime  = DateTime.Now;
        int listItemsCount = 0;
        
        // Run the listing activity for the duration in seconds specified by the user
        
        DisplayPrompt();
        currentTime = DateTime.Now;
        futureTime = currentTime.AddSeconds(this.GetDuration());
        Console.WriteLine("");

        while (currentTime < futureTime)
        {
            AskForListingItems();
            listItemsCount += 1;
            currentTime = DateTime.Now;
        }
        Console.Write($"\nYou listed {listItemsCount} items!");
    }

    public void AskForListingItems()
    {
         Console.Write("> ");
         Console.ReadLine();
    }

    // Method to display the prompt
    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        this.PausingShowingAnimation(5); 
    }

    // Returns a random prompt fron the list of prompts
    public string GetRandomPrompt()
    {
        // Instantiate random number generator
        // Found in https://www.geeksforgeeks.org/c-sharp-random-next-method/
        Random rand = new Random();
        string prompt;

        // Choose a ramdom number 
        int randPrompt = rand.Next(_prompts.Count);
        prompt = _prompts[randPrompt];
        // Next Loop is used to check if the prompt was already selected
        while (_promptSelected[randPrompt] == "Y") {

                randPrompt = rand.Next(_prompts.Count);
                prompt = _prompts[randPrompt];
                // If all prompts were already selected, unselected them all to use them again
                if (_promptSelected.Contains("N") == false) {
                   for (int i = 0; i < _promptSelected.Count; i++) {
                        _promptSelected[i] = "N";
                    }
                }
        }
        _promptSelected[randPrompt] = "Y";
        return prompt;
    }

}