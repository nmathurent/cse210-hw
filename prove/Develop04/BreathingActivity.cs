// Inheritance Learning Activity    Week 07-08
// Author : Nelson Mathurent
// Date:    Feb 18, 2023

public class BreathingActivity : Activity
{
    private string _message1 = "Breath in..";
    private string _message2 = "Now breath out...";

    // Constructor that has two parameters, the activity name and the description.
    public BreathingActivity(string activityName, string description): base(activityName, description)
    {

    }

    // Method to run the breathing activity
    public void RunBreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this.GetDuration());

        DateTime currentTime = DateTime.Now;
        // Run the breathing activity for the duration in seconds specified by the user
        while (currentTime < futureTime)
        {
            Console.WriteLine("");
            Console.Write($"{_message1}");
            this.PausingShowingAnimation(4);
            Console.WriteLine("");
            Console.Write($"{_message2}");
            this.PausingShowingAnimation(6);
            currentTime = DateTime.Now;
            Console.WriteLine("");
        }
    }

}

