// Inheritance Learning Activity    Week 07-08
// Author : Nelson Mathurent
// Date:    Feb 18, 2023

public class BreathingActivity : Activity
{
    private string _message1;
    private string _message2;

    // Constructor that has two parameters, the activity name and the description.
    public BreathingActivity(string activityName, string description): base(activityName, description)
    {

    }

    // Returns the homework list
    // public string GetHomeworkList()
    // {
    //     return $"Section {_textbookSection} Problems {_problems}";
    // }

}