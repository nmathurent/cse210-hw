// Inheritance Learning Activity    Week 07-08
// Author : Nelson Mathurent
// Date:    Feb 18, 2023

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.",
                                                      "Think of a time when you did something really difficult.",
                                                      "Think of a time when you helped someone in need.",
                                                      "Think of a time when you did something truly selfless."};
    private List<string> _promptSelected = new List<string> {"N", "N", "N", "N"};

    private List<string> _questions = new List<string> {"Why was this experience meaningful to you?",
                                                        "Have you ever done anything like this before?",
                                                        "How did you get started?",
                                                        "How did you feel when it was complete?",
                                                        "What made this time different than other times when you were not as successful?",
                                                        "What is your favorite thing about this experience?",
                                                        "What could you learn from this experience that applies to other situations?",
                                                        "What did you learn about yourself through this experience?",
                                                        "How can you keep this experience in mind in the future?"};
    private List<string> _questionSelected = new List<string> {"N", "N", "N", "N","N", "N", "N", "N", "N"};

    // Constructor that has two parameters, the activity name and the description.
    public ReflectingActivity(string activityName, string description): base(activityName, description)
    {

    }

    // Method to run the reflecting activity
    public void RunReflectingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this.GetDuration());

        DateTime currentTime = DateTime.Now;
        // Run the reflecting activity for the duration in seconds specified by the user
        DisplayPrompt();
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        this.PausingShowingAnimation(5);
        Console.Clear();
        currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            DisplayQuestion();
            currentTime = DateTime.Now;
        }
    }

    // Method to display the prompt
    public void DisplayPrompt()
    {
         Console.WriteLine("Consider the following prompt:");
         Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
         Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
         
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

    // Method to display the prompt
    public void DisplayQuestion()
    {
         Console.Write($"\n> {GetRandomQuestion()}");
         this.PausingShowingSpinner();
      
    }

    // Returns a random question fron the list of questions
    public string GetRandomQuestion()
    {
        // Instantiate random number generator
        // Found in https://www.geeksforgeeks.org/c-sharp-random-next-method/
        Random rand = new Random();
        string question;

        // Choose a ramdom number 
        int randQuestion = rand.Next(_questions.Count);
        question = _questions[randQuestion];
        // Next Loop is used to check if the question was already selected
        while (_questionSelected[randQuestion] == "Y") {

                randQuestion = rand.Next(_questions.Count);
                question = _questions[randQuestion];
                // If all questions were already selected, unselected them all to use them again
                if (_questionSelected.Contains("N") == false) {
                   for (int i = 0; i < _questionSelected.Count; i++) {
                        _questionSelected[i] = "N";
                    }
                }
        }
        _questionSelected[randQuestion] = "Y";
        return question;
    }

}